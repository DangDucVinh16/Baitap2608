namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDisplay;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEqual = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(20, 20);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(320, 39);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn0
            // 
            btn0.Location = new Point(20, 255);
            btn0.Name = "btn0";
            btn0.Size = new Size(130, 50);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.Click += NumberButton_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(20, 195);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 50);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(90, 195);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 50);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(160, 195);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 50);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(20, 135);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 50);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(90, 135);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 50);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.Click += NumberButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(160, 135);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 50);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.Click += NumberButton_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(20, 75);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 50);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(90, 75);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 50);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.Click += NumberButton_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(160, 75);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 50);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.Click += NumberButton_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(230, 255);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.Click += OperatorButton_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(230, 195);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.Click += OperatorButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(230, 135);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(50, 50);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.Click += OperatorButton_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(230, 75);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 50);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.Click += OperatorButton_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(160, 255);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(60, 50);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.Click += btnEqual_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(290, 75);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 230);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(401, 392);
            Controls.Add(txtDisplay);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Máy tính";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}