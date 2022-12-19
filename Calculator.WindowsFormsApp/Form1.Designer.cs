namespace Calculator.WindowsFormsApp
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
            this.tbScreen = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.brandName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbScreen
            // 
            this.tbScreen.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbScreen.Location = new System.Drawing.Point(16, 48);
            this.tbScreen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 16);
            this.tbScreen.Name = "tbScreen";
            this.tbScreen.Size = new System.Drawing.Size(400, 57);
            this.tbScreen.TabIndex = 0;
            this.tbScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(16, 129);
            this.btnClear.Margin = new System.Windows.Forms.Padding(8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 52);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.OnButtonClearClick);
            // 
            // btnModulo
            // 
            this.btnModulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModulo.Location = new System.Drawing.Point(120, 129);
            this.btnModulo.Margin = new System.Windows.Forms.Padding(8);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(88, 52);
            this.btnModulo.TabIndex = 13;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = false;
            this.btnModulo.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegative.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNegative.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNegative.Location = new System.Drawing.Point(224, 129);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(8);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(88, 52);
            this.btnNegative.TabIndex = 14;
            this.btnNegative.Text = "+/-";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.OnButtonNegativeClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(328, 129);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 52);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "<-";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.OnButtonDeleteClick);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(16, 193);
            this.btn7.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(88, 88);
            this.btn7.TabIndex = 19;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(120, 193);
            this.btn8.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(88, 88);
            this.btn8.TabIndex = 20;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(224, 193);
            this.btn9.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(88, 88);
            this.btn9.TabIndex = 21;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(16, 289);
            this.btn4.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(88, 88);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(120, 289);
            this.btn5.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(88, 88);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(224, 289);
            this.btn6.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(88, 88);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(16, 385);
            this.btn1.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(88, 88);
            this.btn1.TabIndex = 25;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(120, 385);
            this.btn2.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(88, 88);
            this.btn2.TabIndex = 26;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(224, 385);
            this.btn3.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 88);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDivision.Location = new System.Drawing.Point(328, 193);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(88, 88);
            this.btnDivision.TabIndex = 28;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiplication.Location = new System.Drawing.Point(328, 289);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(88, 88);
            this.btnMultiplication.TabIndex = 29;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstraction.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubstraction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubstraction.Location = new System.Drawing.Point(328, 385);
            this.btnSubstraction.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(88, 88);
            this.btnSubstraction.TabIndex = 30;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(16, 481);
            this.btn0.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(88, 88);
            this.btn0.TabIndex = 31;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComma.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComma.Location = new System.Drawing.Point(120, 481);
            this.btnComma.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(88, 88);
            this.btnComma.TabIndex = 32;
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.OnButtonNumberClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(224, 481);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 88);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OnButtonOperationClick);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResult.Location = new System.Drawing.Point(328, 481);
            this.btnResult.Margin = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(88, 88);
            this.btnResult.TabIndex = 34;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.OnButtonResultClick);
            // 
            // brandName
            // 
            this.brandName.AutoSize = true;
            this.brandName.Font = new System.Drawing.Font("Vladimir Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brandName.ForeColor = System.Drawing.Color.DarkOrange;
            this.brandName.Location = new System.Drawing.Point(16, 9);
            this.brandName.Name = "brandName";
            this.brandName.Size = new System.Drawing.Size(156, 26);
            this.brandName.TabIndex = 35;
            this.brandName.Text = "Artur\'s Calculations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(432, 589);
            this.Controls.Add(this.brandName);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbScreen);
            this.Name = "Form1";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbScreen;
        private Label brandName;

        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;

        private Button btnAdd;
        private Button btnDivision;
        private Button btnMultiplication;
        private Button btnSubstraction;
        private Button btnModulo;

        private Button btnClear;
        private Button btnNegative;
        private Button btnDelete;
        private Button btnComma;
        private Button btnResult;
    }
}