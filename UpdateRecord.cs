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
    public partial class UpdateRecord : Form {
        public Panel panel1;
        public UpdateRecord(Panel panel) {
            InitializeComponent();
            panel1 = panel;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked == true) {
                panel1.Controls.Clear();
                UpdatePhysician updatePhysician = new UpdatePhysician();
                updatePhysician.TopLevel = false;
                updatePhysician.AutoScroll = true;
                panel1.Controls.Add(updatePhysician);
                updatePhysician.Show();
            }
            else if (radioButton2.Checked == true) {
                panel1.Controls.Clear();
                UpdateNurse updateNurse = new UpdateNurse();
                updateNurse.TopLevel = false;
                updateNurse.AutoScroll = true;
                panel1.Controls.Add(updateNurse);
                updateNurse.Show();
            }
            else if (radioButton3.Checked == true) {
                panel1.Controls.Clear();
                UpdateStaff updateStaff = new UpdateStaff();
                updateStaff.TopLevel = false;
                updateStaff.AutoScroll = true;
                panel1.Controls.Add(updateStaff);
                updateStaff.Show();
            }
            else {
                MessageBox.Show("Please select a option to proceed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
