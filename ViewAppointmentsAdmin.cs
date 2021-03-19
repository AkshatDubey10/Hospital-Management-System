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
    public partial class ViewAppointmentsAdmin : Form {

        ConnectionDB conn = new ConnectionDB();
        private static ArrayList ListAppointmentID = new ArrayList();
        private static ArrayList ListPatientID = new ArrayList();
        private static ArrayList ListNurseID = new ArrayList();
        private static ArrayList ListPhysicianID = new ArrayList();
        private static ArrayList ListStartDate = new ArrayList();
        private static ArrayList ListEndDate = new ArrayList();
        public ViewAppointmentsAdmin() {
            InitializeComponent();
        }

        private void ViewAppointmentsAdmin_Load(object sender, EventArgs e) {
            label3.Visible = false;
            GetData("select * from appointment","Data not found");
            if (ListAppointmentID.Count > 0 && ListPatientID.Count>0) {
                updateDatagrid();
            }
        }
        private void GetData(string query,string error) {
            try {
                dataGridView1.Rows.Clear();
                ListAppointmentID.Clear();
                ListPatientID.Clear();
                ListNurseID.Clear();
                ListPhysicianID.Clear();
                ListStartDate.Clear();
                ListEndDate.Clear();
                conn.Open();
                //string query = "select * from appointment";
                SqlDataReader row;
                row = conn.ExecuteReader(query);
                if (row.HasRows) {
                    while (row.Read()) {
                        ListAppointmentID.Add(row["appointmentid"].ToString());
                        ListPatientID.Add(row["patient"].ToString());
                        ListNurseID.Add(row["prepnurse"].ToString());
                        ListPhysicianID.Add(row["physician"].ToString());
                        ListStartDate.Add(row["start_dt_time"].ToString());
                        ListEndDate.Add(row["end_dt_time"].ToString());
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
        private void updateDatagrid() {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ListAppointmentID.Count; i++) {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListAppointmentID[i];
                newRow.Cells[1].Value = ListPatientID[i];
                newRow.Cells[2].Value = ListNurseID[i];
                newRow.Cells[3].Value = ListPhysicianID[i];
                newRow.Cells[4].Value = ListStartDate[i];
                newRow.Cells[5].Value = ListEndDate[i];
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label3.Visible = true;
                return;
            }
            GetData("select * from appointment where appointmentid=" + textBox1.Text + ";", "Invalid appointment ID entered");
            if (ListAppointmentID.Count > 0) {
                updateDatagrid();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            label3.Visible = false;
            GetData("select * from appointment", "Invalid employee ID entered");
            if (ListAppointmentID.Count > 0) {
                updateDatagrid();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label3.Visible = false;
        }
    }
}