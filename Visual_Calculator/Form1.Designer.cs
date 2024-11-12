namespace Visual_Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelTitel = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.CtgButton = new CustomControls.RJControls.RJButton();
            this.TanButton = new CustomControls.RJControls.RJButton();
            this.SinButton = new CustomControls.RJControls.RJButton();
            this.CosButton = new CustomControls.RJControls.RJButton();
            this.BtnPlusMinus = new CustomControls.RJControls.RJButton();
            this.Btn0 = new CustomControls.RJControls.RJButton();
            this.btnEnter = new CustomControls.RJControls.RJButton();
            this.Btn23 = new CustomControls.RJControls.RJButton();
            this.Btn1 = new CustomControls.RJControls.RJButton();
            this.Btn2 = new CustomControls.RJControls.RJButton();
            this.btnAdd = new CustomControls.RJControls.RJButton();
            this.Btn3 = new CustomControls.RJControls.RJButton();
            this.Bnt4 = new CustomControls.RJControls.RJButton();
            this.Btn5 = new CustomControls.RJControls.RJButton();
            this.btnMinus = new CustomControls.RJControls.RJButton();
            this.Btn6 = new CustomControls.RJControls.RJButton();
            this.Btn7 = new CustomControls.RJControls.RJButton();
            this.Btn8 = new CustomControls.RJControls.RJButton();
            this.btnMultiplicate = new CustomControls.RJControls.RJButton();
            this.Btn9 = new CustomControls.RJControls.RJButton();
            this.Btn5_ = new CustomControls.RJControls.RJButton();
            this.Btn6_ = new CustomControls.RJControls.RJButton();
            this.btnDivide = new CustomControls.RJControls.RJButton();
            this.Btn_ = new CustomControls.RJControls.RJButton();
            this.Btn1_ = new CustomControls.RJControls.RJButton();
            this.Btn2_ = new CustomControls.RJControls.RJButton();
            this.btnBackSpace = new CustomControls.RJControls.RJButton();
            this.btnClear = new CustomControls.RJControls.RJButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panelTitel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(0, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(350, 82);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.textBox2.ForeColor = System.Drawing.Color.Silver;
            this.textBox2.Location = new System.Drawing.Point(0, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(350, 25);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelTitel
            // 
            this.panelTitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelTitel.Controls.Add(this.buttonExit);
            this.panelTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitel.Location = new System.Drawing.Point(0, 0);
            this.panelTitel.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitel.Name = "panelTitel";
            this.panelTitel.Size = new System.Drawing.Size(350, 40);
            this.panelTitel.TabIndex = 21;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(300, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Х";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CtgButton
            // 
            this.CtgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CtgButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CtgButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CtgButton.BorderRadius = 15;
            this.CtgButton.BorderSize = 0;
            this.CtgButton.FlatAppearance.BorderSize = 0;
            this.CtgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtgButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtgButton.ForeColor = System.Drawing.Color.White;
            this.CtgButton.Location = new System.Drawing.Point(258, 150);
            this.CtgButton.Margin = new System.Windows.Forms.Padding(0);
            this.CtgButton.Name = "CtgButton";
            this.CtgButton.Size = new System.Drawing.Size(85, 36);
            this.CtgButton.TabIndex = 56;
            this.CtgButton.Text = "Ctg";
            this.CtgButton.TextColor = System.Drawing.Color.White;
            this.CtgButton.UseVisualStyleBackColor = false;
            this.CtgButton.Click += new System.EventHandler(this.CtgButton_Click);
            // 
            // TanButton
            // 
            this.TanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TanButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TanButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TanButton.BorderRadius = 15;
            this.TanButton.BorderSize = 0;
            this.TanButton.FlatAppearance.BorderSize = 0;
            this.TanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TanButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanButton.ForeColor = System.Drawing.Color.White;
            this.TanButton.Location = new System.Drawing.Point(173, 150);
            this.TanButton.Margin = new System.Windows.Forms.Padding(0);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(85, 36);
            this.TanButton.TabIndex = 55;
            this.TanButton.Text = "Tg";
            this.TanButton.TextColor = System.Drawing.Color.White;
            this.TanButton.UseVisualStyleBackColor = false;
            this.TanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SinButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SinButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SinButton.BorderRadius = 15;
            this.SinButton.BorderSize = 0;
            this.SinButton.FlatAppearance.BorderSize = 0;
            this.SinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinButton.ForeColor = System.Drawing.Color.White;
            this.SinButton.Location = new System.Drawing.Point(89, 150);
            this.SinButton.Margin = new System.Windows.Forms.Padding(0);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(85, 36);
            this.SinButton.TabIndex = 54;
            this.SinButton.Text = "Sin";
            this.SinButton.TextColor = System.Drawing.Color.White;
            this.SinButton.UseVisualStyleBackColor = false;
            this.SinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // CosButton
            // 
            this.CosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CosButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CosButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CosButton.BorderRadius = 15;
            this.CosButton.BorderSize = 0;
            this.CosButton.FlatAppearance.BorderSize = 0;
            this.CosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CosButton.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosButton.ForeColor = System.Drawing.Color.White;
            this.CosButton.Location = new System.Drawing.Point(4, 150);
            this.CosButton.Margin = new System.Windows.Forms.Padding(0);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(85, 36);
            this.CosButton.TabIndex = 53;
            this.CosButton.Text = "Cos";
            this.CosButton.TextColor = System.Drawing.Color.White;
            this.CosButton.UseVisualStyleBackColor = false;
            this.CosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // BtnPlusMinus
            // 
            this.BtnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnPlusMinus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BtnPlusMinus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPlusMinus.BorderRadius = 15;
            this.BtnPlusMinus.BorderSize = 0;
            this.BtnPlusMinus.FlatAppearance.BorderSize = 0;
            this.BtnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlusMinus.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlusMinus.ForeColor = System.Drawing.Color.White;
            this.BtnPlusMinus.Location = new System.Drawing.Point(3, 486);
            this.BtnPlusMinus.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPlusMinus.Name = "BtnPlusMinus";
            this.BtnPlusMinus.Size = new System.Drawing.Size(85, 60);
            this.BtnPlusMinus.TabIndex = 52;
            this.BtnPlusMinus.Text = "±";
            this.BtnPlusMinus.TextColor = System.Drawing.Color.White;
            this.BtnPlusMinus.UseVisualStyleBackColor = false;
            this.BtnPlusMinus.Click += new System.EventHandler(this.BtnPlusMinus_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn0.BorderRadius = 15;
            this.Btn0.BorderSize = 0;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.White;
            this.Btn0.Location = new System.Drawing.Point(88, 486);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(85, 60);
            this.Btn0.TabIndex = 51;
            this.Btn0.Text = "0";
            this.Btn0.TextColor = System.Drawing.Color.White;
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.btnDigit);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnter.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnEnter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEnter.BorderRadius = 15;
            this.btnEnter.BorderSize = 0;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(258, 486);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(0);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(85, 60);
            this.btnEnter.TabIndex = 50;
            this.btnEnter.Text = "=";
            this.btnEnter.TextColor = System.Drawing.Color.White;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Btn23
            // 
            this.Btn23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn23.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn23.BorderRadius = 15;
            this.Btn23.BorderSize = 0;
            this.Btn23.FlatAppearance.BorderSize = 0;
            this.Btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn23.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn23.ForeColor = System.Drawing.Color.White;
            this.Btn23.Location = new System.Drawing.Point(173, 486);
            this.Btn23.Margin = new System.Windows.Forms.Padding(0);
            this.Btn23.Name = "Btn23";
            this.Btn23.Size = new System.Drawing.Size(85, 60);
            this.Btn23.TabIndex = 49;
            this.Btn23.Text = ",";
            this.Btn23.TextColor = System.Drawing.Color.White;
            this.Btn23.UseVisualStyleBackColor = false;
            this.Btn23.Click += new System.EventHandler(this.btnDigit);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1.BorderRadius = 15;
            this.Btn1.BorderSize = 0;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(3, 426);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(85, 60);
            this.Btn1.TabIndex = 48;
            this.Btn1.Text = "1";
            this.Btn1.TextColor = System.Drawing.Color.White;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.btnDigit);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2.BorderRadius = 15;
            this.Btn2.BorderSize = 0;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.White;
            this.Btn2.Location = new System.Drawing.Point(88, 426);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(85, 60);
            this.Btn2.TabIndex = 47;
            this.Btn2.Text = "2";
            this.Btn2.TextColor = System.Drawing.Color.White;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.btnDigit);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(258, 426);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 60);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "+";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.AdditionButton);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn3.BorderRadius = 15;
            this.Btn3.BorderSize = 0;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.Color.White;
            this.Btn3.Location = new System.Drawing.Point(173, 426);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(85, 60);
            this.Btn3.TabIndex = 45;
            this.Btn3.Text = "3";
            this.Btn3.TextColor = System.Drawing.Color.White;
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.btnDigit);
            // 
            // Bnt4
            // 
            this.Bnt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Bnt4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Bnt4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Bnt4.BorderRadius = 15;
            this.Bnt4.BorderSize = 0;
            this.Bnt4.FlatAppearance.BorderSize = 0;
            this.Bnt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt4.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt4.ForeColor = System.Drawing.Color.White;
            this.Bnt4.Location = new System.Drawing.Point(3, 366);
            this.Bnt4.Margin = new System.Windows.Forms.Padding(0);
            this.Bnt4.Name = "Bnt4";
            this.Bnt4.Size = new System.Drawing.Size(85, 60);
            this.Bnt4.TabIndex = 44;
            this.Bnt4.Text = "4";
            this.Bnt4.TextColor = System.Drawing.Color.White;
            this.Bnt4.UseVisualStyleBackColor = false;
            this.Bnt4.Click += new System.EventHandler(this.btnDigit);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5.BorderRadius = 15;
            this.Btn5.BorderSize = 0;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.Color.White;
            this.Btn5.Location = new System.Drawing.Point(88, 366);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(85, 60);
            this.Btn5.TabIndex = 43;
            this.Btn5.Text = "5";
            this.Btn5.TextColor = System.Drawing.Color.White;
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.btnDigit);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMinus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMinus.BorderRadius = 15;
            this.btnMinus.BorderSize = 0;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location = new System.Drawing.Point(258, 366);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(85, 60);
            this.btnMinus.TabIndex = 42;
            this.btnMinus.Text = "-";
            this.btnMinus.TextColor = System.Drawing.Color.White;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.AdditionButton);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6.BorderRadius = 15;
            this.Btn6.BorderSize = 0;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.Color.White;
            this.Btn6.Location = new System.Drawing.Point(173, 366);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(85, 60);
            this.Btn6.TabIndex = 41;
            this.Btn6.Text = "6";
            this.Btn6.TextColor = System.Drawing.Color.White;
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.btnDigit);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn7.BorderRadius = 15;
            this.Btn7.BorderSize = 0;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.White;
            this.Btn7.Location = new System.Drawing.Point(3, 306);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(85, 60);
            this.Btn7.TabIndex = 40;
            this.Btn7.Text = "7";
            this.Btn7.TextColor = System.Drawing.Color.White;
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.btnDigit);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn8.BorderRadius = 15;
            this.Btn8.BorderSize = 0;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.White;
            this.Btn8.Location = new System.Drawing.Point(88, 306);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(85, 60);
            this.Btn8.TabIndex = 39;
            this.Btn8.Text = "8";
            this.Btn8.TextColor = System.Drawing.Color.White;
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.btnDigit);
            // 
            // btnMultiplicate
            // 
            this.btnMultiplicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMultiplicate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMultiplicate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMultiplicate.BorderRadius = 15;
            this.btnMultiplicate.BorderSize = 0;
            this.btnMultiplicate.FlatAppearance.BorderSize = 0;
            this.btnMultiplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicate.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicate.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicate.Location = new System.Drawing.Point(258, 306);
            this.btnMultiplicate.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiplicate.Name = "btnMultiplicate";
            this.btnMultiplicate.Size = new System.Drawing.Size(85, 60);
            this.btnMultiplicate.TabIndex = 38;
            this.btnMultiplicate.Text = "×";
            this.btnMultiplicate.TextColor = System.Drawing.Color.White;
            this.btnMultiplicate.UseVisualStyleBackColor = false;
            this.btnMultiplicate.Click += new System.EventHandler(this.AdditionButton);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn9.BorderRadius = 15;
            this.Btn9.BorderSize = 0;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.Color.White;
            this.Btn9.Location = new System.Drawing.Point(173, 306);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(85, 60);
            this.Btn9.TabIndex = 37;
            this.Btn9.Text = "9";
            this.Btn9.TextColor = System.Drawing.Color.White;
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.btnDigit);
            // 
            // Btn5_
            // 
            this.Btn5_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn5_.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn5_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5_.BorderRadius = 15;
            this.Btn5_.BorderSize = 0;
            this.Btn5_.FlatAppearance.BorderSize = 0;
            this.Btn5_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5_.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5_.ForeColor = System.Drawing.Color.White;
            this.Btn5_.Location = new System.Drawing.Point(3, 246);
            this.Btn5_.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5_.Name = "Btn5_";
            this.Btn5_.Size = new System.Drawing.Size(85, 60);
            this.Btn5_.TabIndex = 36;
            this.Btn5_.Text = "⅟x";
            this.Btn5_.TextColor = System.Drawing.Color.White;
            this.Btn5_.UseVisualStyleBackColor = false;
            this.Btn5_.Click += new System.EventHandler(this.Btn1__Click);
            // 
            // Btn6_
            // 
            this.Btn6_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn6_.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn6_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6_.BorderRadius = 15;
            this.Btn6_.BorderSize = 0;
            this.Btn6_.FlatAppearance.BorderSize = 0;
            this.Btn6_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6_.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6_.ForeColor = System.Drawing.Color.White;
            this.Btn6_.Location = new System.Drawing.Point(88, 246);
            this.Btn6_.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6_.Name = "Btn6_";
            this.Btn6_.Size = new System.Drawing.Size(85, 60);
            this.Btn6_.TabIndex = 35;
            this.Btn6_.Text = "x²";
            this.Btn6_.TextColor = System.Drawing.Color.White;
            this.Btn6_.UseVisualStyleBackColor = false;
            this.Btn6_.Click += new System.EventHandler(this.Btn1__Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDivide.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDivide.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDivide.BorderRadius = 15;
            this.btnDivide.BorderSize = 0;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(258, 246);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(85, 60);
            this.btnDivide.TabIndex = 34;
            this.btnDivide.Text = "÷";
            this.btnDivide.TextColor = System.Drawing.Color.White;
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.AdditionButton);
            // 
            // Btn_
            // 
            this.Btn_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn_.BorderRadius = 15;
            this.Btn_.BorderSize = 0;
            this.Btn_.FlatAppearance.BorderSize = 0;
            this.Btn_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_.Font = new System.Drawing.Font("Gadugi", 28F);
            this.Btn_.ForeColor = System.Drawing.Color.White;
            this.Btn_.Location = new System.Drawing.Point(173, 246);
            this.Btn_.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_.Name = "Btn_";
            this.Btn_.Size = new System.Drawing.Size(85, 60);
            this.Btn_.TabIndex = 33;
            this.Btn_.Text = "²√x";
            this.Btn_.TextColor = System.Drawing.Color.White;
            this.Btn_.UseVisualStyleBackColor = false;
            this.Btn_.Click += new System.EventHandler(this.Btn1__Click);
            // 
            // Btn1_
            // 
            this.Btn1_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1_.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1_.BorderRadius = 15;
            this.Btn1_.BorderSize = 0;
            this.Btn1_.FlatAppearance.BorderSize = 0;
            this.Btn1_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_.ForeColor = System.Drawing.Color.White;
            this.Btn1_.Location = new System.Drawing.Point(4, 186);
            this.Btn1_.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1_.Name = "Btn1_";
            this.Btn1_.Size = new System.Drawing.Size(85, 60);
            this.Btn1_.TabIndex = 32;
            this.Btn1_.Text = "%";
            this.Btn1_.TextColor = System.Drawing.Color.White;
            this.Btn1_.UseVisualStyleBackColor = false;
            this.Btn1_.Click += new System.EventHandler(this.Btn1__Click);
            // 
            // Btn2_
            // 
            this.Btn2_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn2_.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn2_.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2_.BorderRadius = 15;
            this.Btn2_.BorderSize = 0;
            this.Btn2_.FlatAppearance.BorderSize = 0;
            this.Btn2_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2_.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2_.ForeColor = System.Drawing.Color.White;
            this.Btn2_.Location = new System.Drawing.Point(89, 186);
            this.Btn2_.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2_.Name = "Btn2_";
            this.Btn2_.Size = new System.Drawing.Size(85, 60);
            this.Btn2_.TabIndex = 31;
            this.Btn2_.Text = "CE";
            this.Btn2_.TextColor = System.Drawing.Color.White;
            this.Btn2_.UseVisualStyleBackColor = false;
            this.Btn2_.Click += new System.EventHandler(this.Btn2__Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBackSpace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBackSpace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBackSpace.BorderRadius = 15;
            this.btnBackSpace.BorderSize = 0;
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.ForeColor = System.Drawing.Color.White;
            this.btnBackSpace.Location = new System.Drawing.Point(259, 186);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(85, 60);
            this.btnBackSpace.TabIndex = 30;
            this.btnBackSpace.Text = "⬅︎";
            this.btnBackSpace.TextColor = System.Drawing.Color.White;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.RemoveLastChar);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(174, 186);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 60);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "C";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.CtgButton);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.BtnPlusMinus);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.Btn23);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Bnt4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.btnMultiplicate);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn5_);
            this.Controls.Add(this.Btn6_);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.Btn_);
            this.Controls.Add(this.Btn1_);
            this.Controls.Add(this.Btn2_);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panelTitel);
            this.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator";
            this.panelTitel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panelTitel;
        private System.Windows.Forms.Button buttonExit;
        private CustomControls.RJControls.RJButton BtnPlusMinus;
        private CustomControls.RJControls.RJButton Btn0;
        private CustomControls.RJControls.RJButton btnEnter;
        private CustomControls.RJControls.RJButton Btn23;
        private CustomControls.RJControls.RJButton Btn1;
        private CustomControls.RJControls.RJButton Btn2;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton Btn3;
        private CustomControls.RJControls.RJButton Bnt4;
        private CustomControls.RJControls.RJButton Btn5;
        private CustomControls.RJControls.RJButton btnMinus;
        private CustomControls.RJControls.RJButton Btn6;
        private CustomControls.RJControls.RJButton Btn7;
        private CustomControls.RJControls.RJButton Btn8;
        private CustomControls.RJControls.RJButton btnMultiplicate;
        private CustomControls.RJControls.RJButton Btn9;
        private CustomControls.RJControls.RJButton Btn5_;
        private CustomControls.RJControls.RJButton Btn6_;
        private CustomControls.RJControls.RJButton btnDivide;
        private CustomControls.RJControls.RJButton Btn_;
        private CustomControls.RJControls.RJButton Btn1_;
        private CustomControls.RJControls.RJButton Btn2_;
        private CustomControls.RJControls.RJButton btnBackSpace;
        private CustomControls.RJControls.RJButton btnClear;
        private CustomControls.RJControls.RJButton CtgButton;
        private CustomControls.RJControls.RJButton TanButton;
        private CustomControls.RJControls.RJButton SinButton;
        private CustomControls.RJControls.RJButton CosButton;
    }
}

