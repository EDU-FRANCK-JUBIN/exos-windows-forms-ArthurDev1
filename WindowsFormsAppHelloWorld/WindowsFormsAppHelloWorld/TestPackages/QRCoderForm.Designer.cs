namespace WindowsFormsApp.TestPackages
{
    partial class QRCoderForm
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
            this.pictureBox_qrcode = new System.Windows.Forms.PictureBox();
            this.textBox_qrcode = new System.Windows.Forms.TextBox();
            this.button_qrcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_qrcode
            // 
            this.pictureBox_qrcode.BackColor = System.Drawing.Color.White;
            this.pictureBox_qrcode.Location = new System.Drawing.Point(12, 47);
            this.pictureBox_qrcode.Name = "pictureBox_qrcode";
            this.pictureBox_qrcode.Size = new System.Drawing.Size(270, 246);
            this.pictureBox_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_qrcode.TabIndex = 0;
            this.pictureBox_qrcode.TabStop = false;
            // 
            // textBox_qrcode
            // 
            this.textBox_qrcode.Location = new System.Drawing.Point(12, 308);
            this.textBox_qrcode.Multiline = true;
            this.textBox_qrcode.Name = "textBox_qrcode";
            this.textBox_qrcode.Size = new System.Drawing.Size(270, 45);
            this.textBox_qrcode.TabIndex = 1;
            // 
            // button_qrcode
            // 
            this.button_qrcode.Location = new System.Drawing.Point(81, 363);
            this.button_qrcode.Name = "button_qrcode";
            this.button_qrcode.Size = new System.Drawing.Size(124, 33);
            this.button_qrcode.TabIndex = 2;
            this.button_qrcode.Text = "Generate";
            this.button_qrcode.UseVisualStyleBackColor = true;
            this.button_qrcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "QR Code Generator";
            // 
            // QRCoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_qrcode);
            this.Controls.Add(this.textBox_qrcode);
            this.Controls.Add(this.pictureBox_qrcode);
            this.Name = "QRCoderForm";
            this.Text = "QRCoderForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_qrcode;
        private System.Windows.Forms.TextBox textBox_qrcode;
        private System.Windows.Forms.Button button_qrcode;
        private System.Windows.Forms.Label label1;
    }
}