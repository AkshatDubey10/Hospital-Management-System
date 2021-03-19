namespace Hospital_Management_System {
    partial class ViewPatients {
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
            this.ssn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Patients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssn,
            this.patientName,
            this.Address,
            this.phone});
            this.dataGridView1.Location = new System.Drawing.Point(264, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 248);
            this.dataGridView1.TabIndex = 1;
            // 
            // ssn
            // 
            this.ssn.HeaderText = "Serial Number";
            this.ssn.MinimumWidth = 6;
            this.ssn.Name = "ssn";
            this.ssn.ReadOnly = true;
            this.ssn.Width = 125;
            // 
            // patientName
            // 
            this.patientName.HeaderText = "Name";
            this.patientName.MinimumWidth = 6;
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            this.patientName.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // ViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1045, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewPatients";
            this.Text = "ViewPatients";
            this.Load += new System.EventHandler(this.ViewPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}