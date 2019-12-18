namespace WindowsFormsApp
{
    partial class Form1
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
            this.gb_calculate = new System.Windows.Forms.GroupBox();
            this.button_egale = new System.Windows.Forms.Button();
            this.button_addition = new System.Windows.Forms.Button();
            this.button_soustraction = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_virgule = new System.Windows.Forms.Button();
            this.button_sp2 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_sp1 = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.result_screen = new System.Windows.Forms.RichTextBox();
            this.gb_calculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_calculate
            // 
            this.gb_calculate.Controls.Add(this.button_egale);
            this.gb_calculate.Controls.Add(this.button_addition);
            this.gb_calculate.Controls.Add(this.button_soustraction);
            this.gb_calculate.Controls.Add(this.button_multiplication);
            this.gb_calculate.Controls.Add(this.button_virgule);
            this.gb_calculate.Controls.Add(this.button_sp2);
            this.gb_calculate.Controls.Add(this.button0);
            this.gb_calculate.Controls.Add(this.button9);
            this.gb_calculate.Controls.Add(this.button8);
            this.gb_calculate.Controls.Add(this.button7);
            this.gb_calculate.Controls.Add(this.button6);
            this.gb_calculate.Controls.Add(this.button5);
            this.gb_calculate.Controls.Add(this.button4);
            this.gb_calculate.Controls.Add(this.button3);
            this.gb_calculate.Controls.Add(this.button2);
            this.gb_calculate.Controls.Add(this.button1);
            this.gb_calculate.Controls.Add(this.button_division);
            this.gb_calculate.Controls.Add(this.button_sp1);
            this.gb_calculate.Controls.Add(this.btn_C);
            this.gb_calculate.Controls.Add(this.button_ce);
            this.gb_calculate.Location = new System.Drawing.Point(12, 87);
            this.gb_calculate.Name = "gb_calculate";
            this.gb_calculate.Size = new System.Drawing.Size(262, 287);
            this.gb_calculate.TabIndex = 3;
            this.gb_calculate.TabStop = false;
            // 
            // button_egale
            // 
            this.button_egale.Location = new System.Drawing.Point(196, 225);
            this.button_egale.Name = "button_egale";
            this.button_egale.Size = new System.Drawing.Size(56, 45);
            this.button_egale.TabIndex = 19;
            this.button_egale.Text = "=";
            this.button_egale.UseVisualStyleBackColor = true;
            this.button_egale.Click += new System.EventHandler(this.button_egale_Click);
            // 
            // button_addition
            // 
            this.button_addition.Location = new System.Drawing.Point(196, 174);
            this.button_addition.Name = "button_addition";
            this.button_addition.Size = new System.Drawing.Size(56, 45);
            this.button_addition.TabIndex = 18;
            this.button_addition.Text = "+";
            this.button_addition.UseVisualStyleBackColor = true;
            this.button_addition.Click += new System.EventHandler(this.button_addition_Click);
            // 
            // button_soustraction
            // 
            this.button_soustraction.Location = new System.Drawing.Point(196, 123);
            this.button_soustraction.Name = "button_soustraction";
            this.button_soustraction.Size = new System.Drawing.Size(56, 45);
            this.button_soustraction.TabIndex = 17;
            this.button_soustraction.Text = "-";
            this.button_soustraction.UseVisualStyleBackColor = true;
            this.button_soustraction.Click += new System.EventHandler(this.button_soustraction_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(196, 72);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(56, 45);
            this.button_multiplication.TabIndex = 16;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_multiplication_Click);
            // 
            // button_virgule
            // 
            this.button_virgule.Location = new System.Drawing.Point(134, 225);
            this.button_virgule.Name = "button_virgule";
            this.button_virgule.Size = new System.Drawing.Size(56, 45);
            this.button_virgule.TabIndex = 11;
            this.button_virgule.Text = ",";
            this.button_virgule.UseCompatibleTextRendering = true;
            this.button_virgule.UseVisualStyleBackColor = true;
            this.button_virgule.Click += new System.EventHandler(this.button_virgule_Click);
            // 
            // button_sp2
            // 
            this.button_sp2.Location = new System.Drawing.Point(10, 225);
            this.button_sp2.Name = "button_sp2";
            this.button_sp2.Size = new System.Drawing.Size(56, 45);
            this.button_sp2.TabIndex = 10;
            this.button_sp2.Text = "+-";
            this.button_sp2.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(72, 225);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 45);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseCompatibleTextRendering = true;
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(134, 72);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 45);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 72);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 45);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 72);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(134, 123);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 45);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(196, 21);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(56, 45);
            this.button_division.TabIndex = 15;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_division_Click);
            // 
            // button_sp1
            // 
            this.button_sp1.Location = new System.Drawing.Point(134, 21);
            this.button_sp1.Name = "button_sp1";
            this.button_sp1.Size = new System.Drawing.Size(56, 45);
            this.button_sp1.TabIndex = 14;
            this.button_sp1.Text = "<--";
            this.button_sp1.UseVisualStyleBackColor = true;
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(72, 21);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(56, 45);
            this.btn_C.TabIndex = 13;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // button_ce
            // 
            this.button_ce.Location = new System.Drawing.Point(10, 21);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(56, 45);
            this.button_ce.TabIndex = 12;
            this.button_ce.Text = "CE";
            this.button_ce.UseVisualStyleBackColor = true;
            this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
            // 
            // result_screen
            // 
            this.result_screen.Location = new System.Drawing.Point(12, 12);
            this.result_screen.Name = "result_screen";
            this.result_screen.Size = new System.Drawing.Size(262, 69);
            this.result_screen.TabIndex = 4;
            this.result_screen.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 382);
            this.Controls.Add(this.result_screen);
            this.Controls.Add(this.gb_calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_calculate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_calculate;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_sp1;
        private System.Windows.Forms.Button button_sp2;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_virgule;
        private System.Windows.Forms.Button button_egale;
        private System.Windows.Forms.Button button_addition;
        private System.Windows.Forms.Button button_soustraction;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.RichTextBox result_screen;
    }
}