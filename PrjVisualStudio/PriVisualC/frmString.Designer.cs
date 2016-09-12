namespace ImagingApp
{
    partial class frmString
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
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnConvertDecToHex = new System.Windows.Forms.Button();
            this.btnConvertHexToDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDec
            // 
            this.txtDec.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDec.Location = new System.Drawing.Point(179, 58);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(350, 33);
            this.txtDec.TabIndex = 0;
            // 
            // txtHex
            // 
            this.txtHex.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHex.Location = new System.Drawing.Point(179, 117);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(350, 33);
            this.txtHex.TabIndex = 1;
            // 
            // btnConvertDecToHex
            // 
            this.btnConvertDecToHex.Location = new System.Drawing.Point(593, 58);
            this.btnConvertDecToHex.Name = "btnConvertDecToHex";
            this.btnConvertDecToHex.Size = new System.Drawing.Size(145, 39);
            this.btnConvertDecToHex.TabIndex = 2;
            this.btnConvertDecToHex.Text = "Convert Dec To Hex";
            this.btnConvertDecToHex.UseVisualStyleBackColor = true;
            this.btnConvertDecToHex.Click += new System.EventHandler(this.btnConvertDecToHex_Click);
            // 
            // btnConvertHexToDec
            // 
            this.btnConvertHexToDec.Location = new System.Drawing.Point(593, 113);
            this.btnConvertHexToDec.Name = "btnConvertHexToDec";
            this.btnConvertHexToDec.Size = new System.Drawing.Size(141, 40);
            this.btnConvertHexToDec.TabIndex = 3;
            this.btnConvertHexToDec.Text = "Convert Hex To Dec";
            this.btnConvertHexToDec.UseVisualStyleBackColor = true;
            this.btnConvertHexToDec.Click += new System.EventHandler(this.btnConvertHexToDec_Click);
            // 
            // frmString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 602);
            this.Controls.Add(this.btnConvertHexToDec);
            this.Controls.Add(this.btnConvertDecToHex);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtDec);
            this.Name = "frmString";
            this.Text = "frmString";
            this.Load += new System.EventHandler(this.frmString_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.Button btnConvertDecToHex;
        private System.Windows.Forms.Button btnConvertHexToDec;
    }
}