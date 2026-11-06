namespace worldcitimed
{
    partial class frmPHregi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbPHfirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPHmiddle = new System.Windows.Forms.TextBox();
            this.txbPHlast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPHenter = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPHback = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttPH = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter your full name";
            // 
            // txbPHfirst
            // 
            this.txbPHfirst.Location = new System.Drawing.Point(146, 215);
            this.txbPHfirst.Name = "txbPHfirst";
            this.txbPHfirst.Size = new System.Drawing.Size(132, 22);
            this.txbPHfirst.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // txbPHmiddle
            // 
            this.txbPHmiddle.Location = new System.Drawing.Point(284, 215);
            this.txbPHmiddle.Name = "txbPHmiddle";
            this.txbPHmiddle.Size = new System.Drawing.Size(132, 22);
            this.txbPHmiddle.TabIndex = 6;
            // 
            // txbPHlast
            // 
            this.txbPHlast.Location = new System.Drawing.Point(422, 215);
            this.txbPHlast.Name = "txbPHlast";
            this.txbPHlast.Size = new System.Drawing.Size(132, 22);
            this.txbPHlast.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Middle Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // btnPHenter
            // 
            this.btnPHenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPHenter.Location = new System.Drawing.Point(273, 283);
            this.btnPHenter.Name = "btnPHenter";
            this.btnPHenter.Size = new System.Drawing.Size(153, 35);
            this.btnPHenter.TabIndex = 10;
            this.btnPHenter.Text = "Confirm";
            this.btnPHenter.UseVisualStyleBackColor = true;
            this.btnPHenter.Click += new System.EventHandler(this.btnPHenter_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(31, 415);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(36, 16);
            this.lblDateTime.TabIndex = 12;
            this.lblDateTime.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPHback
            // 
            this.btnPHback.Location = new System.Drawing.Point(12, 12);
            this.btnPHback.Name = "btnPHback";
            this.btnPHback.Size = new System.Drawing.Size(59, 30);
            this.btnPHback.TabIndex = 13;
            this.btnPHback.Text = "Back";
            this.btnPHback.UseVisualStyleBackColor = true;
            this.btnPHback.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(218, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmPHregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 452);
            this.Controls.Add(this.btnPHback);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnPHenter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPHlast);
            this.Controls.Add(this.txbPHmiddle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPHfirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPHregi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPHfirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPHmiddle;
        private System.Windows.Forms.TextBox txbPHlast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPHenter;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPHback;
        private System.Windows.Forms.ToolTip ttPH;
    }
}