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
    public partial class Form1 : Form {
       public SqlConnection conn;
       public SqlDataReader reader;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            conn = new SqlConnection("Server=.\\SQLEXPRESS;database=HospitalDB;Integrated Security=true ");
            userType.SelectedIndex = 0;
            userType.DropDownStyle = ComboBoxStyle.DropDownList;
            label4.Visible= false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            string user, password, type;
            if (userType.SelectedIndex == 0) {
                label6.Visible = true;
            }
            if (username.TextLength == 0)
                label4.Visible = true;
            if (pass.TextLength == 0)
                label5.Visible = true;
            if (label4.Visible == true || label5.Visible == true || label6.Visible == true)
                return;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select password,type from Users where username='" + username.Text + "'", conn);
            reader = cmd.ExecuteReader();
            try {
                user = username.Text;
                password = pass.Text;
                type = (userType.Items[userType.SelectedIndex]).ToString();
                if (!reader.Read()) {
                    MessageBox.Show("NO SUCH USER PRESENT!!", "INVALID USER", MessageBoxButtons.OK);
                }
                else {
                    Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1));
                    if (reader.GetString(0) == password) {
                        if (reader.GetString(1) == type) {
                            MessageBox.Show("Welcome " + user + "!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (type == "Admin") {
                                username.Text = "";
                                pass.Text = "";
                                userType.SelectedIndex = 0;
                                Hide();
                                new AdminPanel(this).Show();
                            }
                            else if (type == "Staff") {
                                username.Text = "";
                                pass.Text = "";
                                userType.SelectedIndex = 0;
                                Hide();
                                new Form2(user).Show();
                            }
                             
                        }
                        else {
                            MessageBox.Show("Your not authorised as " + type + ". Please choose the correct type!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show("Wrong password. Please enter the correct password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception E) {
                Console.WriteLine(E.Message);
            }
            finally {
                reader.Close();
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label4.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            label5.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            label6.Visible = false;
        }
    }
    class ConnectionDB {

        SqlConnection conn;
        public static string strProvider;



        public bool Open() {
            try {
                strProvider = "Server=.\\SQLEXPRESS;database=HospitalDB;Integrated Security=true ";
                conn = new SqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er) {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }

        public void Close() {
            conn.Close();
            conn.Dispose();
        }

        public DataSet ExecuteDataSet(string sql) {
            try {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public SqlDataReader ExecuteReader(string sql) {
            try {
                SqlDataReader reader;
                SqlCommand cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex) {
               Console.WriteLine(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql) {
            try {
                SqlCommand exec = new SqlCommand(sql, conn);
                exec.ExecuteNonQuery();
                exec.Dispose();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return -1;
            }
            return 0;
        }
    }
}
