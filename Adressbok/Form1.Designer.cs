namespace Adressbok
{
    partial class Adressbok
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
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPostort = new System.Windows.Forms.TextBox();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblGatuadress = new System.Windows.Forms.Label();
            this.lblPostnummer = new System.Windows.Forms.Label();
            this.lblPostort = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(24, 24);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(218, 20);
            this.txtNamn.TabIndex = 0;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(24, 270);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(218, 20);
            this.txtMail.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(24, 219);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(218, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtPostort
            // 
            this.txtPostort.Location = new System.Drawing.Point(24, 173);
            this.txtPostort.Name = "txtPostort";
            this.txtPostort.Size = new System.Drawing.Size(218, 20);
            this.txtPostort.TabIndex = 4;
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Location = new System.Drawing.Point(24, 126);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(218, 20);
            this.txtPostnummer.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(24, 75);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(218, 20);
            this.txtAdress.TabIndex = 2;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(21, 8);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(35, 13);
            this.lblNamn.TabIndex = 6;
            this.lblNamn.Text = "Namn";
            // 
            // lblGatuadress
            // 
            this.lblGatuadress.AutoSize = true;
            this.lblGatuadress.Location = new System.Drawing.Point(21, 59);
            this.lblGatuadress.Name = "lblGatuadress";
            this.lblGatuadress.Size = new System.Drawing.Size(61, 13);
            this.lblGatuadress.TabIndex = 7;
            this.lblGatuadress.Text = "Gatuadress";
            // 
            // lblPostnummer
            // 
            this.lblPostnummer.AutoSize = true;
            this.lblPostnummer.Location = new System.Drawing.Point(21, 110);
            this.lblPostnummer.Name = "lblPostnummer";
            this.lblPostnummer.Size = new System.Drawing.Size(65, 13);
            this.lblPostnummer.TabIndex = 8;
            this.lblPostnummer.Text = "Postnummer";
            // 
            // lblPostort
            // 
            this.lblPostort.AutoSize = true;
            this.lblPostort.Location = new System.Drawing.Point(21, 157);
            this.lblPostort.Name = "lblPostort";
            this.lblPostort.Size = new System.Drawing.Size(40, 13);
            this.lblPostort.TabIndex = 9;
            this.lblPostort.Text = "Postort";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(21, 203);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 10;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(21, 254);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail";
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(24, 305);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(106, 34);
            this.btnRegistrera.TabIndex = 7;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.btnRegistrera_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Sökningsfält";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adressbok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblPostort);
            this.Controls.Add(this.lblPostnummer);
            this.Controls.Add(this.lblGatuadress);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.txtPostort);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNamn);
            this.Name = "Adressbok";
            this.Text = "Adressbok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPostort;
        private System.Windows.Forms.TextBox txtPostnummer;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblGatuadress;
        private System.Windows.Forms.Label lblPostnummer;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPostort;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Button button1;
    }
}

