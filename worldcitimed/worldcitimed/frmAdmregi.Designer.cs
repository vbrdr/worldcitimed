namespace worldcitimed
{
    partial class frmAdmregi
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
            this.btnAdmback = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnAdmenter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAdmlast = new System.Windows.Forms.TextBox();
            this.txbAdmmiddle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAdmfirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttADM = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmback
            // 
            this.btnAdmback.Location = new System.Drawing.Point(11, 13);
            this.btnAdmback.Name = "btnAdmback";
            this.btnAdmback.Size = new System.Drawing.Size(59, 30);
            this.btnAdmback.TabIndex = 35;
            this.btnAdmback.Text = "Back";
            this.btnAdmback.UseVisualStyleBackColor = true;
            this.btnAdmback.Click += new System.EventHandler(this.btnAdmback_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(30, 416);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(36, 16);
            this.lblDateTime.TabIndex = 34;
            this.lblDateTime.Text = "time";
            // 
            // btnAdmenter
            // 
            this.btnAdmenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmenter.Location = new System.Drawing.Point(272, 284);
            this.btnAdmenter.Name = "btnAdmenter";
            this.btnAdmenter.Size = new System.Drawing.Size(153, 35);
            this.btnAdmenter.TabIndex = 33;
            this.btnAdmenter.Text = "Confirm";
            this.btnAdmenter.UseVisualStyleBackColor = true;
            this.btnAdmenter.Click += new System.EventHandler(this.btnAdmenter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Middle Initial";
            // 
            // txbAdmlast
            // 
            this.txbAdmlast.Location = new System.Drawing.Point(421, 216);
            this.txbAdmlast.Name = "txbAdmlast";
            this.txbAdmlast.Size = new System.Drawing.Size(132, 22);
            this.txbAdmlast.TabIndex = 30;
            // 
            // txbAdmmiddle
            // 
            this.txbAdmmiddle.Location = new System.Drawing.Point(283, 216);
            this.txbAdmmiddle.Name = "txbAdmmiddle";
            this.txbAdmmiddle.Size = new System.Drawing.Size(132, 22);
            this.txbAdmmiddle.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name";
            // 
            // txbAdmfirst
            // 
            this.txbAdmfirst.Location = new System.Drawing.Point(145, 216);
            this.txbAdmfirst.Name = "txbAdmfirst";
            this.txbAdmfirst.Size = new System.Drawing.Size(132, 22);
            this.txbAdmfirst.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Please enter your full name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(217, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAdmregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 452);
            this.Controls.Add(this.btnAdmback);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnAdmenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAdmlast);
            this.Controls.Add(this.txbAdmmiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAdmfirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAdmregi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admission Queuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmback;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnAdmenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAdmlast;
        private System.Windows.Forms.TextBox txbAdmmiddle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAdmfirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ttADM;
    }
}