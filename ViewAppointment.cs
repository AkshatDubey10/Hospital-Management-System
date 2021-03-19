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
using System.Collections;

namespace Hospital_Management_System {
    public partial class ViewAppointment : Form {
        public ViewAppointment() {
            InitializeComponent();
        }
        ConnectionDB conn = new ConnectionDB();
        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListPatient = new ArrayList();
        private static ArrayList ListPrep = new ArrayList();
        private static ArrayList ListPhysician = new ArrayList();
        private static ArrayList ListStartTime = new ArrayList();
        private static ArrayList ListEndTime = new ArrayList();
        private void GetData() {
            try {
                dataGridView1.Rows.Clear();
                ListID.Clear();
                ListPatient.Clear();
                ListPrep.Clear();
                ListPhysician.Clear();
                ListStartTime.Clear();
                ListEndTime.Clear();
                int empPhyId = -1;
                bool foundPhy = false;
                //bool foundApp = false;
                conn.Open();
                try {
                    empPhyId = Convert.ToInt32(textBox1.Text);
                    foundPhy = true;
                }
                catch {
                    string query2 = "select employeeid from physician where name='" + textBox1.Text + "';";
                    SqlDataReader readId = conn.ExecuteReader(query2);
                    if (readId.Read()) {
                        foundPhy = true;
                        empPhyId = readId.GetInt32(0);
                    }
                    else {
                        foundPhy = false;
                    }
                    readId.Close();
                }
                string query = "select * from appointment where start_dt_time='" + String.Format("{0}/{1}/{2}", dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day) + "' and physician=" + empPhyId + ";";  
                SqlDataReader row;
                if (foundPhy) {
                    row = conn.ExecuteReader(query);
                    if (row.HasRows) {
                        while (row.Read()) {
                            ListID.Add(row["appointmentid"].ToString());
                            ListPatient.Add(row["patient"].ToString());
                            ListPhysician.Add(row["physician"].ToString());
                            ListPrep.Add(row["prepnurse"].ToString());
                            ListStartTime.Add(row["start_dt_time"].ToString());
                            ListEndTime.Add(row["end_dt_time"].ToString());
                        }
                    }
                    else {
                        MessageBox.Show("Data not found");
                    }
                }
                else {
                    MessageBox.Show("Physician Not Found!!Enter Correct Details!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch (Exception err) {
                MessageBox.Show(err.ToString());
            }

        }
        private void button1_Click(object sender, EventArgs e) {
            GetData();
            if (ListID.Count > 0) {
                updateDatagrid();
            }
        }

        private void updateDatagrid() {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ListID.Count; i++) {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = ListID[i];
                newRow.Cells[1].Value = ListPatient[i];
                newRow.Cells[2].Value = ListPhysician[i];
                newRow.Cells[3].Value = ListPrep[i];
                newRow.Cells[4].Value = ListStartTime[i];
                newRow.Cells[5].Value = ListEndTime[i];
                dataGridView1.Rows.Add(newRow);
            }
        }
    }
}