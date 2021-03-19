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
    public partial class ViewPatients : Form {

        ConnectionDB conn = new ConnectionDB();
        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListFirstname = new ArrayList();
        private static ArrayList ListLastname = new ArrayList();
        private static ArrayList ListTelephone = new ArrayList();
        public ViewPatients() {
            InitializeComponent();
        }

        private void ViewPatients_Load(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            ListID.Clear(); 
            ListFirstname.Clear();
            ListLastname.Clear();
            ListTelephone.Clear();
            GetData();
            if (ListID.Count > 0) {
                updateDatagrid();
            }
        }
        private void GetData() {
            try {
                conn.Open();
                string query = "select * from patient";
                SqlDataReader row;
                row = conn.ExecuteReader(query);
                if (row.HasRows) {
                    while (row.Read()) {
                        ListID.Add(row["ssn"].ToString());
                        ListFirstname.Add(row["name"].ToString());
                        ListLastname.Add(row["address"].ToString());
                        ListTelephone.Add(row["phone"].ToString());
                    }
                }
                else {
                    MessageBox.Show("Data not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                newRow.Cells[1].Value = ListFirstname[i];
                newRow.Cells[2].Value = ListLastname[i];
                newRow.Cells[3].Value = ListTelephone[i];
                dataGridView1.Rows.Add(newRow);
            }
        }
    }
}
