namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonLBrace = new System.Windows.Forms.Button();
            this.buttonRBrace = new System.Windows.Forms.Button();
            this.buttonClr = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AccessibleName = "display";
            this.display.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.display.Location = new System.Drawing.Point(27, 9);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(474, 84);
            this.display.TabIndex = 1;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(123, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(219, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 90);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(27, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 90);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(123, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 90);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(219, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 90);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(27, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 90);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(123, 109);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 90);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(219, 109);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 90);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(123, 397);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(90, 90);
            this.buttonDot.TabIndex = 12;
            this.buttonDot.Text = ",";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEqual.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(219, 397);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(90, 90);
            this.buttonEqual.TabIndex = 13;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(315, 397);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(90, 90);
            this.buttonPlus.TabIndex = 14;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(411, 397);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(90, 90);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimes.Location = new System.Drawing.Point(315, 301);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(90, 90);
            this.buttonTimes.TabIndex = 16;
            this.buttonTimes.Text = "*";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(411, 301);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(90, 90);
            this.buttonDiv.TabIndex = 17;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.ButtonOperation_Click);
            // 
            // buttonLBrace
            // 
            this.buttonLBrace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLBrace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLBrace.Location = new System.Drawing.Point(315, 205);
            this.buttonLBrace.Name = "buttonLBrace";
            this.buttonLBrace.Size = new System.Drawing.Size(90, 90);
            this.buttonLBrace.TabIndex = 18;
            this.buttonLBrace.Text = "(";
            this.buttonLBrace.UseVisualStyleBackColor = true;
            this.buttonLBrace.Click += new System.EventHandler(this.buttonLBrace_Click);
            // 
            // buttonRBrace
            // 
            this.buttonRBrace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRBrace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRBrace.Location = new System.Drawing.Point(411, 205);
            this.buttonRBrace.Name = "buttonRBrace";
            this.buttonRBrace.Size = new System.Drawing.Size(90, 90);
            this.buttonRBrace.TabIndex = 19;
            this.buttonRBrace.Text = ")";
            this.buttonRBrace.UseVisualStyleBackColor = true;
            this.buttonRBrace.Click += new System.EventHandler(this.buttonRBrace_Click);
            // 
            // buttonClr
            // 
            this.buttonClr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClr.Location = new System.Drawing.Point(315, 109);
            this.buttonClr.Name = "buttonClr";
            this.buttonClr.Size = new System.Drawing.Size(90, 90);
            this.buttonClr.TabIndex = 20;
            this.buttonClr.Text = "Clear";
            this.buttonClr.UseVisualStyleBackColor = true;
            this.buttonClr.Click += new System.EventHandler(this.buttonClr_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.Location = new System.Drawing.Point(411, 109);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 90);
            this.buttonDel.TabIndex = 21;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // button0
            // 
            this.button0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button0.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(27, 397);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(90, 90);
            this.button0.TabIndex = 22;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(527, 504);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonClr);
            this.Controls.Add(this.buttonRBrace);
            this.Controls.Add(this.buttonLBrace);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonLBrace;
        private System.Windows.Forms.Button buttonRBrace;
        private System.Windows.Forms.Button buttonClr;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button button0;
    }
}

