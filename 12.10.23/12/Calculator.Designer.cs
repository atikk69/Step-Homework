namespace _12
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Main = new Panel();
            SumPanel = new Panel();
            ResultBox = new TextBox();
            CalculatorPanel = new TableLayoutPanel();
            Number4 = new Button();
            Number1 = new Button();
            Number5 = new Button();
            Number2 = new Button();
            Number8 = new Button();
            Number9 = new Button();
            Number6 = new Button();
            Number0 = new Button();
            Minus = new Button();
            Point = new Button();
            Number3 = new Button();
            Multiplication = new Button();
            Subtraction = new Button();
            Addition = new Button();
            Backspace = new Button();
            C = new Button();
            Equally = new Button();
            Number7 = new Button();
            Mugivara = new PictureBox();
            Division = new Button();
            Main.SuspendLayout();
            SumPanel.SuspendLayout();
            CalculatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Mugivara).BeginInit();
            SuspendLayout();
            // 
            // Main
            // 
            Main.BackColor = Color.DarkGray;
            Main.Controls.Add(SumPanel);
            Main.Controls.Add(CalculatorPanel);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(0, 0);
            Main.Name = "Main";
            Main.Size = new Size(408, 572);
            Main.TabIndex = 0;
            // 
            // SumPanel
            // 
            SumPanel.BackColor = SystemColors.ActiveCaption;
            SumPanel.Controls.Add(ResultBox);
            SumPanel.Dock = DockStyle.Fill;
            SumPanel.Location = new Point(0, 0);
            SumPanel.Name = "SumPanel";
            SumPanel.Size = new Size(408, 118);
            SumPanel.TabIndex = 2;
            // 
            // ResultBox
            // 
            ResultBox.BackColor = Color.Silver;
            ResultBox.BorderStyle = BorderStyle.None;
            ResultBox.Dock = DockStyle.Fill;
            ResultBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ResultBox.Location = new Point(0, 0);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(408, 118);
            ResultBox.TabIndex = 0;
            ResultBox.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorPanel
            // 
            CalculatorPanel.BackColor = Color.Silver;
            CalculatorPanel.ColumnCount = 4;
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.6377945F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.3622055F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            CalculatorPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            CalculatorPanel.Controls.Add(Number4, 0, 2);
            CalculatorPanel.Controls.Add(Number1, 0, 3);
            CalculatorPanel.Controls.Add(Number5, 1, 2);
            CalculatorPanel.Controls.Add(Number2, 1, 3);
            CalculatorPanel.Controls.Add(Number8, 1, 1);
            CalculatorPanel.Controls.Add(Number9, 2, 1);
            CalculatorPanel.Controls.Add(Number6, 2, 2);
            CalculatorPanel.Controls.Add(Number0, 1, 4);
            CalculatorPanel.Controls.Add(Minus, 0, 4);
            CalculatorPanel.Controls.Add(Point, 2, 4);
            CalculatorPanel.Controls.Add(Number3, 2, 3);
            CalculatorPanel.Controls.Add(Multiplication, 3, 1);
            CalculatorPanel.Controls.Add(Subtraction, 3, 2);
            CalculatorPanel.Controls.Add(Addition, 3, 3);
            CalculatorPanel.Controls.Add(Backspace, 3, 0);
            CalculatorPanel.Controls.Add(C, 2, 0);
            CalculatorPanel.Controls.Add(Equally, 3, 4);
            CalculatorPanel.Controls.Add(Number7, 0, 1);
            CalculatorPanel.Controls.Add(Mugivara, 1, 0);
            CalculatorPanel.Controls.Add(Division, 0, 0);
            CalculatorPanel.Dock = DockStyle.Bottom;
            CalculatorPanel.Location = new Point(0, 118);
            CalculatorPanel.Name = "CalculatorPanel";
            CalculatorPanel.RowCount = 5;
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 52.12766F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 47.87234F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            CalculatorPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            CalculatorPanel.Size = new Size(408, 454);
            CalculatorPanel.TabIndex = 0;
            // 
            // Number4
            // 
            Number4.Anchor = AnchorStyles.None;
            Number4.BackColor = Color.White;
            Number4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number4.Location = new Point(3, 191);
            Number4.Name = "Number4";
            Number4.Size = new Size(84, 88);
            Number4.TabIndex = 3;
            Number4.Text = "4";
            Number4.UseVisualStyleBackColor = false;
            Number4.Click += Number4_Click;
            // 
            // Number1
            // 
            Number1.Anchor = AnchorStyles.None;
            Number1.BackColor = Color.White;
            Number1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number1.Location = new Point(3, 286);
            Number1.Name = "Number1";
            Number1.Size = new Size(84, 83);
            Number1.TabIndex = 4;
            Number1.Text = "1";
            Number1.UseVisualStyleBackColor = false;
            Number1.Click += Number1_Click;
            // 
            // Number5
            // 
            Number5.Anchor = AnchorStyles.None;
            Number5.BackColor = Color.White;
            Number5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number5.Location = new Point(93, 191);
            Number5.Name = "Number5";
            Number5.Size = new Size(93, 88);
            Number5.TabIndex = 5;
            Number5.Text = "5";
            Number5.UseMnemonic = false;
            Number5.UseVisualStyleBackColor = false;
            Number5.UseWaitCursor = true;
            Number5.Click += Number5_Click;
            // 
            // Number2
            // 
            Number2.Anchor = AnchorStyles.None;
            Number2.BackColor = Color.White;
            Number2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number2.Location = new Point(93, 286);
            Number2.Name = "Number2";
            Number2.Size = new Size(93, 83);
            Number2.TabIndex = 6;
            Number2.Text = "2";
            Number2.UseVisualStyleBackColor = false;
            Number2.Click += Number2_Click;
            // 
            // Number8
            // 
            Number8.Anchor = AnchorStyles.None;
            Number8.BackColor = Color.White;
            Number8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number8.Location = new Point(93, 101);
            Number8.Name = "Number8";
            Number8.Size = new Size(93, 84);
            Number8.TabIndex = 7;
            Number8.Text = "8";
            Number8.UseVisualStyleBackColor = false;
            Number8.Click += Number8_Click;
            // 
            // Number9
            // 
            Number9.Anchor = AnchorStyles.None;
            Number9.BackColor = Color.White;
            Number9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number9.Location = new Point(192, 101);
            Number9.Name = "Number9";
            Number9.Size = new Size(103, 84);
            Number9.TabIndex = 8;
            Number9.Text = "9";
            Number9.UseVisualStyleBackColor = false;
            Number9.Click += Number9_Click;
            // 
            // Number6
            // 
            Number6.Anchor = AnchorStyles.None;
            Number6.BackColor = Color.White;
            Number6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number6.Location = new Point(192, 191);
            Number6.Name = "Number6";
            Number6.Size = new Size(103, 88);
            Number6.TabIndex = 9;
            Number6.Text = "6";
            Number6.UseVisualStyleBackColor = false;
            Number6.Click += Number6_Click;
            // 
            // Number0
            // 
            Number0.BackColor = Color.White;
            Number0.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number0.Location = new Point(93, 377);
            Number0.Name = "Number0";
            Number0.Size = new Size(93, 74);
            Number0.TabIndex = 11;
            Number0.Text = "0";
            Number0.UseVisualStyleBackColor = false;
            Number0.Click += Number0_Click;
            // 
            // Minus
            // 
            Minus.BackColor = Color.White;
            Minus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Minus.Location = new Point(3, 377);
            Minus.Name = "Minus";
            Minus.Size = new Size(84, 74);
            Minus.TabIndex = 10;
            Minus.Text = "+/-";
            Minus.UseVisualStyleBackColor = false;
            Minus.Click += Minus_Click;
            // 
            // Point
            // 
            Point.BackColor = Color.White;
            Point.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Point.Location = new Point(192, 377);
            Point.Name = "Point";
            Point.Size = new Size(103, 74);
            Point.TabIndex = 12;
            Point.Text = ".";
            Point.UseVisualStyleBackColor = false;
            Point.Click += Point_Click;
            // 
            // Number3
            // 
            Number3.Anchor = AnchorStyles.None;
            Number3.BackColor = Color.White;
            Number3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number3.Location = new Point(192, 286);
            Number3.Name = "Number3";
            Number3.Size = new Size(103, 83);
            Number3.TabIndex = 13;
            Number3.Text = "3";
            Number3.UseVisualStyleBackColor = false;
            Number3.Click += Number3_Click;
            // 
            // Multiplication
            // 
            Multiplication.Anchor = AnchorStyles.None;
            Multiplication.BackColor = Color.Cyan;
            Multiplication.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Multiplication.Location = new Point(301, 101);
            Multiplication.Name = "Multiplication";
            Multiplication.Size = new Size(103, 84);
            Multiplication.TabIndex = 14;
            Multiplication.Text = "*";
            Multiplication.UseVisualStyleBackColor = false;
            Multiplication.Click += Multiplication_Click;
            // 
            // Subtraction
            // 
            Subtraction.Anchor = AnchorStyles.None;
            Subtraction.BackColor = Color.Cyan;
            Subtraction.Location = new Point(305, 191);
            Subtraction.Name = "Subtraction";
            Subtraction.Size = new Size(96, 88);
            Subtraction.TabIndex = 15;
            Subtraction.Text = "-";
            Subtraction.UseVisualStyleBackColor = false;
            Subtraction.Click += Subtraction_Click;
            // 
            // Addition
            // 
            Addition.Anchor = AnchorStyles.None;
            Addition.BackColor = Color.Cyan;
            Addition.Location = new Point(305, 286);
            Addition.Name = "Addition";
            Addition.Size = new Size(96, 83);
            Addition.TabIndex = 16;
            Addition.Text = "+";
            Addition.UseVisualStyleBackColor = false;
            Addition.Click += Addition_Click;
            // 
            // Backspace
            // 
            Backspace.Anchor = AnchorStyles.None;
            Backspace.BackColor = Color.White;
            Backspace.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Backspace.Location = new Point(301, 7);
            Backspace.Name = "Backspace";
            Backspace.Size = new Size(103, 84);
            Backspace.TabIndex = 20;
            Backspace.Text = "←\n";
            Backspace.UseVisualStyleBackColor = false;
            Backspace.Click += Backspace_Click;
            // 
            // C
            // 
            C.Anchor = AnchorStyles.None;
            C.BackColor = Color.White;
            C.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C.Location = new Point(192, 7);
            C.Name = "C";
            C.Size = new Size(103, 84);
            C.TabIndex = 18;
            C.Text = "C";
            C.UseVisualStyleBackColor = false;
            C.Click += C_Click;
            // 
            // Equally
            // 
            Equally.BackColor = Color.White;
            Equally.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Equally.Location = new Point(301, 377);
            Equally.Name = "Equally";
            Equally.Size = new Size(96, 74);
            Equally.TabIndex = 22;
            Equally.Text = "=";
            Equally.UseVisualStyleBackColor = false;
            Equally.Click += Equally_Click;
            // 
            // Number7
            // 
            Number7.Anchor = AnchorStyles.None;
            Number7.BackColor = Color.White;
            Number7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Number7.Location = new Point(3, 101);
            Number7.Name = "Number7";
            Number7.Size = new Size(84, 84);
            Number7.TabIndex = 2;
            Number7.Text = "7";
            Number7.UseVisualStyleBackColor = false;
            Number7.Click += Number7_Click;
            // 
            // Mugivara
            // 
            Mugivara.Anchor = AnchorStyles.None;
            Mugivara.ErrorImage = (Image)resources.GetObject("Mugivara.ErrorImage");
            Mugivara.Image = (Image)resources.GetObject("Mugivara.Image");
            Mugivara.InitialImage = null;
            Mugivara.Location = new Point(93, 9);
            Mugivara.Name = "Mugivara";
            Mugivara.Size = new Size(93, 80);
            Mugivara.SizeMode = PictureBoxSizeMode.StretchImage;
            Mugivara.TabIndex = 23;
            Mugivara.TabStop = false;
            Mugivara.Click += Mugivara_Click;
            // 
            // Division
            // 
            Division.Anchor = AnchorStyles.None;
            Division.BackColor = Color.Cyan;
            Division.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Division.Location = new Point(3, 7);
            Division.Name = "Division";
            Division.Size = new Size(84, 84);
            Division.TabIndex = 24;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = false;
            Division.Click += Division_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(408, 572);
            Controls.Add(Main);
            Name = "Calculator";
            Text = "Calculator";
            Main.ResumeLayout(false);
            SumPanel.ResumeLayout(false);
            SumPanel.PerformLayout();
            CalculatorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Mugivara).EndInit();
            ResumeLayout(false);
        }

        private Panel Main;
        private TableLayoutPanel CalculatorPanel;
        private Button Number7;
        private Button Number4;
        private Button Number1;
        private Button Number5;
        private Button Number2;
        private Button Backspace;
        private Button C;
        private Button Number8;
        private Button Number9;
        private Button Number6;
        private Button Number0;
        private Button Minus;
        private Button Point;
        private Button Number3;
        private Button Multiplication;
        private Button Subtraction;
        private Button Addition;
        private Panel SumPanel;
        private Button Equally;
        private TextBox ResultBox;
        private PictureBox Mugivara;
        private Button Division;
    }
}