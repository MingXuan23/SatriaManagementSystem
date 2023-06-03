using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatriaManagementSystem__Event_Project_
{
    //hello world
    public partial class SuperAdminForm : Form
    {
        SatriaManagementDatabaseEntities ent = new SatriaManagementDatabaseEntities();

        Staff newStaff = new Staff();
        public SuperAdminForm()
        {
            InitializeComponent();
        }

        private void SuperAdminForm_Load(object sender, EventArgs e)
        {
            initialiseStaff();
            var blocks = ent.Blocks.ToList();
            comboBoxBlock.Items.Clear();
            comboBoxBlock.Items.Add("All");
            foreach (var b in blocks)
                comboBoxBlock.Items.Add(b.Name);
            comboBoxBlock.SelectedIndex = comboBoxType.SelectedIndex = 0;
            initialiseTransaction(null, null);
            // TODO: This line of code loads data into the 'satriaManagementDatabaseDataSet1.Blocks' table. You can move, or remove it, as needed.
            this.blocksTableAdapter.Fill(this.satriaManagementDatabaseDataSet1.Blocks);
            var block = ent.Blocks.ToList();
            dataGridView2.Rows.Clear();
            foreach (var b in block)
            {
                var rows = new object[6];
                rows[0] = b.ID;
                rows[1] = b.Name;
                rows[2] = b.Gender ? "Male" : "Female";
                rows[3] = "RM" + b.Asset.ToString("0.00");
                rows[4] = b.Capacity + " Rooms";
                rows[5] = b.Status ? "Open" : "Closed";
                dataGridView2.Rows.Add(rows);
            }
        }

        public void initialiseTransaction(long? blockid, bool? type)
        {
            dataGridView1.Rows.Clear();
            var blocks = ent.Blocks.ToList();
            if (blockid != null)
                blocks = blocks.Where(b => b.ID == blockid).ToList();
            foreach (var b in blocks)
            {
                if (type == null || type==true)
                {
                    List<long> staffs = ent.Staffs.Where(x => x.BlockID == b.ID).Select(x => x.StaffID).ToList();
                    var staffTransaction = ent.Staff_Transaction.Where(x => staffs.Contains(x.StaffID)).ToList();
                    foreach (var t in staffTransaction)
                    {
                        var rows = new object[6];
                        rows[0] = t.TransactionID;
                        rows[1] = t.Transaction.Amount;
                        rows[2] = t.Transaction.TransactionDate;
                        rows[3] = b.Name;
                        rows[4] = t.Transaction.Withdrawal ? "Withdrawal" : "Deposit";
                        rows[5] = t.Description;
                        dataGridView1.Rows.Add(rows);
                    }
                }
                if (type == null || type == false){
                    var studentRoom = ent.Student_Room.Where(x => x.Room.BlockID == b.ID && x.TransactionID != null).ToList();
                    foreach (var s in studentRoom)
                    {
                        var rows = new object[6];
                        rows[0] = s.TransactionID;
                        rows[1] = s.Transaction.Amount;
                        rows[2] = s.Transaction.TransactionDate;
                        rows[3] = b.Name;
                        rows[4] = s.Transaction.Withdrawal ? "Withdrawal" : "Deposit";
                        rows[5] = $"{s.Student.User.FullName} paid room fee of {s.Room.RoomNo}";
                        dataGridView1.Rows.Add(rows);
                    }
                }

                

            }

        }
        private void radioButtonCheckBalance_CheckedChanged(object sender, EventArgs e)
        {
            //panelBalanceInquiry
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView2.Rows[e.RowIndex].Selected = true;


        }

        public void loadStaff(long id)
        {
            SatriaManagementDatabaseEntities entNew = new SatriaManagementDatabaseEntities();
            var staffs = entNew.Staffs.Where(x => x.BlockID == id).ToList();
            
            dataGridView3.Visible = true;
            dataGridView3.Rows.Clear();
            foreach (var staff in staffs)
            {
                staff.getUserByID(staff.StaffID);
                var rows = new object[9];
                rows[0] = staff.ID;
                rows[1] = staff.FullName;
                rows[2] = staff.Block.Name;
                rows[3] = staff.DateStartWork;
                rows[4] = staff.Salary;

                int payMonth = 0;
                for (int i = 0; true; i++)
                {
                    var totalMonth = staff.DateStartWork.AddMonths(i);
                    if (totalMonth.Year == DateTime.Now.Year && totalMonth.Month == DateTime.Now.Month)
                    {
                        payMonth = i + 1;
                        break;
                    }
                }
                int payFrequency = entNew.Staff_Transaction.Where(x => x.StaffID == staff.StaffID).Count();
                Func<decimal, decimal, decimal,decimal> calculateSalary = (x, y,z) => (x -y)  * z;
                
                rows[5] = "RM " + calculateSalary(payMonth,payFrequency,staff.Salary).ToString("0.00");

                rows[6] = "Update";
                rows[7] = payMonth;
                rows[8] = payFrequency;
                //var payamount=staff.Staff_Transaction.Where(x=>x.Transaction.TransactionDate)
                dataGridView3.Rows.Add(rows);
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridView3.Rows[dataGridView3.RowCount - 2].Cells[5];
                buttonCell.FlatStyle = FlatStyle.Popup;
                if (payMonth - payFrequency == 0)
                {

                    buttonCell.Style.BackColor = Color.LightSeaGreen;
                }
                else
                {
                    buttonCell.Style.BackColor = Color.IndianRed;
                }


            }
        }

        public void initialiseStaff()
        {
            textBoxFullName.DataBindings.Add("Text", newStaff, "FullName");
            textBoxUsername.DataBindings.Add("Text", newStaff, "Username");
            textBoxPassword.DataBindings.Add("Text", newStaff, "Password");
            textBoxEmail.DataBindings.Add("Text", newStaff, "Email");
            textBoxPhoneNo.DataBindings.Add("Text", newStaff, "PhoneNum");
            radioButtonMale.DataBindings.Add("Checked", newStaff, "Gender");
            numericSalary.DataBindings.Add("Value", newStaff, "Salary");
            newStaff.DateStartWork = DateTime.Now;
            newStaff.SuperAdmin = false;
            newStaff.UserTypeID = 2;
            newStaff.Status = true;

        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageAddNewStaff.Controls)
            {
                if (control is TextBox && control.Text == "")
                {
                    MessageBox.Show("Please fill all required fields");
                    return;
                }
            }
            if (textBoxPassword.Text != textBoxConfirmPass.Text)
            {
                MessageBox.Show("Please enter same passwords");
                return;
            }
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please select your gender");
                return;
            }
            if (ent.Users.Any(x => x.Username == textBoxUsername.Text))
            {
                MessageBox.Show("Username exists!");
                return;
            }
     
            decimal result;
            if (!decimal.TryParse(textBoxPhoneNo.Text, out result))
            {
                MessageBox.Show("Please filled valid phoen number");
                return;
            }
            newStaff.BlockID = (long)comboBoxBlockID.SelectedValue;
           
            try
            {
                newStaff.addUser();
                resetAdd();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            

        }

        public void resetAdd()
        {
            foreach(Control control in tabPageAddNewStaff.Controls)
            {
                if (control is TextBox)
                    control.Text = "";
                else if (control is NumericUpDown)
                {
                    var c = control as NumericUpDown;
                    c.Value = 0;
                }
                else if(control is RadioButton)
                {
                    var c =control as RadioButton;
                    c.Checked = false;
                }
                else if(control is CheckBox)
                {
                    var c = control as CheckBox;
                    c.Checked = false;
                }
            }
        }
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count != 0)
            {
                var row = dataGridView2.SelectedCells[0].RowIndex;
                dataGridView2.Rows[row].Selected = true;
            }
            if (dataGridView2.SelectedRows.Count == 0)
                return;
            var blockid = dataGridView2.SelectedRows[0].Cells[0].Value;
            //var blockid = dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            if (blockid == null)
                return;

            loadStaff(long.Parse(blockid.ToString()));
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Rows[e.RowIndex].Cells[0].Value == null)
                return;
            long staffid = long.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            var staff = ent.Staffs.FirstOrDefault(x => x.StaffID == staffid);

            try
            {
                staff.getUserByID(staffid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (e.ColumnIndex == 5)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[5].Style.BackColor == Color.LightSeaGreen)
                {
                    MessageBox.Show("No Payment to be made!");
                    return;
                }
                var amount = dataGridView3.Rows[e.RowIndex].Cells[5].Value;
                int payMonth = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[7].Value.ToString());
                int payFrequency = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[8].Value.ToString());

                var block = ent.Blocks.FirstOrDefault(x => x.ID == staff.BlockID);
                string numericValue = Regex.Replace(amount.ToString(), "[^0-9.]", "");

                decimal actualAmount = decimal.Parse(numericValue);
                if (block.Asset < actualAmount)
                {
                    MessageBox.Show("Not enough asset to paid salary");
                    return;
                }
                var result = MessageBox.Show($"Do you confirm to pay {amount} to {staff.FullName}?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < payMonth - payFrequency; i++)
                    {
                        Transaction transaction = new Transaction();
                        transaction.ID = ent.Transactions.Any() ? ent.Transactions.Max(x => x.ID) + 1 : 1;
                        transaction.TransactionDate = DateTime.Now;
                        transaction.Withdrawal = true;
                        transaction.Amount = staff.Salary;


                        Staff_Transaction staffTrans = new Staff_Transaction();
                        staffTrans.ID = ent.Staff_Transaction.Any() ? ent.Transactions.Max(x => x.ID) : 1;
                        staffTrans.StaffID = staff.ID;
                        staffTrans.TransactionID = transaction.ID;
                        var date = DateTime.Now.AddMonths(-i);
                        staffTrans.Description = $"Salary {staff.FullName} at {date.Month}-{date.Year}";

                        block.Asset -= actualAmount;
                        ent.Transactions.Add(transaction);
                        ent.Staff_Transaction.Add(staffTrans);
                        ent.SaveChanges();
                        loadStaff((long)staff.BlockID);
                        MessageBox.Show("Payment success");


                    }
                }
            }
            else if (e.ColumnIndex == 6)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[5].Style.BackColor != Color.LightSeaGreen)
                {
                    MessageBox.Show("Please settle previous salary first!");
                    return;
                }
                new UpdateAmount(2, staff.ID).ShowDialog();
                loadStaff((long)staff.BlockID);
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterTransaction();

        }

        public void filterTransaction()
        {
            long? blockid = comboBoxBlock.SelectedIndex;
            if (blockid == 0)
                blockid = null;

            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    initialiseTransaction(blockid, null);
                    break;
                case 1:
                    initialiseTransaction(blockid, false);
                    break;
                case 2:
                    initialiseTransaction(blockid, true);
                    break;
            }
        }

        private void comboBoxBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterTransaction();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void checkBoxShowConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxConfirmPass.UseSystemPasswordChar=!checkBoxShowConfirmPass.Checked;  
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            resetAdd();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = 0;//reset back to 0
            Properties.Settings.Default.UserType = 0;
            Properties.Settings.Default.Save();
            //MessageBox.Show("Logged Out Successfully");
            
            var form = Application.OpenForms["Staff_Form"];
            form.Close();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you confirm to exit application?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    //do nothing
                }
            }

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stylingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result=colorDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Properties.Settings.Default.LogInColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
