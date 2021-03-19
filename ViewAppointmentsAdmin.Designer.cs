namespace Hospital_Management_System {
    partial class ViewAppointmentsAdmin {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepnurse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "View all Appointments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentId,
            this.patientId,
            this.prepnurse,
            this.physician,
            this.startdate,
            this.enddate});
            this.dataGridView1.Location = new System.Drawing.Point(113, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 264);
            this.dataGridView1.TabIndex = 1;
            // 
            // appointmentId
            // 
            this.appointmentId.HeaderText = "Appointment ID";
            this.appointmentId.MinimumWidth = 6;
            this.appointmentId.Name = "appointmentId";
            this.appointmentId.ReadOnly = true;
            this.appointmentId.Width = 125;
            // 
            // patientId
            // 
            this.patientId.HeaderText = "Patient ID";
            this.patientId.MinimumWidth = 6;
            this.patientId.Name = "patientId";
            this.patientId.ReadOnly = true;
            this.patientId.Width = 125;
            // 
            // prepnurse
            // 
            this.prepnurse.HeaderText = "Nurse ID";
            this.prepnurse.MinimumWidth = 6;
            this.prepnurse.Name = "prepnurse";
            this.prepnurse.ReadOnly = true;
            this.prepnurse.Width = 125;
            // 
            // physician
            // 
            this.physician.HeaderText = "Physician ID";
            this.physician.MinimumWidth = 6;
            this.physician.Name = "physician";
            this.physician.ReadOnly = true;
            this.physician.Width = 125;
            // 
            // startdate
            // 
            this.startdate.HeaderText = "Start Date-Time";
            this.startdate.MinimumWidth = 6;
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            this.startdate.Width = 125;
            // 
            // enddate
            // 
            this.enddate.HeaderText = "End Date-Time";
            this.enddate.MinimumWidth = 6;
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            this.enddate.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Appointment ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Show all Records";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(482, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Field cannot be left blank";
            // 
            // ViewAppointmentsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1045, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAppointmentsAdmin";
            this.Text = "ViewAppointmentsAdmin";
            this.Load += new System.EventHandler(this.ViewAppointmentsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepnurse;
        private System.Windows.Forms.DataGridViewTextBoxColumn physician;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}