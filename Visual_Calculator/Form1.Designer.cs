﻿namespace Visual_Calculator
{
    partial class FrmCalculator
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiplicate = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDisplay.Location = new System.Drawing.Point(7, 59);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(334, 50);
            this.lblDisplay.TabIndex = 0;
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(8, 471);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(250, 80);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(8, 385);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 80);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(94, 385);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 80);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(178, 385);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 80);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(178, 299);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 80);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(94, 299);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 80);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(8, 299);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 80);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(178, 213);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 80);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(94, 213);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 80);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(8, 213);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 80);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Location = new System.Drawing.Point(8, 127);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 80);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMultiplicate
            // 
            this.btnMultiplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicate.Location = new System.Drawing.Point(92, 127);
            this.btnMultiplicate.Name = "btnMultiplicate";
            this.btnMultiplicate.Size = new System.Drawing.Size(80, 80);
            this.btnMultiplicate.TabIndex = 13;
            this.btnMultiplicate.Text = "X";
            this.btnMultiplicate.UseVisualStyleBackColor = true;
            this.btnMultiplicate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Location = new System.Drawing.Point(178, 127);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(80, 80);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(264, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 166);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Lime;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEnter.Location = new System.Drawing.Point(264, 471);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(80, 80);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNum1.Location = new System.Drawing.Point(7, 9);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(337, 38);
            this.lblNum1.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Location = new System.Drawing.Point(264, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 80);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackSpace.Location = new System.Drawing.Point(264, 127);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(80, 80);
            this.btnBackSpace.TabIndex = 14;
            this.btnBackSpace.Text = "<---";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(8, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 50);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 19F);
            this.textBox2.Location = new System.Drawing.Point(8, 9);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 38);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 561);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiplicate);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lblDisplay);
            this.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiplicate;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

