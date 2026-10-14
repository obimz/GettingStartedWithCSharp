namespace Calculator_App
{
    partial class Application
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
            resultBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button19 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // resultBox
            // 
            resultBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultBox.Location = new Point(21, 12);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(219, 47);
            resultBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 65);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AppendToCalculationString;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(78, 65);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AppendToCalculationString;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(134, 65);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AppendToCalculationString;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(190, 65);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 4;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            button4.Click += AppendToCalculationString;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(190, 121);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 8;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += AppendToCalculationString;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(134, 121);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += AppendToCalculationString;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(78, 121);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 6;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += AppendToCalculationString;
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(22, 121);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 5;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = true;
            button8.Click += AppendToCalculationString;
            // 
            // button9
            // 
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(190, 177);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 12;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = true;
            button9.Click += AppendToCalculationString;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(134, 177);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 11;
            button10.Text = "3";
            button10.UseVisualStyleBackColor = true;
            button10.Click += AppendToCalculationString;
            // 
            // button11
            // 
            button11.Cursor = Cursors.Hand;
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(78, 177);
            button11.Name = "button11";
            button11.Size = new Size(50, 50);
            button11.TabIndex = 10;
            button11.Text = "2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += AppendToCalculationString;
            // 
            // button12
            // 
            button12.Cursor = Cursors.Hand;
            button12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(22, 177);
            button12.Name = "button12";
            button12.Size = new Size(50, 50);
            button12.TabIndex = 9;
            button12.Text = "1";
            button12.UseVisualStyleBackColor = true;
            button12.Click += AppendToCalculationString;
            // 
            // button13
            // 
            button13.Cursor = Cursors.Hand;
            button13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(190, 233);
            button13.Name = "button13";
            button13.Size = new Size(50, 50);
            button13.TabIndex = 16;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += AppendToCalculationString;
            // 
            // button14
            // 
            button14.Cursor = Cursors.Hand;
            button14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(134, 233);
            button14.Name = "button14";
            button14.Size = new Size(50, 50);
            button14.TabIndex = 15;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = true;
            button14.Click += AppendToCalculationString;
            // 
            // button15
            // 
            button15.Cursor = Cursors.Hand;
            button15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(78, 233);
            button15.Name = "button15";
            button15.Size = new Size(50, 50);
            button15.TabIndex = 14;
            button15.Text = ")";
            button15.UseVisualStyleBackColor = true;
            button15.Click += AppendToCalculationString;
            // 
            // button16
            // 
            button16.Cursor = Cursors.Hand;
            button16.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(22, 233);
            button16.Name = "button16";
            button16.Size = new Size(50, 50);
            button16.TabIndex = 13;
            button16.Text = "(";
            button16.UseVisualStyleBackColor = true;
            button16.Click += AppendToCalculationString;
            // 
            // button17
            // 
            button17.Cursor = Cursors.Hand;
            button17.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(160, 289);
            button17.Name = "button17";
            button17.Size = new Size(83, 50);
            button17.TabIndex = 20;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += EvalauteCalculation;
            // 
            // button19
            // 
            button19.Cursor = Cursors.Hand;
            button19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.Location = new Point(101, 289);
            button19.Name = "button19";
            button19.Size = new Size(50, 50);
            button19.TabIndex = 18;
            button19.Text = ".";
            button19.UseVisualStyleBackColor = true;
            button19.Click += AppendToCalculationString;
            // 
            // button20
            // 
            button20.Cursor = Cursors.Hand;
            button20.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button20.Location = new Point(25, 289);
            button20.Name = "button20";
            button20.Size = new Size(73, 50);
            button20.TabIndex = 17;
            button20.Text = "CE";
            button20.UseVisualStyleBackColor = true;
            button20.Click += ClearEntry;
            // 
            // Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 362);
            Controls.Add(button17);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resultBox);
            Name = "Application";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button19;
        private Button button20;
    }
}
