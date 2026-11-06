namespace worldcitimed
{
    partial class frmPage1
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
            this.cbPrio = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ttPage1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHMO = new System.Windows.Forms.Button();
            this.btnAdmi = new System.Windows.Forms.Button();
            this.btnOPD = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnPhilhealth = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPrio
            // 
            this.cbPrio.AutoSize = true;
            this.cbPrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrio.Location = new System.Drawing.Point(514, 104);
            this.cbPrio.Name = "cbPrio";
            this.cbPrio.Size = new System.Drawing.Size(154, 29);
            this.cbPrio.TabIndex = 2;
            this.cbPrio.Text = "Senior/PWD";
            this.cbPrio.UseVisualStyleBackColor = true;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(31, 114);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(36, 16);
            this.lblDateTime.TabIndex = 11;
            this.lblDateTime.Text = "time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "PRESS HERE FOR THE QUEUEING NUMBER";
            // 
            // btnHMO
            // 
            this.btnHMO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHMO.Image = global::worldcitimed.Properties.Resources.appro;
            this.btnHMO.Location = new System.Drawing.Point(354, 355);
            this.btnHMO.Name = "btnHMO";
            this.btnHMO.Size = new System.Drawing.Size(314, 78);
            this.btnHMO.TabIndex = 8;
            this.btnHMO.Text = "HMO Approval";
            this.btnHMO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHMO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHMO.UseVisualStyleBackColor = true;
            this.btnHMO.Click += new System.EventHandler(this.btnHMO_Click);
            // 
            // btnAdmi
            // 
            this.btnAdmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmi.Image = global::worldcitimed.Properties.Resources.admit;
            this.btnAdmi.Location = new System.Drawing.Point(354, 271);
            this.btnAdmi.Name = "btnAdmi";
            this.btnAdmi.Size = new System.Drawing.Size(314, 78);
            this.btnAdmi.TabIndex = 7;
            this.btnAdmi.Text = "   Admission";
            this.btnAdmi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmi.UseVisualStyleBackColor = true;
            this.btnAdmi.Click += new System.EventHandler(this.btnAdmi_Click);
            // 
            // btnOPD
            // 
            this.btnOPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOPD.Image = global::worldcitimed.Properties.Resources.regis;
            this.btnOPD.Location = new System.Drawing.Point(354, 187);
            this.btnOPD.Name = "btnOPD";
            this.btnOPD.Size = new System.Drawing.Size(314, 78);
            this.btnOPD.TabIndex = 6;
            this.btnOPD.Text = "OPD Registration";
            this.btnOPD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOPD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOPD.UseVisualStyleBackColor = true;
            this.btnOPD.Click += new System.EventHandler(this.btnOPD_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.Image = global::worldcitimed.Properties.Resources.cashier;
            this.btnCashier.Location = new System.Drawing.Point(34, 355);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(314, 78);
            this.btnCashier.TabIndex = 5;
            this.btnCashier.Text = "  Cashier";
            this.btnCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.Image = global::worldcitimed.Properties.Resources.billl;
            this.btnBilling.Location = new System.Drawing.Point(34, 271);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(314, 78);
            this.btnBilling.TabIndex = 4;
            this.btnBilling.Text = "  Billing";
            this.btnBilling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBilling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnPhilhealth
            // 
            this.btnPhilhealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhilhealth.Image = global::worldcitimed.Properties.Resources.ph__2_;
            this.btnPhilhealth.Location = new System.Drawing.Point(34, 187);
            this.btnPhilhealth.Name = "btnPhilhealth";
            this.btnPhilhealth.Size = new System.Drawing.Size(314, 78);
            this.btnPhilhealth.TabIndex = 3;
            this.btnPhilhealth.Text = "PhilHealth";
            this.btnPhilhealth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPhilhealth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhilhealth.UseVisualStyleBackColor = true;
            this.btnPhilhealth.Click += new System.EventHandler(this.btnPhilhealth_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::worldcitimed.Properties.Resources.Screenshot_2025_04_26_213459;
            this.pictureBox1.Location = new System.Drawing.Point(201, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "940 Aurora Boulevard, Quezon City, Metro Manila";
            // 
            // frmPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnHMO);
            this.Controls.Add(this.btnAdmi);
            this.Controls.Add(this.btnOPD);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnPhilhealth);
            this.Controls.Add(this.cbPrio);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmPage1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queuing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbPrio;
        private System.Windows.Forms.Button btnPhilhealth;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Button btnHMO;
        private System.Windows.Forms.Button btnAdmi;
        private System.Windows.Forms.Button btnOPD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttPage1;
        private System.Windows.Forms.Label label2;
    }
}

