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
    public partial class ViewRooms : Form {

        ConnectionDB conn = new ConnectionDB();
        private static ArrayList Listroomno = new ArrayList();
        private static ArrayList Listroomtype = new ArrayList();
        private static ArrayList Listavailable = new ArrayList();
        public ViewRooms() {
            InitializeComponent();
        }

        private void ViewRooms_Load(object sender, EventArgs e) {
            dataGridView1.Rows.Clear();
            Listroomno.Clear();
            Listroomtype.Clear();
            Listavailable.Clear();
            GetData();
            if (Listroomno.Count > 0) {
                updateDatagrid();
            }
        }
        private void GetData() {
            try {
                conn.Open();
                string query = "select * from room";
                SqlDataReader row;
                row = conn.ExecuteReader(query);
                if (row.HasRows) {
                    while (row.Read()) {
                        Listroomno.Add(row["roomno"].ToString());
                        Listroomtype.Add(row["roomtype"].ToString());
                        Listavailable.Add(row["unavailable"].ToString()=="True"?"No":"Yes");
                    }
                }
                else {
                    MessageBox.Show("Data not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception err) {
                MessageBox.Show(err.ToString());
            }

        }

        private void updateDatagrid() {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Listroomno.Count; i++) {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = Listroomno[i];
                newRow.Cells[1].Value = Listroomtype[i];
                newRow.Cells[2].Value = Listavailable[i];
                dataGridView1.Rows.Add(newRow);
            }
        }
    }
}
