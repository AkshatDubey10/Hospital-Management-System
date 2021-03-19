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
    public partial class BookRoom : Form {

        ConnectionDB conn=new ConnectionDB();
        int cost = 0;
        public BookRoom() {
            InitializeComponent();
        }

        private void BookRoom_Load(object sender, EventArgs e) {
            label7.Visible = label8.Visible = label9.Visible = false;
            comboBox1.Enabled = comboBox2.Enabled = false;
            dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
            dateTimePicker1.MinDate = dateTimePicker2.MinDate = DateTime.Today;
            comboBox1.SelectedIndex = comboBox2.SelectedIndex = 0;
            textBox2.Enabled = false;
            textBox2.Text = "Room cost";
            button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label7.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.TextLength == 0) {
                label7.Visible = true;
                return;
            }
            else {
                conn.Open();
                SqlDataReader row;
                row=conn.ExecuteReader(string.Format("select ssn from patient where ssn=({0});",textBox1.Text));
                if (row.HasRows) {
                    comboBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox1.ReadOnly = true;
                }
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            comboBox2.Enabled = true;
            if (comboBox1.SelectedIndex == 0) {
                comboBox2.Enabled = false;
                button1.Enabled = false;
                comboBox2.SelectedIndex = 0;
            }
            else if (comboBox1.SelectedIndex == 1) {
                try {
                    conn.Open();
                    SqlDataReader rd = conn.ExecuteReader("");
                    conn.Open();
                    rd = conn.ExecuteReader(string.Format("select cost from room_cost where roomtype='{0}'",comboBox1.SelectedItem));
                    if (rd.HasRows) {
                        while (rd.Read()) {
                            cost=rd.GetInt32(0);
                        }
                    }
                    textBox2.Text ="Cost = "+cost+"/day";
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Please select room number");
                    comboBox2.SelectedIndex = 0;
                    comboBox2.Enabled = true;
                    conn.Close();
                    conn.Open();
                    SqlDataReader row;
                    row = conn.ExecuteReader(string.Format("select * from room where roomtype=('{0}') AND unavailable=0;", comboBox1.SelectedItem.ToString()));
                    if (row.HasRows) {
                        while (row.Read()) {
                            comboBox2.Items.Add(row["roomno"].ToString());
                        }
                    }
                    else {
                        throw new Exception();
                    }
                }
                catch(Exception) {
                    MessageBox.Show("No rooms available at the moment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    textBox2.Enabled = false;
                    comboBox1.SelectedIndex = comboBox2.SelectedIndex = 0;
                    textBox1.ReadOnly = false;
                    textBox2.Text = "Room cost";
                    textBox2.Enabled = false;
                    textBox1.Text = "";
                    button1.Enabled = false;
                }
                finally {
                    conn.Close();
                }
            }
            else if (comboBox1.SelectedIndex == 2) {
                try {
                    conn.Open();
                    SqlDataReader rd = conn.ExecuteReader("");
                    conn.Open();
                    rd = conn.ExecuteReader(string.Format("select cost from room_cost where roomtype='{0}'", comboBox1.SelectedItem.ToString()));
                    if (rd.HasRows) {
                        while (rd.Read()) {
                            cost = rd.GetInt32(0);
                        }
                    }
                    textBox2.Text = "Cost = " + cost + "/day";
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Please select room number");
                    comboBox2.SelectedIndex = 0;
                    comboBox2.Enabled = true;
                    conn.Open();
                    SqlDataReader row;
                    row = conn.ExecuteReader(string.Format("select * from room where roomtype=('{0}') AND unavailable=0;", comboBox1.SelectedItem));
                    if (row.HasRows) {
                        while (row.Read()) {
                            comboBox2.Items.Add(row["roomno"]);
                        }
                    }
                    else {
                        throw new Exception();
                    }
                }
                catch (Exception) {
                    MessageBox.Show("No rooms available at the moment", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    textBox2.Enabled = false;
                    comboBox1.SelectedIndex = comboBox2.SelectedIndex = 0;
                    textBox1.ReadOnly = false;
                    textBox2.Text = "Room cost";
                    textBox2.Enabled = false;
                    textBox1.Text = "";
                    button1.Enabled = false;
                }
                finally {
                    conn.Close();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            dateTimePicker1.Enabled = dateTimePicker2.Enabled = true;
            if (comboBox2.SelectedIndex == 0) {
                dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
                button1.Enabled = false;
            }
            else {
                dateTimePicker1.Enabled = dateTimePicker2.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                conn.Open();
                int stayID = getStayID();
                string fromDate, toDate;
                string fromMonth, fromDay, toMonth, toDay;
                fromMonth = (dateTimePicker1.Value.Month < 9) ? "0" + dateTimePicker1.Value.Month : dateTimePicker1.Value.Month + "";
                fromDay = (dateTimePicker1.Value.Day < 9) ? "0" + dateTimePicker1.Value.Day : dateTimePicker1.Value.Day + "";
                toMonth = (dateTimePicker1.Value.Month < 9) ? "0" + dateTimePicker1.Value.Month : dateTimePicker1.Value.Month + "";
                toDay = (dateTimePicker2.Value.Day < 9) ? "0" + dateTimePicker2.Value.Day : dateTimePicker2.Value.Day + "";
                fromDate = dateTimePicker1.Value.Year + "/" + fromMonth + "/" + fromDay;
                toDate = dateTimePicker2.Value.Year + "/" + toMonth + "/" + toDay;
                conn.Open();
                string query = string.Format("insert into stay values ({0},{1},'{2}','{3}','{4}');",stayID,textBox1.Text,comboBox2.SelectedItem,fromDate,toDate);
                conn.ExecuteNonQuery(query);
                //MessageBox.Show(x.ToString());
                conn.ExecuteNonQuery("update room set unavailable=1,occuby=" + textBox1.Text + " where roomno=" + comboBox2.SelectedItem + ";");
                MessageBox.Show("Room Booked Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox2.SelectedIndex = 0;
                comboBox1.SelectedIndex = 0;
                textBox1.Text = "";
                comboBox1.Enabled = comboBox2.Enabled = dateTimePicker1.Enabled = dateTimePicker2.Enabled = false;
            }
            catch(Exception) {
                MessageBox.Show("Room booking unsuccessful","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally {
                conn.Close();
            }
        }
        private int getStayID() {
            try {
                conn.Open();
                string query = "select max(stayid) as count from stay;";
                SqlDataReader read = conn.ExecuteReader(query);
                if (read.Read()) {
                    if (!read.IsDBNull(0))
                        return read.GetInt32(0) + 1;
                    else return 1;
                }
                else {
                    read.Close();
                    return 0;
                }
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally {
                conn.Close();
            }
            return 0;
        }
    }
}
