namespace GUI
{
    partial class FormBill
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flpBill = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFood = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.tbGiamGia = new System.Windows.Forms.TextBox();
            this.tbGiaTri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlCongTru = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCongTru.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 530);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 92);
            this.button2.TabIndex = 0;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 92);
            this.button3.TabIndex = 0;
            this.button3.Text = "Thanh Toán";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 92);
            this.button4.TabIndex = 0;
            this.button4.Text = "Gộp Bàn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flpBill
            // 
            this.flpBill.AutoScroll = true;
            this.flpBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBill.Location = new System.Drawing.Point(184, 102);
            this.flpBill.Name = "flpBill";
            this.flpBill.Size = new System.Drawing.Size(283, 339);
            this.flpBill.TabIndex = 0;
            this.flpBill.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // flpCategory
            // 
            this.flpCategory.AutoScroll = true;
            this.flpCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCategory.Location = new System.Drawing.Point(473, 13);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(226, 428);
            this.flpCategory.TabIndex = 0;
            this.flpCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.flpCategory_Paint);
            // 
            // flpFood
            // 
            this.flpFood.AllowDrop = true;
            this.flpFood.AutoScroll = true;
            this.flpFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFood.Location = new System.Drawing.Point(705, 13);
            this.flpFood.Name = "flpFood";
            this.flpFood.Size = new System.Drawing.Size(422, 530);
            this.flpFood.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.label3);
            this.pnlTitle.Controls.Add(this.label2);
            this.pnlTitle.Controls.Add(this.lbBill);
            this.pnlTitle.Controls.Add(this.lbTable);
            this.pnlTitle.Controls.Add(this.lbTime);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Location = new System.Drawing.Point(184, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(283, 87);
            this.pnlTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = " Bàn ";
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.Location = new System.Drawing.Point(187, 50);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(11, 16);
            this.lbBill.TabIndex = 0;
            this.lbBill.Text = " ";
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.Location = new System.Drawing.Point(56, 50);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(11, 16);
            this.lbTable.TabIndex = 0;
            this.lbTable.Text = " ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(56, 4);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(11, 16);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbTongTien);
            this.panel2.Controls.Add(this.tbGiamGia);
            this.panel2.Controls.Add(this.tbGiaTri);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(184, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 96);
            this.panel2.TabIndex = 1;
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(91, 65);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(177, 22);
            this.tbTongTien.TabIndex = 1;
            // 
            // tbGiamGia
            // 
            this.tbGiamGia.Location = new System.Drawing.Point(91, 35);
            this.tbGiamGia.Name = "tbGiamGia";
            this.tbGiamGia.Size = new System.Drawing.Size(177, 22);
            this.tbGiamGia.TabIndex = 1;
            this.tbGiamGia.TextChanged += new System.EventHandler(this.tbGiamGia_TextChanged);
            this.tbGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiamGia_KeyPress);
            // 
            // tbGiaTri
            // 
            this.tbGiaTri.Location = new System.Drawing.Point(91, 6);
            this.tbGiaTri.Name = "tbGiaTri";
            this.tbGiaTri.Size = new System.Drawing.Size(177, 22);
            this.tbGiaTri.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng Tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giảm Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Trị";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(474, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 95);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cài Đặt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlCongTru
            // 
            this.pnlCongTru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCongTru.Controls.Add(this.button7);
            this.pnlCongTru.Controls.Add(this.button6);
            this.pnlCongTru.Controls.Add(this.button5);
            this.pnlCongTru.Location = new System.Drawing.Point(184, 13);
            this.pnlCongTru.Name = "pnlCongTru";
            this.pnlCongTru.Size = new System.Drawing.Size(283, 83);
            this.pnlCongTru.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(186, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 75);
            this.button7.TabIndex = 0;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(95, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 75);
            this.button6.TabIndex = 0;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 74);
            this.button5.TabIndex = 0;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 555);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlCongTru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpFood);
            this.Controls.Add(this.flpCategory);
            this.Controls.Add(this.flpBill);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.Click += new System.EventHandler(this.FormBill_Click);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCongTru.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flpBill;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private System.Windows.Forms.FlowLayoutPanel flpFood;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.TextBox tbGiamGia;
        private System.Windows.Forms.TextBox tbGiaTri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel pnlCongTru;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}