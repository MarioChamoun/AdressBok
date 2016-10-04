namespace Adressbok
{
    partial class sokning
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
            this.lstbResultat = new System.Windows.Forms.ListBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSök = new System.Windows.Forms.Button();
            this.lblNamn = new System.Windows.Forms.Label();
            this.btnRaderaInfo = new System.Windows.Forms.Button();
            this.btnUppdateraInfo = new System.Windows.Forms.Button();
            this.bullionButton1 = new BullionButton();
            this.Sökning = new BullionTheme();
            this.SuspendLayout();
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(12, 58);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(243, 20);
            this.txtNamn.TabIndex = 2;
            // 
            // lstbResultat
            // 
            this.lstbResultat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbResultat.FormattingEnabled = true;
            this.lstbResultat.Location = new System.Drawing.Point(12, 84);
            this.lstbResultat.Name = "lstbResultat";
            this.lstbResultat.Size = new System.Drawing.Size(325, 160);
            this.lstbResultat.TabIndex = 3;
            // 
            // btnInfo
            // 
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Location = new System.Drawing.Point(214, 250);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(122, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Visa Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSök
            // 
            this.btnSök.ForeColor = System.Drawing.Color.Black;
            this.btnSök.Location = new System.Drawing.Point(261, 56);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(75, 23);
            this.btnSök.TabIndex = 0;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.ForeColor = System.Drawing.Color.Black;
            this.lblNamn.Location = new System.Drawing.Point(12, 42);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(91, 13);
            this.lblNamn.TabIndex = 1;
            this.lblNamn.Text = "Namn eller adress";
            // 
            // btnRaderaInfo
            // 
            this.btnRaderaInfo.ForeColor = System.Drawing.Color.Black;
            this.btnRaderaInfo.Location = new System.Drawing.Point(12, 250);
            this.btnRaderaInfo.Name = "btnRaderaInfo";
            this.btnRaderaInfo.Size = new System.Drawing.Size(74, 23);
            this.btnRaderaInfo.TabIndex = 5;
            this.btnRaderaInfo.Text = "Radera Info";
            this.btnRaderaInfo.UseVisualStyleBackColor = true;
            this.btnRaderaInfo.Click += new System.EventHandler(this.btnRaderaInfo_Click);
            // 
            // btnUppdateraInfo
            // 
            this.btnUppdateraInfo.ForeColor = System.Drawing.Color.Black;
            this.btnUppdateraInfo.Location = new System.Drawing.Point(118, 250);
            this.btnUppdateraInfo.Name = "btnUppdateraInfo";
            this.btnUppdateraInfo.Size = new System.Drawing.Size(90, 23);
            this.btnUppdateraInfo.TabIndex = 6;
            this.btnUppdateraInfo.Text = "Uppdatera info";
            this.btnUppdateraInfo.UseVisualStyleBackColor = true;
            this.btnUppdateraInfo.Click += new System.EventHandler(this.btnUppdateraInfo_Click);
            // 
            // bullionButton1
            // 
            this.bullionButton1.BackColor = System.Drawing.Color.Black;
            this.bullionButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.bullionButton1.ForeColor = System.Drawing.Color.Black;
            this.bullionButton1.Image = null;
            this.bullionButton1.Location = new System.Drawing.Point(302, 0);
            this.bullionButton1.Name = "bullionButton1";
            this.bullionButton1.Size = new System.Drawing.Size(47, 21);
            this.bullionButton1.TabIndex = 8;
            this.bullionButton1.Text = "X";
            this.bullionButton1.Click += new System.EventHandler(this.bullionButton1_Click);
            // 
            // Sökning
            // 
            this.Sökning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sökning.Font = new System.Drawing.Font("Verdana", 7F);
            this.Sökning.Location = new System.Drawing.Point(0, 0);
            this.Sökning.Name = "Sökning";
            this.Sökning.Size = new System.Drawing.Size(349, 283);
            this.Sökning.TabIndex = 7;
            this.Sökning.Text = "Sökning";
            // 
            // sokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 283);
            this.Controls.Add(this.bullionButton1);
            this.Controls.Add(this.btnUppdateraInfo);
            this.Controls.Add(this.btnRaderaInfo);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lstbResultat);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnSök);
            this.Controls.Add(this.Sökning);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sokning";
            this.Text = "sokning";
            this.Load += new System.EventHandler(this.sokning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Button btnRaderaInfo;
        public System.Windows.Forms.ListBox lstbResultat;
        private System.Windows.Forms.Button btnUppdateraInfo;
        public System.Windows.Forms.TextBox txtNamn;
        private BullionTheme Sökning;
        private BullionButton bullionButton1;
    }
}