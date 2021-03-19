using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System {
    public partial class Form2 : Form {
        string username;
        public Form2(string user) {
            InitializeComponent();
            username = user;
        }

        private void button1_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            Appointment bookAppointment = new Appointment(panel2);
            bookAppointment.TopLevel = false;
            bookAppointment.AutoScroll = true;
            panel2.Controls.Add(bookAppointment);
            bookAppointment.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            ViewAppointment viewAppointment = new ViewAppointment();
            viewAppointment.TopLevel = false;
            viewAppointment.AutoScroll = true;
            panel2.Controls.Add(viewAppointment);
            viewAppointment.Show();
        }

        private void button6_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e) {
            label2.Text = "Welcome " + username;
        }

        private void button3_Click(object sender, EventArgs e) {
            panel2.Controls.Clear();
            BookRoom bookRoom = new BookRoom();
            bookRoom.TopLevel = false;
            bookRoom.AutoScroll = true;
            panel2.Controls.Add(bookRoom);
            bookRoom.Show();
        }
    }
}
