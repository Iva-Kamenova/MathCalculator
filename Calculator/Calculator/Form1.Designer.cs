namespace Calculator
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
            txtBox = new TextBox();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnDivision = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnMultiplication = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnAddition = new Button();
            btnDecimalPoint = new Button();
            btnZero = new Button();
            btnEquality = new Button();
            btnSubtraction = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            equation = new Label();
            btnModulo = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.BackColor = SystemColors.ActiveCaption;
            txtBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBox.Location = new Point(22, 54);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(329, 38);
            txtBox.TabIndex = 0;
            txtBox.Text = "0";
            txtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.ActiveCaption;
            btnSeven.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSeven.Location = new Point(22, 112);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(61, 59);
            btnSeven.TabIndex = 1;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btn_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.ActiveCaption;
            btnEight.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEight.Location = new Point(89, 112);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(61, 59);
            btnEight.TabIndex = 2;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btn_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.ActiveCaption;
            btnNine.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnNine.Location = new Point(156, 112);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(61, 59);
            btnNine.TabIndex = 3;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btn_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = SystemColors.ActiveCaption;
            btnDivision.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDivision.Location = new Point(223, 112);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(30, 59);
            btnDivision.TabIndex = 4;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnOperation_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = SystemColors.ActiveCaption;
            btnClearEntry.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClearEntry.Location = new Point(290, 112);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(61, 59);
            btnClearEntry.TabIndex = 5;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnClear.Location = new Point(290, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 59);
            btnClear.TabIndex = 10;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = SystemColors.ActiveCaption;
            btnMultiplication.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnMultiplication.Location = new Point(223, 177);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(61, 59);
            btnMultiplication.TabIndex = 9;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += btnOperation_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.ActiveCaption;
            btnSix.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSix.Location = new Point(156, 177);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(61, 59);
            btnSix.TabIndex = 8;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btn_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.ActiveCaption;
            btnFive.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnFive.Location = new Point(89, 177);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(61, 59);
            btnFive.TabIndex = 7;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btn_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.ActiveCaption;
            btnFour.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnFour.Location = new Point(22, 177);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(61, 59);
            btnFour.TabIndex = 6;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btn_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = SystemColors.ActiveCaption;
            btnAddition.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddition.Location = new Point(223, 307);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(61, 59);
            btnAddition.TabIndex = 19;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += btnOperation_Click;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.BackColor = SystemColors.ActiveCaption;
            btnDecimalPoint.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnDecimalPoint.Location = new Point(156, 307);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(61, 59);
            btnDecimalPoint.TabIndex = 18;
            btnDecimalPoint.Text = ",";
            btnDecimalPoint.UseVisualStyleBackColor = false;
            btnDecimalPoint.Click += btn_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.ActiveCaption;
            btnZero.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnZero.Location = new Point(22, 307);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(128, 59);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btn_Click;
            // 
            // btnEquality
            // 
            btnEquality.BackColor = SystemColors.ActiveCaption;
            btnEquality.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEquality.Location = new Point(290, 242);
            btnEquality.Name = "btnEquality";
            btnEquality.Size = new Size(61, 124);
            btnEquality.TabIndex = 15;
            btnEquality.Text = "=";
            btnEquality.UseVisualStyleBackColor = false;
            btnEquality.Click += btnEquality_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = SystemColors.ActiveCaption;
            btnSubtraction.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSubtraction.Location = new Point(223, 242);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(61, 59);
            btnSubtraction.TabIndex = 14;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += btnOperation_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.ActiveCaption;
            btnThree.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnThree.Location = new Point(156, 242);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(61, 59);
            btnThree.TabIndex = 13;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btn_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.ActiveCaption;
            btnTwo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnTwo.Location = new Point(89, 242);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(61, 59);
            btnTwo.TabIndex = 12;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btn_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.ActiveCaption;
            btnOne.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOne.Location = new Point(22, 242);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(61, 59);
            btnOne.TabIndex = 11;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btn_Click;
            // 
            // equation
            // 
            equation.AutoSize = true;
            equation.BackColor = SystemColors.GradientInactiveCaption;
            equation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            equation.ForeColor = SystemColors.ButtonShadow;
            equation.Location = new Point(31, 64);
            equation.Name = "equation";
            equation.Size = new Size(0, 23);
            equation.TabIndex = 20;
            // 
            // btnModulo
            // 
            btnModulo.BackColor = SystemColors.ActiveCaption;
            btnModulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnModulo.Location = new Point(254, 112);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(30, 59);
            btnModulo.TabIndex = 21;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = false;
            btnModulo.Click += btnOperation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(376, 402);
            Controls.Add(btnModulo);
            Controls.Add(equation);
            Controls.Add(btnAddition);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btnZero);
            Controls.Add(btnEquality);
            Controls.Add(btnSubtraction);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnClear);
            Controls.Add(btnMultiplication);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnClearEntry);
            Controls.Add(btnDivision);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(txtBox);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnDivision;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnMultiplication;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnAddition;
        private Button btnDecimalPoint;
        private Button btnZero;
        private Button btnEquality;
        private Button btnSubtraction;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Label equation;
        private Button btnModulo;
    }
}
