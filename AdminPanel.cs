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
    public partial class AdminPanel : Form {

        private Form1 form1;
        public AdminPanel(Form1 form) {
            form1 = form;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            ViewPatients viewPatients = new ViewPatients();
            viewPatients.TopLevel = false;
            viewPatients.AutoScroll = true;
            panel2.Controls.Add(viewPatients);
            viewPatients.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            ViewPhysicians viewPhysicians = new ViewPhysicians();
            viewPhysicians.TopLevel = false;
            viewPhysicians.AutoScroll = true;
            panel2.Controls.Add(viewPhysicians);
            viewPhysicians.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            ViewAppointmentsAdmin viewAppointmentsAdmin = new ViewAppointmentsAdmin();
            viewAppointmentsAdmin.TopLevel = false;
            viewAppointmentsAdmin.AutoScroll = true;
            panel2.Controls.Add(viewAppointmentsAdmin);
            viewAppointmentsAdmin.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            ViewNurses viewNurses = new ViewNurses();
            viewNurses.TopLevel = false;
            viewNurses.AutoScroll = true;
            panel2.Controls.Add(viewNurses);
            viewNurses.Show();
        }

        private void button5_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            ViewRooms viewRooms = new ViewRooms();
            viewRooms.TopLevel = false;
            viewRooms.AutoScroll = true;
            panel2.Controls.Add(viewRooms);
            viewRooms.Show();
        }

        private void button6_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            ViewUsers viewUsers = new ViewUsers();
            viewUsers.TopLevel = false;
            viewUsers.AutoScroll = true;
            panel2.Controls.Add(viewUsers);
            viewUsers.Show();
        }

        private void button8_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            AddRecord addRecord = new AddRecord(panel2);
            addRecord.TopLevel = false;
            addRecord.AutoScroll = true;
            panel2.Controls.Add(addRecord);
            addRecord.Show();
        }

        private void button9_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            UpdateRecord updateRecord = new UpdateRecord(panel2);
            updateRecord.TopLevel = false;
            updateRecord.AutoScroll = true;
            panel2.Controls.Add(updateRecord);
            updateRecord.Show();
        }

        private void button10_Click(object sender, EventArgs e) {
            this.Close();
            form1.Show();
        }

        private void button11_Click(object sender, EventArgs e) {
            panel2.BackgroundImage = null;
            panel2.Controls.Clear();
            DB_Backup_Restore db = new DB_Backup_Restore();
            db.TopLevel = false;
            db.AutoScroll = true;
            panel2.Controls.Add(db);
            db.Show();
        }
    }
}
