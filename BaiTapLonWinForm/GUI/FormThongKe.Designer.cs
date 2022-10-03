namespace GUI
{
    partial class FormThongKe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.tbGiaTri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flpThongKe = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.Label();
            this.lbTimeOut = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbTongTien);
            this.panel1.Controls.Add(this.tbGiamGia);
            this.panel1.Controls.Add(this.tbGiaTri);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 99);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(556, 64);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(177, 22);
            this.tbTongTien.TabIndex = 5;
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Location = new System.Drawing.Point(556, 36);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.Size = new System.Drawing.Size(177, 22);
            this.tbGiamGia.TabIndex = 6;
            // 
            // tbGiaTri
            // 
            this.tbGiaTri.Location = new System.Drawing.Point(556, 7);
            this.tbGiaTri.Name = "tbGiaTri";
            this.tbGiaTri.Size = new System.Drawing.Size(177, 22);
            this.tbGiaTri.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng Giảm Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng Giá Trị";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(262, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 81);
            this.button3.TabIndex = 0;
            this.button3.Text = "Chi Tiết";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(133, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 81);
            this.button2.TabIndex = 0;
            this.button2.Text = "Mặt Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hóa Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flpThongKe
            // 
            this.flpThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpThongKe.Location = new System.Drawing.Point(13, 108);
            this.flpThongKe.Name = "flpThongKe";
            this.flpThongKe.Size = new System.Drawing.Size(793, 373);
            this.flpThongKe.TabIndex = 2;
            this.flpThongKe.Paint += new System.Windows.Forms.PaintEventHandler(this.flpThongKe_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(13, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 52);
            this.panel2.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 46);
            this.button6.TabIndex = 2;
            this.button6.Text = "In Lại";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1071, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 46);
            this.button4.TabIndex = 1;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 46);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(813, 108);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(397, 373);
            this.dgvBill.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbBill);
            this.panel3.Controls.Add(this.lbTable);
            this.panel3.Controls.Add(this.lbTimeOut);
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(813, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 99);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = " Bàn ";
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.Location = new System.Drawing.Point(346, 14);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(11, 16);
            this.lbBill.TabIndex = 3;
            this.lbBill.Text = " ";
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.Location = new System.Drawing.Point(346, 54);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(11, 16);
            this.lbTable.TabIndex = 4;
            this.lbTable.Text = " ";
            // 
            // lbTimeOut
            // 
            this.lbTimeOut.AutoSize = true;
            this.lbTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeOut.Location = new System.Drawing.Point(78, 54);
            this.lbTimeOut.Name = "lbTimeOut";
            this.lbTimeOut.Size = new System.Drawing.Size(11, 16);
            this.lbTimeOut.TabIndex = 5;
            this.lbTimeOut.Text = " ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(78, 14);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(11, 16);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = " ";
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time In";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 551);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpThongKe);
            this.Controls.Add(this.panel1);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongKe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpThongKe;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.TextBox tbGiamGia;
        private System.Windows.Forms.TextBox tbGiaTri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTimeOut;
        private System.Windows.Forms.Label label4;
    }
}