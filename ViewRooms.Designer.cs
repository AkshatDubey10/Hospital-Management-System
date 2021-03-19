namespace Hospital_Management_System {
    partial class ViewRooms {
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
            this.roomno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Rooms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomno,
            this.roomtype,
            this.unavailable});
            this.dataGridView1.Location = new System.Drawing.Point(298, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // roomno
            // 
            this.roomno.HeaderText = "Room Number";
            this.roomno.MinimumWidth = 6;
            this.roomno.Name = "roomno";
            this.roomno.ReadOnly = true;
            this.roomno.Width = 125;
            // 
            // roomtype
            // 
            this.roomtype.HeaderText = "Room Type";
            this.roomtype.MinimumWidth = 6;
            this.roomtype.Name = "roomtype";
            this.roomtype.ReadOnly = true;
            this.roomtype.Width = 125;
            // 
            // unavailable
            // 
            this.unavailable.HeaderText = "Available";
            this.unavailable.MinimumWidth = 6;
            this.unavailable.Name = "unavailable";
            this.unavailable.ReadOnly = true;
            this.unavailable.Width = 125;
            // 
            // ViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1045, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewRooms";
            this.Text = "ViewRooms";
            this.Load += new System.EventHandler(this.ViewRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomno;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn unavailable;
    }
}