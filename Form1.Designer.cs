namespace VS_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Display = new System.Windows.Forms.TextBox();
            this.BtnD = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnErase = new System.Windows.Forms.Button();
            this.BtnM = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnS = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnR = new System.Windows.Forms.Button();
            this.BtnP = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(291, 43);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnD
            // 
            this.BtnD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnD.Location = new System.Drawing.Point(12, 61);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(75, 47);
            this.BtnD.TabIndex = 1;
            this.BtnD.Text = "/";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCE.Location = new System.Drawing.Point(84, 61);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(75, 47);
            this.BtnCE.TabIndex = 2;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnC.Location = new System.Drawing.Point(156, 61);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(75, 47);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnErase
            // 
            this.BtnErase.Font = new System.Drawing.Font("Wingdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnErase.Location = new System.Drawing.Point(228, 61);
            this.BtnErase.Name = "BtnErase";
            this.BtnErase.Size = new System.Drawing.Size(75, 47);
            this.BtnErase.TabIndex = 4;
            this.BtnErase.Text = "";
            this.BtnErase.UseVisualStyleBackColor = true;
            this.BtnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // BtnM
            // 
            this.BtnM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnM.Location = new System.Drawing.Point(228, 114);
            this.BtnM.Name = "BtnM";
            this.BtnM.Size = new System.Drawing.Size(75, 47);
            this.BtnM.TabIndex = 8;
            this.BtnM.Text = "*";
            this.BtnM.UseVisualStyleBackColor = true;
            this.BtnM.Click += new System.EventHandler(this.BtnM_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn9.Location = new System.Drawing.Point(156, 114);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(75, 47);
            this.Btn9.TabIndex = 7;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Button_click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn8.Location = new System.Drawing.Point(84, 114);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(75, 47);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Button_click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn7.Location = new System.Drawing.Point(12, 114);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(75, 47);
            this.Btn7.TabIndex = 5;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Button_click);
            // 
            // BtnS
            // 
            this.BtnS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnS.Location = new System.Drawing.Point(228, 167);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(75, 47);
            this.BtnS.TabIndex = 12;
            this.BtnS.Text = "-";
            this.BtnS.UseVisualStyleBackColor = true;
            this.BtnS.Click += new System.EventHandler(this.BtnS_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn6.Location = new System.Drawing.Point(156, 167);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(75, 47);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Button_click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn5.Location = new System.Drawing.Point(84, 167);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(75, 47);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Button_click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn4.Location = new System.Drawing.Point(12, 167);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(75, 47);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Button_click);
            // 
            // BtnA
            // 
            this.BtnA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnA.Location = new System.Drawing.Point(228, 220);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(75, 47);
            this.BtnA.TabIndex = 16;
            this.BtnA.Text = "+";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn3.Location = new System.Drawing.Point(156, 220);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(75, 47);
            this.Btn3.TabIndex = 15;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Button_click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn2.Location = new System.Drawing.Point(84, 220);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(75, 47);
            this.Btn2.TabIndex = 14;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Button_click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn1.Location = new System.Drawing.Point(12, 220);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 47);
            this.Btn1.TabIndex = 13;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Button_click);
            // 
            // BtnR
            // 
            this.BtnR.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnR.Location = new System.Drawing.Point(228, 273);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(75, 47);
            this.BtnR.TabIndex = 20;
            this.BtnR.Text = "=";
            this.BtnR.UseVisualStyleBackColor = false;
            this.BtnR.Click += new System.EventHandler(this.BtnR_Click);
            // 
            // BtnP
            // 
            this.BtnP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnP.Location = new System.Drawing.Point(156, 273);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(75, 47);
            this.BtnP.TabIndex = 19;
            this.BtnP.Text = ".";
            this.BtnP.UseVisualStyleBackColor = true;
            this.BtnP.Click += new System.EventHandler(this.Button_click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn0.Location = new System.Drawing.Point(84, 273);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(75, 47);
            this.Btn0.TabIndex = 18;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Button_click);
            // 
            // BtnAS
            // 
            this.BtnAS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAS.Location = new System.Drawing.Point(12, 273);
            this.BtnAS.Name = "BtnAS";
            this.BtnAS.Size = new System.Drawing.Size(75, 47);
            this.BtnAS.TabIndex = 17;
            this.BtnAS.Text = "±";
            this.BtnAS.UseVisualStyleBackColor = true;
            this.BtnAS.Click += new System.EventHandler(this.BtnAS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(315, 336);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.BtnP);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnAS);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnS);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnM);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnErase);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.Display);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Display;
        private Button BtnD;
        private Button BtnCE;
        private Button BtnC;
        private Button BtnErase;
        private Button BtnM;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button BtnS;
        private Button Btn6;
        private Button Btn5;
        private Button Btn4;
        private Button BtnA;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button BtnR;
        private Button BtnP;
        private Button Btn0;
        private Button BtnAS;
    }
}