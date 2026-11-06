namespace worldcitimed
{
    partial class frmBillregi
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
            this.components = new System.ComponentModel.Container();
            this.btnBillback = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnBillenter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbBilllast = new System.Windows.Forms.TextBox();
            this.txbBillmiddle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBillfirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttBILL = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBillback
            // 
            this.btnBillback.Location = new System.Drawing.Point(13, 14);
            this.btnBillback.Name = "btnBillback";
            this.btnBillback.Size = new System.Drawing.Size(59, 30);
            this.btnBillback.TabIndex = 24;
            this.btnBillback.Text = "Back";
            this.btnBillback.UseVisualStyleBackColor = true;
            this.btnBillback.Click += new System.EventHandler(this.btnBillback_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(32, 417);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(36, 16);
            this.lblDateTime.TabIndex = 23;
            this.lblDateTime.Text = "time";
            // 
            // btnBillenter
            // 
            this.btnBillenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillenter.Location = new System.Drawing.Point(274, 285);
            this.btnBillenter.Name = "btnBillenter";
            this.btnBillenter.Size = new System.Drawing.Size(153, 35);
            this.btnBillenter.TabIndex = 22;
            this.btnBillenter.Text = "Confirm";
            this.btnBillenter.UseVisualStyleBackColor = true;
            this.btnBillenter.Click += new System.EventHandler(this.btnBillenter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Middle Initial";
            // 
            // txbBilllast
            // 
            this.txbBilllast.Location = new System.Drawing.Point(423, 217);
            this.txbBilllast.Name = "txbBilllast";
            this.txbBilllast.Size = new System.Drawing.Size(132, 22);
            this.txbBilllast.TabIndex = 19;
            // 
            // txbBillmiddle
            // 
            this.txbBillmiddle.Location = new System.Drawing.Point(285, 217);
            this.txbBillmiddle.Name = "txbBillmiddle";
            this.txbBillmiddle.Size = new System.Drawing.Size(132, 22);
            this.txbBillmiddle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // txbBillfirst
            // 
            this.txbBillfirst.Location = new System.Drawing.Point(147, 217);
            this.txbBillfirst.Name = "txbBillfirst";
            this.txbBillfirst.Size = new System.Drawing.Size(132, 22);
            this.txbBillfirst.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please enter your full name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(219, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmBillregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 452);
            this.Controls.Add(this.btnBillback);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnBillenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbBilllast);
            this.Controls.Add(this.txbBillmiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbBillfirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBillregi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Queuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBillback;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnBillenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbBilllast;
        private System.Windows.Forms.TextBox txbBillmiddle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBillfirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ttBILL;
    }
}