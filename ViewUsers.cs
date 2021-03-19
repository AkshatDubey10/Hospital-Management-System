using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System {
    public partial class ViewUsers : Form {

        ConnectionDB conn = new ConnectionDB();
        private static ArrayList Listname = new ArrayList();
        private static ArrayList Listusername = new ArrayList();
        private static ArrayList Listpassword = new ArrayList();
        private static ArrayList Listtype = new ArrayList();
        public ViewUsers() {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e) {
            label3.Visible = false;
            GetData("select * from Users","Data not Found");
            if (Listusername.Count > 0) {
                updateDatagrid();
            }
        }
        private void GetData(string query,string error) {
            try {
                dataGridView1.Rows.Clear();
                Listname.Clear();
                Listusername.Clear();
                Listpassword.Clear();
                Listtype.Clear();
                conn.Open();
                SqlDataReader row;
                row = conn.ExecuteReader(query);
                if (row.HasRows) {
                    while (row.Read()) {
                        Listname.Add(row["name"].ToString());
                        Listusername.Add(row["username"].ToString());
                        Listpassword.Add(row["password"].ToString());
                        Listtype.Add(row["type"].ToString());
                    }
                }
                else {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception err) {
                MessageBox.Show(err.ToString());
            }

        }
        private void DeleteData(string query, string error) {
            try {
                conn.Open();
                int present = Listusername.IndexOf(textBox1.Text);
                if (present == -1) {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conn.ExecuteNonQuery(query);
                MessageBox.Show("Record successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                GetData("select * from Users", "Data not found");
                if (Listusername.Count > 0) {
                    updateDatagrid();
                }
                conn.Close();
            }
            catch (Exception err) {
                MessageBox.Show(err.ToString());
            }

        }

        private void updateDatagrid() {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Listusername.Count; i++) {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = Listname[i];
                newRow.Cells[1].Value = Listusername[i];
                newRow.Cells[2].Value = Listpassword[i];
                newRow.Cells[3].Value = Listtype[i];
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label3.Visible = true;
                return;
            }
            GetData("select * from Users where username='"+textBox1.Text+"';", "Invalid username entered");
            if (Listusername.Count > 0) {
                updateDatagrid();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label3.Visible = true;
                return;
            }
            DeleteData("delete from Users where username='" + textBox1.Text + "';", "Invalid username entered");
        }

        private void button3_Click(object sender, EventArgs e) {
            GetData("select * from Users", "No data found");
            if (Listusername.Count > 0) {
                updateDatagrid();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label3.Visible = false;
        }
    }
}
