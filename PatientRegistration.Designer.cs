namespace Hospital_Management_System {
    partial class PatientRegistration {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(403, 232);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(292, 68);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mobile Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "+91";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(461, 339);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 28);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 409);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 28);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(401, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Patient Name cannot be left empty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(399, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address cannot be left empty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(457, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "*Required Field";
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1027, 591);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientRegistration";
            this.Text = "PatientRegistrationcs";
            this.Load += new System.EventHandler(this.PatientRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}