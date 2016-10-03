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
            this.SuspendLayout();
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(12, 25);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(243, 20);
            this.txtNamn.TabIndex = 2;
            // 
            // lstbResultat
            // 
            this.lstbResultat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbResultat.FormattingEnabled = true;
            this.lstbResultat.Location = new System.Drawing.Point(12, 51);
            this.lstbResultat.Name = "lstbResultat";
            this.lstbResultat.Size = new System.Drawing.Size(324, 160);
            this.lstbResultat.TabIndex = 3;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(214, 217);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(122, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "Visa Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(261, 23);
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
            this.lblNamn.Location = new System.Drawing.Point(12, 9);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(91, 13);
            this.lblNamn.TabIndex = 1;
            this.lblNamn.Text = "Namn eller adress";
            // 
            // btnRaderaInfo
            // 
            this.btnRaderaInfo.Location = new System.Drawing.Point(12, 217);
            this.btnRaderaInfo.Name = "btnRaderaInfo";
            this.btnRaderaInfo.Size = new System.Drawing.Size(74, 23);
            this.btnRaderaInfo.TabIndex = 5;
            this.btnRaderaInfo.Text = "Radera Info";
            this.btnRaderaInfo.UseVisualStyleBackColor = true;
            this.btnRaderaInfo.Click += new System.EventHandler(this.btnRaderaInfo_Click);
            // 
            // btnUppdateraInfo
            // 
            this.btnUppdateraInfo.Location = new System.Drawing.Point(118, 217);
            this.btnUppdateraInfo.Name = "btnUppdateraInfo";
            this.btnUppdateraInfo.Size = new System.Drawing.Size(90, 23);
            this.btnUppdateraInfo.TabIndex = 6;
            this.btnUppdateraInfo.Text = "Uppdatera info";
            this.btnUppdateraInfo.UseVisualStyleBackColor = true;
            this.btnUppdateraInfo.Click += new System.EventHandler(this.btnUppdateraInfo_Click);
            // 
            // sokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 249);
            this.Controls.Add(this.btnUppdateraInfo);
            this.Controls.Add(this.btnRaderaInfo);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lstbResultat);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnSök);
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
    }
}