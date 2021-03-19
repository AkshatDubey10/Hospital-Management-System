using System;
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
    public partial class Appointment : Form {
        public SqlConnection conn;
        public Panel panel1;
        public string patientName;
        public Appointment(Panel panel) {
            panel1 = panel;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Text = "Register Patient";
            button2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            button2.Text = "Proceed to Appointment Booking";
            button2.Enabled = false;
            textBox1.Enabled = true;
            button1.Enabled = true;
        }

        private void Appointment_Load(object sender, EventArgs e) {
            conn = new SqlConnection("Server=.\\SQLEXPRESS;database=HospitalDB;Integrated Security=true ");
            button2.Enabled = false;
            textBox1.Enabled = false;
            button1.Enabled = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label3.Visible = true;
                return;
            }
            conn.Open(); 
            SqlCommand readPatientComm = new SqlCommand("select ssn,name from patient where name='" + textBox1.Text + "' or ssn='" + textBox1.Text + "';", conn);
            SqlDataReader readerPatient = readPatientComm.ExecuteReader();
            if (readerPatient.Read()) {
                patientName=readerPatient.GetString(1);
                button2.Enabled = true;
            }
            else {
                MessageBox.Show("No such record found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            readerPatient.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            if(radioButton1.Checked) {
                panel1.Controls.Clear();
                PatientRegistration registration = new PatientRegistration(panel1);
                registration.TopLevel = false;
                registration.AutoScroll = true;
                panel1.Controls.Add(registration);
                registration.Show();
            }
            else {
                panel1.Controls.Clear();
                BookAppointments obj = new BookAppointments(patientName);
                obj.TopLevel = false;
                obj.AutoScroll = true;
                panel1.Controls.Add(obj);
                obj.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label3.Visible = false;
        }
    }
}