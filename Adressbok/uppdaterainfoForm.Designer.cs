namespace Adressbok
{
    partial class uppdaterainfoForm
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
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUppdatera = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.txtPostort = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(28, 21);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(196, 20);
            this.txtNamn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gatuadress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Postnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Postort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mail";
            // 
            // btnUppdatera
            // 
            this.btnUppdatera.Location = new System.Drawing.Point(89, 246);
            this.btnUppdatera.Name = "btnUppdatera";
            this.btnUppdatera.Size = new System.Drawing.Size(75, 23);
            this.btnUppdatera.TabIndex = 12;
            this.btnUppdatera.Text = "Uppdatera";
            this.btnUppdatera.UseVisualStyleBackColor = true;
            this.btnUppdatera.Click += new System.EventHandler(this.btnUppdatera_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(28, 63);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(196, 20);
            this.txtAdress.TabIndex = 13;
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Location = new System.Drawing.Point(28, 104);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(196, 20);
            this.txtPostnummer.TabIndex = 14;
            // 
            // txtPostort
            // 
            this.txtPostort.Location = new System.Drawing.Point(28, 144);
            this.txtPostort.Name = "txtPostort";
            this.txtPostort.Size = new System.Drawing.Size(196, 20);
            this.txtPostort.TabIndex = 15;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(28, 183);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(196, 20);
            this.txtTelefon.TabIndex = 16;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(28, 222);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(196, 20);
            this.txtMail.TabIndex = 17;
            // 
            // uppdaterainfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 287);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPostort);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.btnUppdatera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamn);
            this.Name = "uppdaterainfoForm";
            this.Text = "uppdaterainfoForm";
            this.Load += new System.EventHandler(this.uppdaterainfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtAdress;
        public System.Windows.Forms.TextBox txtNamn;
        public System.Windows.Forms.TextBox txtPostnummer;
        public System.Windows.Forms.TextBox txtPostort;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.Button btnUppdatera;
    }
}