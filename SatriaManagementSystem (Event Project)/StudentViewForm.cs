﻿using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace SatriaManagementSystem__Event_Project_
{
    public partial class StudentViewForm : Form
    {
        SatriaManagementDatabaseEntities ent = new SatriaManagementDatabaseEntities();
        Student student { get; set; }
        bool haveRoom {  get; set; }
        public StudentViewForm(Student student)
        {
            InitializeComponent();
            this.student = student;
            //load data into tab page 2
            loadApplyRoomTable();
            loadStudentInfo();
            loadRoomDetails();
        }        
        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            this.haveRoom = ent.Student_Room.Any(x => x.StudentID == student.ID && x.Status == "Check-in");
            if (this.haveRoom)
            {
                tabControlApplyRoom.SelectedIndex = 2;
            }
            else
            {
                tabControlApplyRoom.SelectedIndex = 0;

            }
        }
        private void loadApplyRoomTable()
        {
            dataGridViewBlock.Rows.Clear();
            var block = ent.Blocks.ToList();
            foreach(var b in block)
            {
                string status = b.Status ? "Open" : "Closed";
                dataGridViewBlock.Rows.Add(b.ID,b.Name,status,"Apply Room");
                if(b.Gender!= student.Gender)
                {
                    dataGridViewBlock.Rows[dataGridViewBlock.RowCount - 2].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }
        private void loadStudentInfo()
        {
            textBoxFullName.Text = student.FullName;
            textBoxEmail.Text = student.Email;
            textBoxPhoneNum.Text = student.PhoneNum;
            textBoxUserName.Text = student.Username;
        }
        private void loadRoomDetails()
        {
            var studentRoom = ent.Student_Room.FirstOrDefault(x => x.Status == "Check-in" && x.StudentID == student.StudentID);
            
            if(studentRoom != null)
            {
                var room = studentRoom.Room;
                var block = room.Block.Name;
                var fee = room.RoomFees;
                var roomNo = room.RoomNo;
                var status = room.Student_Room.Any(x => x.Status == "Check-in" && x.TransactionID != null && x.StudentID == student.StudentID);

                labelDisplayBlock.Text = block;
                labelDisplayRoom.Text = roomNo;
                labelDisplayFee.Text = $"RM{fee}";
                labelDisplayStatus.Text = status ? "Paid" : "Unpaid" ;
                if(status)
                {
                    buttonPay.Hide();
                    buttonViewReceipt.Show();
                }
                else
                {
                    buttonViewReceipt.Hide();
                }
            }
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = 0;//reset back to 0
            Properties.Settings.Default.Save();
            MessageBox.Show("Logged Out Successfully");
            this.Hide();
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            loadStudentInfo();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == string.Empty || textBoxFullName.Text == string.Empty || textBoxPhoneNum.Text == string.Empty || textBoxUserName.Text == string.Empty)
            {
                MessageBox.Show("Please don't leave any fields empty", "Empty Field");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to modify your personal details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    student.FullName = textBoxFullName.Text;
                    student.Email = textBoxEmail.Text;
                    student.Username = textBoxUserName.Text;
                    student.PhoneNum = textBoxPhoneNum.Text;
                    try
                    {
                        student.editUser();
                    }
                    catch (NullReferenceException err)
                    {
                        MessageBox.Show(err.Message);
                        return;
                    }
                    MessageBox.Show("Edit Successful", "Success");
                    loadStudentInfo();
                }
                else
                {
                    return;
                }
            }
        }
       private void tabControlApplyRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.haveRoom && tabControlApplyRoom.SelectedIndex == 0)
            {
                tabControlApplyRoom.SelectedIndex = 2;
                MessageBox.Show("You already have a room","Room Application Closed");
            }else if(!this.haveRoom && tabControlApplyRoom.SelectedIndex == 2)
            {
                tabControlApplyRoom.SelectedIndex = 0;
                MessageBox.Show("Apply for a room first!!", "You don't have a room yet");
            }
        }
        private void dataGridViewBlock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBlock.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.IndianRed)
            {
                string gender = student.Gender ? "Female" : "Male";
                MessageBox.Show("This block is specific for " + gender);
                return;
            }

            if(dataGridViewBlock.Rows[e.RowIndex].Cells[0].Value == null)
            {
                return;
            }
            long blockid = long.Parse(dataGridViewBlock.Rows[e.RowIndex].Cells[0].Value.ToString());
            var block = ent.Blocks.FirstOrDefault(x => x.ID == blockid && x.Status);
            if (block != null && !ent.Student_Room.Any(x => x.StudentID == student.ID))
            {
                var rooms = block.Rooms.Where(x => x.Student_Room.Where(y=>y.Status != "Checkout").Count() < x.MaxCapacity).ToList();
                Student_Room studentRoom = new Student_Room();
                studentRoom.ID = ent.Student_Room.Any() ? ent.Student_Room.Max(x => x.ID + 1): 1;
                studentRoom.RoomID = long.Parse(rooms.FirstOrDefault().ID.ToString());
                studentRoom.StudentID = student.ID;
                studentRoom.Status = "Check-in";
                ent.Student_Room.Add(studentRoom);
                ent.SaveChanges();
                MessageBox.Show("Room Applied");
                haveRoom = true;
                tabControlApplyRoom.SelectedIndex = 2;
                loadRoomDetails();
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed with payment", "Pay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Your existing code to save the transaction ID
                var studentRoom = ent.Student_Room.FirstOrDefault(x => x.Status == "Check-in" && x.StudentID == student.StudentID);
                var studentRoomTransaction = ent.Transactions != null ? ent.Transactions.Max(x => x.ID + 1) : 1;
            
                var roomNo = studentRoom.Room.RoomNo;
                var  fee = studentRoom.Room.RoomFees.ToString();
            
                Transaction transaction = new Transaction();
                transaction.ID = long.Parse(studentRoomTransaction.ToString());
                transaction.Amount = decimal.Parse(fee);
                transaction.TransactionDate = DateTime.Now;
                transaction.Withdrawal = false;
                ent.Transactions.Add(transaction);
                studentRoom.TransactionID = studentRoomTransaction; 
            
                ent.SaveChanges();
           
                // Generate the PDF receipt
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Save Receipt";
                saveFileDialog.FileName = $"Receipt_{studentRoomTransaction}.pdf"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string receiptFilePath = saveFileDialog.FileName;

                    // Create a new Microsoft Word application
                    Word.Application wordApp = new Word.Application();
                    try
                    {
                        // Open a new Word document
                        Word.Document document = wordApp.Documents.Add();

                        // Get the range of the document
                        Word.Range range = document.Content;

                        // Modify the content using the range
                        range.Text += "Payment Receipt:\n";
                        range.Text += "Student: " + student.FullName + "\n";
                        range.Text += $"Matric Number: {student.MatricNumber}\n";
                        range.Text += $"Room Number: {roomNo}\n";
                        range.Text += $"Pay Amount: RM{fee}\n";
                        range.Text += $"Transaction ID: {studentRoomTransaction}\n";
                        range.Text += $"Transaction Time: {ent.Student_Room.FirstOrDefault(x => x.StudentID == student.StudentID).Transaction.TransactionDate}";
                   
                    
                        // Save the document as a PDF
                        document.SaveAs2(receiptFilePath, Word.WdSaveFormat.wdFormatPDF);

                        // Close the document and the Word application
                        document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                    
                        // Show a success message
                        MessageBox.Show("Paid Successfully!");

                        loadRoomDetails();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    finally
                    {
                        // Close and release the Word application
                        wordApp.Quit();
                        Marshal.ReleaseComObject(wordApp);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void buttonViewReceipt_Click(object sender, EventArgs e)
        {
            // Obtain the path of the generated PDF file
            var transactionId = ent.Student_Room.FirstOrDefault(x => x.StudentID == student.StudentID).Transaction.ID;
            string receiptFilePath = $@"C:\Users\AhFei\Downloads\Receipt_{transactionId}.pdf"; // Replace with the actual file path
            // Check if the PDF file exists
            FileInfo fileInfo = new FileInfo(receiptFilePath);
            if (fileInfo.Exists)
            { 
                try
                {
                    // Open the PDF file using the default PDF viewer
                    Process.Start(receiptFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open the PDF file. Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The PDF file does not exist.");
            }
        }
    }
}
