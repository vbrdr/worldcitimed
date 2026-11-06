namespace worldcitimed
{
    partial class frmHMOregi
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
            this.btnHMOback = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnHMOenter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbHMOlast = new System.Windows.Forms.TextBox();
            this.txbHMOmiddle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHMOfirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttHMO = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHMOback
            // 
            this.btnHMOback.Location = new System.Drawing.Point(13, 15);
            this.btnHMOback.Name = "btnHMOback";
            this.btnHMOback.Size = new System.Drawing.Size(59, 30);
            this.btnHMOback.TabIndex = 24;
            this.btnHMOback.Text = "Back";
            this.btnHMOback.UseVisualStyleBackColor = true;
            this.btnHMOback.Click += new System.EventHandler(this.btnHMOback_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(32, 418);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(36, 16);
            this.lblDateTime.TabIndex = 23;
            this.lblDateTime.Text = "time";
            // 
            // btnHMOenter
            // 
            this.btnHMOenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHMOenter.Location = new System.Drawing.Point(274, 286);
            this.btnHMOenter.Name = "btnHMOenter";
            this.btnHMOenter.Size = new System.Drawing.Size(153, 35);
            this.btnHMOenter.TabIndex = 22;
            this.btnHMOenter.Text = "Confirm";
            this.btnHMOenter.UseVisualStyleBackColor = true;
            this.btnHMOenter.Click += new System.EventHandler(this.btnHMOenter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Middle Initial";
            // 
            // txbHMOlast
            // 
            this.txbHMOlast.Location = new System.Drawing.Point(423, 218);
            this.txbHMOlast.Name = "txbHMOlast";
            this.txbHMOlast.Size = new System.Drawing.Size(132, 22);
            this.txbHMOlast.TabIndex = 19;
            // 
            // txbHMOmiddle
            // 
            this.txbHMOmiddle.Location = new System.Drawing.Point(285, 218);
            this.txbHMOmiddle.Name = "txbHMOmiddle";
            this.txbHMOmiddle.Size = new System.Drawing.Size(132, 22);
            this.txbHMOmiddle.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // txbHMOfirst
            // 
            this.txbHMOfirst.Location = new System.Drawing.Point(147, 218);
            this.txbHMOfirst.Name = "txbHMOfirst";
            this.txbHMOfirst.Size = new System.Drawing.Size(132, 22);
            this.txbHMOfirst.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Please enter your full name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(219, 44);
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
            // frmHMOregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 452);
            this.Controls.Add(this.btnHMOback);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnHMOenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbHMOlast);
            this.Controls.Add(this.txbHMOmiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbHMOfirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHMOregi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMO Approval Queuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHMOback;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnHMOenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbHMOlast;
        private System.Windows.Forms.TextBox txbHMOmiddle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHMOfirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ttHMO;
    }
}