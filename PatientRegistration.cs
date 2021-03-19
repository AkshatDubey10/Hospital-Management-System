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
    public partial class PatientRegistration : Form {

        private Panel panel1;
        public PatientRegistration(Panel panel) {
            panel1 = panel;
            InitializeComponent();
        }
        SqlConnection conn;

        private void PatientRegistration_Load(object sender, EventArgs e) {
            textBox2.MaxLength = 10;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            conn = new SqlConnection("Server=.\\SQLEXPRESS;database=HospitalDB;Integrated Security=true");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label7.Visible = true;
            }
            if (richTextBox1.TextLength == 0) {
                label8.Visible = true;
            }
            if (textBox2.TextLength == 0) {
                label9.Text = "*Required Field";
                label9.Visible = true;
            }
            if (textBox2.TextLength > 0 && textBox2.TextLength < 10) {
                label9.Text = "Enter a valid mobile number";
                label9.Visible = true;
            }
            if (label7.Visible == true || label8.Visible == true || label9.Visible == true)
                return;
            else {
                conn.Open();
                SqlCommand readLastPatientId = new SqlCommand("select ssn from patient order by ssn desc", conn);
                SqlDataReader reader;
                int patientId = 1001;
                try {
                    reader = readLastPatientId.ExecuteReader();
                    if (reader.Read()) {
                        patientId = reader.GetInt32(0) + 1;
                    }
                    reader.Close();
                    string query = "insert into patient values(" + patientId + ",'" + textBox1.Text + "','" + richTextBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "');";
                    SqlCommand enterPatientIntoDB = new SqlCommand(query, conn);
                    enterPatientIntoDB.ExecuteNonQuery();
                    enterPatientIntoDB.Dispose();
                    conn.Close();
                    MessageBox.Show("Patient Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Controls.Clear();
                    BookAppointments bookAppointment = new BookAppointments(textBox1.Text);
                    bookAppointment.TopLevel = false;
                    bookAppointment.AutoScroll = true;
                    panel1.Controls.Add(bookAppointment);
                    bookAppointment.Show();
                    Console.WriteLine(dateTimePicker1.Value.ToShortDateString());
                }
                catch (Exception E) {
                    MessageBox.Show(E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    conn.Close();
                }
            }
            //MessageBox.Show("Patient Registration Successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label7.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            label8.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            label9.Visible = false;
        }
    }
}