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
    public partial class ViewPhysicians : Form {

        ConnectionDB conn = new ConnectionDB();
        private static ArrayList ListID = new ArrayList();    
        private static ArrayList Listname = new ArrayList();
        private static ArrayList Listposition = new ArrayList();
        private static ArrayList Listdeptid = new ArrayList();
        public ViewPhysicians() {
            InitializeComponent();
        }

        private void ViewPhysicians_Load(object sender, EventArgs e) {
            label3.Visible = false;
            GetData("select * from physician","Data not found");
            if (ListID.Count > 0) {
                updateDatagrid();
            }
        }
        private void GetData(string query,string error) {
            try {
                dataGridView1.Rows.Clear();
                ListID.Clear();
                Listname.Clear();
                Listposition.Clear();
                Listdeptid.Clear();
                conn.Open();
                SqlDataReader row;
                row = conn.ExecuteReader(query);
                if (row.HasRows) {
                    while (row.Read()) {
                        ListID.Add(row["employeeid"].ToString());
                        Listname.Add(row["name"].ToString());
                        Listposition.Add(row["position"].ToString());
                        Listdeptid.Add(row["departmentid"].ToString());
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
                int present = ListID.IndexOf(textBox1.Text);
                if (present == -1) {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                conn.ExecuteNonQuery(query);
                MessageBox.Show("Record successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                dataGridView1.Rows.Clear();
                ListID.Clear();
                Listname.Clear();
                Listposition.Clear();
                Listdeptid.Clear();
                GetData("select * from physician", "Data not found");
                if (ListID.Count > 0) {
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
            for (int i = 0; i < ListID.Count; i++) {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListID[i];
                newRow.Cells[1].Value = Listname[i];
                newRow.Cells[2].Value = Listposition[i];
                newRow.Cells[3].Value = Listdeptid[i];
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label3.Visible = true;
                return;
            }
            GetData("select * from physician where employeeid=" + textBox1.Text + ";", "Invalid employee ID entered");
            if (ListID.Count > 0) {
                updateDatagrid();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label3.Visible = true;
                return;
            }
            DeleteData("delete from physician where employeeid=" + textBox1.Text + ";", "Invalid employee ID entered");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e) {
            label3.Visible = false;
            GetData("select * from physician", "Invalid employee ID entered");
            if (ListID.Count > 0) {
                updateDatagrid();
            }
        }
    }
}
