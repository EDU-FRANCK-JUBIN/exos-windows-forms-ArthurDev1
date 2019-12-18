namespace WindowsFormsApp.MainForm
{
    partial class FormMain
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
            this.button_calculator = new System.Windows.Forms.Button();
            this.button_data_personne = new System.Windows.Forms.Button();
            this.button_hexagone = new System.Windows.Forms.Button();
            this.lb_menu = new System.Windows.Forms.Label();
            this.button_qrcoder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_calculator
            // 
            this.button_calculator.Location = new System.Drawing.Point(12, 56);
            this.button_calculator.Name = "button_calculator";
            this.button_calculator.Size = new System.Drawing.Size(224, 35);
            this.button_calculator.TabIndex = 0;
            this.button_calculator.Text = "Calculator";
            this.button_calculator.UseVisualStyleBackColor = true;
            this.button_calculator.Click += new System.EventHandler(this.button_calculator_Click);
            // 
            // button_data_personne
            // 
            this.button_data_personne.Location = new System.Drawing.Point(12, 97);
            this.button_data_personne.Name = "button_data_personne";
            this.button_data_personne.Size = new System.Drawing.Size(224, 35);
            this.button_data_personne.TabIndex = 1;
            this.button_data_personne.Text = "Data Binding (Personne)";
            this.button_data_personne.UseVisualStyleBackColor = true;
            this.button_data_personne.Click += new System.EventHandler(this.button_data_personne_Click);
            // 
            // button_hexagone
            // 
            this.button_hexagone.Location = new System.Drawing.Point(12, 138);
            this.button_hexagone.Name = "button_hexagone";
            this.button_hexagone.Size = new System.Drawing.Size(224, 35);
            this.button_hexagone.TabIndex = 2;
            this.button_hexagone.Text = "Hexagone";
            this.button_hexagone.UseVisualStyleBackColor = true;
            this.button_hexagone.Click += new System.EventHandler(this.button_hexagone_Click);
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.Location = new System.Drawing.Point(99, 22);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(43, 17);
            this.lb_menu.TabIndex = 3;
            this.lb_menu.Text = "Menu";
            // 
            // button_qrcoder
            // 
            this.button_qrcoder.Location = new System.Drawing.Point(12, 179);
            this.button_qrcoder.Name = "button_qrcoder";
            this.button_qrcoder.Size = new System.Drawing.Size(224, 35);
            this.button_qrcoder.TabIndex = 4;
            this.button_qrcoder.Text = "QRCoder (packages)";
            this.button_qrcoder.UseVisualStyleBackColor = true;
            this.button_qrcoder.Click += new System.EventHandler(this.button_qrcoder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 221);
            this.Controls.Add(this.button_qrcoder);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.button_hexagone);
            this.Controls.Add(this.button_data_personne);
            this.Controls.Add(this.button_calculator);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calculator;
        private System.Windows.Forms.Button button_data_personne;
        private System.Windows.Forms.Button button_hexagone;
        private System.Windows.Forms.Label lb_menu;
        private System.Windows.Forms.Button button_qrcoder;
    }
}