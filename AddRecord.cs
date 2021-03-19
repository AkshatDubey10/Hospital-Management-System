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
    public partial class AddRecord : Form {

        public Panel panel1;
        public AddRecord(Panel panel) {
            InitializeComponent();
            panel1 = panel;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked == true) {
                panel1.Controls.Clear();
                AddPhysician addPhysician = new AddPhysician();
                addPhysician.TopLevel = false;
                addPhysician.AutoScroll = true;
                panel1.Controls.Add(addPhysician);
                addPhysician.Show();
            }
            else if (radioButton2.Checked == true) {
                panel1.Controls.Clear();
                AddNurse addNurse = new AddNurse();
                addNurse.TopLevel = false;
                addNurse.AutoScroll = true;
                panel1.Controls.Add(addNurse);
                addNurse.Show();
            }
            else if (radioButton3.Checked == true) {
                panel1.Controls.Clear();
                AddStaff addStaff = new AddStaff();
                addStaff.TopLevel = false;
                addStaff.AutoScroll = true;
                panel1.Controls.Add(addStaff);
                addStaff.Show();
            }
            else {
                MessageBox.Show("Please select a option to proceed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
