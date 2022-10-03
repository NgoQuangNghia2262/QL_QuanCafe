namespace GUI
{
    partial class FormQuanLy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.tbTrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.ColTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColidBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTrang
            // 
            this.tbTrang.Enabled = false;
            this.tbTrang.Location = new System.Drawing.Point(631, 521);
            this.tbTrang.Name = "tbTrang";
            this.tbTrang.ReadOnly = true;
            this.tbTrang.Size = new System.Drawing.Size(19, 22);
            this.tbTrang.TabIndex = 1;
            this.tbTrang.Text = "1";
            this.tbTrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = ">";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTable,
            this.ColTongBill,
            this.ColGiamGia,
            this.ColidBill,
            this.ColStatus,
            this.ColTimeIn,
            this.ColTimeOut});
            this.dgvThongKe.Location = new System.Drawing.Point(12, 180);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1072, 335);
            this.dgvThongKe.TabIndex = 2;
            // 
            // ColTable
            // 
            this.ColTable.DataPropertyName = "IdTable";
            this.ColTable.FillWeight = 56.14971F;
            this.ColTable.HeaderText = "Table";
            this.ColTable.MinimumWidth = 6;
            this.ColTable.Name = "ColTable";
            this.ColTable.ReadOnly = true;
            // 
            // ColTongBill
            // 
            this.ColTongBill.DataPropertyName = "GiaTri";
            this.ColTongBill.FillWeight = 159.7159F;
            this.ColTongBill.HeaderText = "Tong_Bill";
            this.ColTongBill.MinimumWidth = 6;
            this.ColTongBill.Name = "ColTongBill";
            this.ColTongBill.ReadOnly = true;
            // 
            // ColGiamGia
            // 
            this.ColGiamGia.DataPropertyName = "GiamGia";
            this.ColGiamGia.FillWeight = 74.65146F;
            this.ColGiamGia.HeaderText = "GiamGia";
            this.ColGiamGia.MinimumWidth = 6;
            this.ColGiamGia.Name = "ColGiamGia";
            this.ColGiamGia.ReadOnly = true;
            // 
            // ColidBill
            // 
            this.ColidBill.DataPropertyName = "Id";
            this.ColidBill.FillWeight = 48.1763F;
            this.ColidBill.HeaderText = "Bill";
            this.ColidBill.MinimumWidth = 6;
            this.ColidBill.Name = "ColidBill";
            this.ColidBill.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.FillWeight = 41.87462F;
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 6;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // ColTimeIn
            // 
            this.ColTimeIn.DataPropertyName = "TimeIn";
            this.ColTimeIn.FillWeight = 159.7159F;
            this.ColTimeIn.HeaderText = "Time_In";
            this.ColTimeIn.MinimumWidth = 6;
            this.ColTimeIn.Name = "ColTimeIn";
            this.ColTimeIn.ReadOnly = true;
            // 
            // ColTimeOut
            // 
            this.ColTimeOut.DataPropertyName = "TimeOut";
            this.ColTimeOut.FillWeight = 159.7159F;
            this.ColTimeOut.HeaderText = "Time_Out";
            this.ColTimeOut.MinimumWidth = 6;
            this.ColTimeOut.Name = "ColTimeOut";
            this.ColTimeOut.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 103);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1111, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(933, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(671, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2022, 9, 17, 23, 59, 59, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(451, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 17, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(618, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(846, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm Kiếm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thống Kê";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Từ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "<";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1090, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 336);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 89);
            this.button3.TabIndex = 0;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 89);
            this.button2.TabIndex = 0;
            this.button2.Text = "Mặt Hàng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.tbTrang);
            this.Controls.Add(this.label2);
            this.Name = "FormQuanLy";
            this.Text = "FormQuanLy";
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColidBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTimeOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}