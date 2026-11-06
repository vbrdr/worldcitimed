namespace worldcitimed
{
    partial class frmCashregi
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
            this.btnCashback = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnCashenter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCashlast = new System.Windows.Forms.TextBox();
            this.txbCashmiddle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCashfirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttCASH = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCashback
            // 
            this.btnCashback.Location = new System.Drawing.Point(14, 12);
            this.btnCashback.Name = "btnCashback";
            this.btnCashback.Size = new System.Drawing.Size(59, 30);
            this.btnCashback.TabIndex = 35;
            this.btnCashback.Text = "Back";
            this.btnCashback.UseVisualStyleBackColor = true;
            this.btnCashback.Click += new System.EventHandler(this.btnCashback_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(33, 415);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(36, 16);
            this.lblDateTime.TabIndex = 34;
            this.lblDateTime.Text = "time";
            // 
            // btnCashenter
            // 
            this.btnCashenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashenter.Location = new System.Drawing.Point(275, 283);
            this.btnCashenter.Name = "btnCashenter";
            this.btnCashenter.Size = new System.Drawing.Size(153, 35);
            this.btnCashenter.TabIndex = 33;
            this.btnCashenter.Text = "Confirm";
            this.btnCashenter.UseVisualStyleBackColor = true;
            this.btnCashenter.Click += new System.EventHandler(this.btnCashenter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Middle Initial";
            // 
            // txbCashlast
            // 
            this.txbCashlast.Location = new System.Drawing.Point(424, 215);
            this.txbCashlast.Name = "txbCashlast";
            this.txbCashlast.Size = new System.Drawing.Size(132, 22);
            this.txbCashlast.TabIndex = 30;
            // 
            // txbCashmiddle
            // 
            this.txbCashmiddle.Location = new System.Drawing.Point(286, 215);
            this.txbCashmiddle.Name = "txbCashmiddle";
            this.txbCashmiddle.Size = new System.Drawing.Size(132, 22);
            this.txbCashmiddle.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Name";
            // 
            // txbCashfirst
            // 
            this.txbCashfirst.Location = new System.Drawing.Point(148, 215);
            this.txbCashfirst.Name = "txbCashfirst";
            this.txbCashfirst.Size = new System.Drawing.Size(132, 22);
            this.txbCashfirst.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Please enter your full name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(220, 41);
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
            // frmCashregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 452);
            this.Controls.Add(this.btnCashback);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnCashenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCashlast);
            this.Controls.Add(this.txbCashmiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbCashfirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashregi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Queuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCashback;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnCashenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCashlast;
        private System.Windows.Forms.TextBox txbCashmiddle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCashfirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip ttCASH;
    }
}