using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System {
    public partial class DB_Backup_Restore : Form {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public DB_Backup_Restore() {
            InitializeComponent();
        }

        private void DB_Backup_Restore_Load(object sender, EventArgs e) {
            comboBox1.Items.Add("Select a server");
            comboBox2.Items.Add("Select a database");
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = 0;
            serverName(".");
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
        }
        public void serverName(string str) {
            con = new SqlConnection("Server=.\\SQLEXPRESS;database=Master;Integrated Security=true ");
            con.Open();
            cmd = new SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con);

            dr = cmd.ExecuteReader();

            while (dr.Read()) {
                comboBox1.Items.Add(dr[2]);

            }

            dr.Close();
            con.Close();

        }
        public void Createconnection() {
            try {
                con = new SqlConnection("Server=.\\SQLEXPRESS;database=Master;Integrated Security=true ");
                con.Open();
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Select a database");
                comboBox2.SelectedIndex = 0;
                cmd = new SqlCommand("select * from sysdatabases", con);
                dr = cmd.ExecuteReader();
                //MessageBox.Show(dr.HasRows.ToString());
                while (dr.Read()) {
                    comboBox2.Items.Add(dr[0]);

                }

                dr.Close();
 
            }
            catch(Exception e) {
                MessageBox.Show("Error in making connection to Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int query(string que) {
            try {
                cmd = new SqlCommand(que, con);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch(Exception e) {
                MessageBox.Show(e.Message.ToString());
                return -1;
            }

        }
        public void backup_restore(string str) {

            if (comboBox1.SelectedIndex==0) {
                // label3.Visible = true;
                MessageBox.Show("Please select a Server Name to proceed","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            if(comboBox2.SelectedIndex == 0 && comboBox2.Enabled==true) {
                MessageBox.Show("Please select a Database name to proceed","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(textBox1.Enabled==true && textBox1.TextLength == 0) {
                MessageBox.Show("Please enter a database name to continue","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else {
                if (str == "backup") {
                    try {
                        saveFileDialog.FileName = comboBox2.Text;
                        saveFileDialog.Filter = "SQL Server Database Backup files|*.bak";
                        saveFileDialog.Title = "Create Database Backup";
                        bool check2=saveFileDialog.ShowDialog()==DialogResult.OK;
                        string s = null;
                        s = saveFileDialog.FileName;
                        int check=check2?query("Backup database " + comboBox2.Text + " to disk='" + s + "'"):-1;
                        if (check == 1 && check2==true) {
                            MessageBox.Show("Database Backup has been created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            comboBox2.SelectedIndex = 0;
                            radioButton1.Checked = false;
                        }
                        else {
                            throw new Exception();
                        }
                    }
                    catch (Exception err) {
                        comboBox2.SelectedIndex = 0;
                        radioButton1.Checked = false;
                        MessageBox.Show("Database Backup unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (str == "restore") {
                    try {
                        openFileDialog.Filter = "SQL Server Database Restore files|*.bak";
                        openFileDialog.Title = "Restore Database Backup";
                        bool check2 = openFileDialog.ShowDialog() == DialogResult.OK;
                        int check=check2?query("IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'" + textBox1.Text + "') DROP DATABASE " + textBox1.Text + " RESTORE DATABASE " + textBox1.Text + " FROM DISK = '" + openFileDialog.FileName + "'"):-1;
                        if (check == 1 && check2==true) {
                            MessageBox.Show("Database restored successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Text = "";
                            radioButton2.Checked = false;
                        }
                        else {
                            throw new Exception();
                        }
                    }
                    catch (Exception e) {
                        textBox1.Text = "";
                        radioButton2.Checked = false;
                        MessageBox.Show("Database restore unsuccessful","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == 0) {
                return;
            }
            Createconnection();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked == false && radioButton2.Checked == false) {
                //MessageBox.Show(radioButton1.Checked.ToString());
                MessageBox.Show("Please select an option between backup and restore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (radioButton1.Checked == true) {
                backup_restore("backup");
            }
            else if (radioButton2.Checked == true) {
                backup_restore("restore");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked == true) {
                comboBox2.Enabled = true;
                textBox1.Text = "";
                textBox1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked == true) {
                comboBox2.Enabled = false;
                comboBox2.SelectedIndex = 0;
                textBox1.Enabled = true;
            }
        }
    }
}