namespace GUI
{
    partial class FormTable
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp.Location = new System.Drawing.Point(13, 13);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1058, 508);
            this.flp.TabIndex = 0;
            this.flp.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1077, 215);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(160, 306);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đóng ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 95);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thống Kê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 95);
            this.button3.TabIndex = 0;
            this.button3.Text = "Xem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.Location = new System.Drawing.Point(1081, 13);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(155, 95);
            this.btAdmin.TabIndex = 2;
            this.btAdmin.Text = "Admin";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 533);
            this.Controls.Add(this.btAdmin);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flp);
            this.Name = "FormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTable";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button btAdmin;
    }
}