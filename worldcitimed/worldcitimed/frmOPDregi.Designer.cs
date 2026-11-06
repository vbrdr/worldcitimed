namespace worldcitimed
{
    partial class frmOPDregi
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
            this.btnOPDback = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnOPDenter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbOPDlast = new System.Windows.Forms.TextBox();
            this.txbOPDmiddle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbOPDfirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttOPD = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOPDback
            // 
            this.btnOPDback.Location = new System.Drawing.Point(12, 13);
            this.btnOPDback.Name = "btnOPDback";
            this.btnOPDback.Size = new System.Drawing.Size(59, 30);
            this.btnOPDback.TabIndex = 24;
            this.btnOPDback.Text = "Back";
            this.btnOPDback.UseVisualStyleBackColor = true;
            this.btnOPDback.Click += new System.EventHandler(this.btnOPDback_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(31, 416);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(36, 16);
            this.lblDateTime.TabIndex = 23;
            this.lblDateTime.Text = "time";
            // 
            // btnOPDenter
            // 
            this.btnOPDenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPDenter.Location = new System.Drawing.Point(273, 284);
            this.btnOPDenter.Name = "btnOPDenter";
            this.btnOPDenter.Size = new System.Drawing.Size(153, 35);
            this.btnOPDenter.TabIndex = 22;
            this.btnOPDenter.Text = "Confirm";
            this.btnOPDenter.UseVisualStyleBackColor = true;
            this.btnOPDenter.Click += new System.EventHandler(this.btnOPDenter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Middle Initial";
            // 
            // txbOPDlast
            // 
            this.txbOPDlast.Location = new System.Drawing.Point(422, 216);
            this.txbOPDlast.Name = "txbOPDlast";
            this.txbOPDlast.Size = new System.Drawing.Size(132, 22);
            this.txbOPDlast.TabIndex = 19;
            // 
            // txbOPDmiddle
            // 
            this.txbOPDmiddle.Location = new System.Drawing.Point(284, 216);
            this.txbOPDmiddle.Name = "txbOPDmiddle";
            this.txbOPDmiddle.Size = new System.Drawing.Size(132, 22);
            this.txbOPDmiddle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // txbOPDfirst
            // 
            this.txbOPDfirst.Location = new System.Drawing.Point(146, 216);
            this.txbOPDfirst.Name = "txbOPDfirst";
            this.txbOPDfirst.Size = new System.Drawing.Size(132, 22);
            this.txbOPDfirst.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please enter your full name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(218, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmOPDregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 452);
            this.Controls.Add(this.btnOPDback);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnOPDenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbOPDlast);
            this.Controls.Add(this.txbOPDmiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbOPDfirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOPDregi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPD Registration Queuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOPDback;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnOPDenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbOPDlast;
        private System.Windows.Forms.TextBox txbOPDmiddle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbOPDfirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ttOPD;
    }
}