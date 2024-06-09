namespace WinFormsApp1
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
            BackButton = new RJButton();
            ForwardButton = new RJButton();
            ExitButton = new RJButton();
            Ans1 = new RJButton();
            Ans2 = new RJButton();
            Ans3 = new RJButton();
            Ans5 = new RJButton();
            Ans7 = new RJButton();
            Ans4 = new RJButton();
            Ans6 = new RJButton();
            Ans8 = new RJButton();
            MainQ = new RJButton();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackButton.AnswerNumber = -1;
            BackButton.BackColor = Color.Transparent;
            BackButton.BackgroundColor = Color.Transparent;
            BackButton.BorderColor = Color.CornflowerBlue;
            BackButton.BorderRadius = 20;
            BackButton.BorderSize = 2;
            BackButton.EnableEh = true;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Popup;
            BackButton.Font = new Font("MS PGothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.SkyBlue;
            BackButton.Location = new Point(330, 481);
            BackButton.MouseClickColor = Color.FromArgb(10, 4, 83);
            BackButton.MouseEnterColor = Color.FromArgb(10, 4, 83);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(61, 49);
            BackButton.StayAfterClick = false;
            BackButton.TabIndex = 10;
            BackButton.Text = "<";
            BackButton.TextColor = Color.SkyBlue;
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ForwardButton
            // 
            ForwardButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ForwardButton.AnswerNumber = -1;
            ForwardButton.BackColor = Color.Transparent;
            ForwardButton.BackgroundColor = Color.Transparent;
            ForwardButton.BorderColor = Color.CornflowerBlue;
            ForwardButton.BorderRadius = 20;
            ForwardButton.BorderSize = 2;
            ForwardButton.EnableEh = true;
            ForwardButton.FlatAppearance.BorderSize = 0;
            ForwardButton.FlatStyle = FlatStyle.Popup;
            ForwardButton.Font = new Font("MS PGothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ForwardButton.ForeColor = Color.SkyBlue;
            ForwardButton.Location = new Point(397, 481);
            ForwardButton.MouseClickColor = Color.FromArgb(10, 4, 83);
            ForwardButton.MouseEnterColor = Color.FromArgb(10, 4, 83);
            ForwardButton.Name = "ForwardButton";
            ForwardButton.Size = new Size(62, 49);
            ForwardButton.StayAfterClick = false;
            ForwardButton.TabIndex = 11;
            ForwardButton.Text = " >";
            ForwardButton.TextColor = Color.SkyBlue;
            ForwardButton.UseVisualStyleBackColor = false;
            ForwardButton.Click += ForwardButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ExitButton.AnswerNumber = -1;
            ExitButton.BackColor = Color.Transparent;
            ExitButton.BackgroundColor = Color.Transparent;
            ExitButton.BorderColor = Color.CornflowerBlue;
            ExitButton.BorderRadius = 20;
            ExitButton.BorderSize = 2;
            ExitButton.EnableEh = true;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Popup;
            ExitButton.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.SkyBlue;
            ExitButton.Location = new Point(465, 481);
            ExitButton.MouseClickColor = Color.FromArgb(10, 4, 83);
            ExitButton.MouseEnterColor = Color.FromArgb(10, 4, 83);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 49);
            ExitButton.StayAfterClick = false;
            ExitButton.TabIndex = 13;
            ExitButton.Text = "Завершить";
            ExitButton.TextColor = Color.SkyBlue;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Ans1
            // 
            Ans1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans1.AnswerNumber = 0;
            Ans1.BackColor = Color.Transparent;
            Ans1.BackgroundColor = Color.Transparent;
            Ans1.BorderColor = Color.CornflowerBlue;
            Ans1.BorderRadius = 30;
            Ans1.BorderSize = 2;
            Ans1.EnableEh = true;
            Ans1.FlatAppearance.BorderSize = 0;
            Ans1.FlatStyle = FlatStyle.Popup;
            Ans1.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans1.ForeColor = Color.SkyBlue;
            Ans1.Location = new Point(40, 165);
            Ans1.MouseClickColor = Color.Navy;
            Ans1.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans1.Name = "Ans1";
            Ans1.Size = new Size(284, 69);
            Ans1.StayAfterClick = true;
            Ans1.TabIndex = 16;
            Ans1.Text = "3 (Абсолютно согласен)";
            Ans1.TextColor = Color.SkyBlue;
            Ans1.UseVisualStyleBackColor = false;
            Ans1.Click += Answer_Click;
            // 
            // Ans2
            // 
            Ans2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans2.AnswerNumber = 1;
            Ans2.BackColor = Color.Transparent;
            Ans2.BackgroundColor = Color.Transparent;
            Ans2.BorderColor = Color.CornflowerBlue;
            Ans2.BorderRadius = 30;
            Ans2.BorderSize = 2;
            Ans2.EnableEh = true;
            Ans2.FlatAppearance.BorderSize = 0;
            Ans2.FlatStyle = FlatStyle.Popup;
            Ans2.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans2.ForeColor = Color.SkyBlue;
            Ans2.Location = new Point(330, 165);
            Ans2.MouseClickColor = Color.Navy;
            Ans2.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans2.Name = "Ans2";
            Ans2.Size = new Size(284, 69);
            Ans2.StayAfterClick = true;
            Ans2.TabIndex = 21;
            Ans2.Text = "3 (Абсолютно согласен)";
            Ans2.TextColor = Color.SkyBlue;
            Ans2.UseVisualStyleBackColor = false;
            Ans2.Click += Answer_Click;
            // 
            // Ans3
            // 
            Ans3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans3.AnswerNumber = 2;
            Ans3.BackColor = Color.Transparent;
            Ans3.BackgroundColor = Color.Transparent;
            Ans3.BorderColor = Color.CornflowerBlue;
            Ans3.BorderRadius = 30;
            Ans3.BorderSize = 2;
            Ans3.EnableEh = true;
            Ans3.FlatAppearance.BorderSize = 0;
            Ans3.FlatStyle = FlatStyle.Popup;
            Ans3.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans3.ForeColor = Color.SkyBlue;
            Ans3.Location = new Point(40, 244);
            Ans3.MouseClickColor = Color.Navy;
            Ans3.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans3.Name = "Ans3";
            Ans3.Size = new Size(284, 69);
            Ans3.StayAfterClick = true;
            Ans3.TabIndex = 22;
            Ans3.Text = "3 (Абсолютно согласен)";
            Ans3.TextColor = Color.SkyBlue;
            Ans3.UseVisualStyleBackColor = false;
            Ans3.Click += Answer_Click;
            // 
            // Ans5
            // 
            Ans5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans5.AnswerNumber = 4;
            Ans5.BackColor = Color.Transparent;
            Ans5.BackgroundColor = Color.Transparent;
            Ans5.BorderColor = Color.CornflowerBlue;
            Ans5.BorderRadius = 30;
            Ans5.BorderSize = 2;
            Ans5.EnableEh = true;
            Ans5.FlatAppearance.BorderSize = 0;
            Ans5.FlatStyle = FlatStyle.Popup;
            Ans5.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans5.ForeColor = Color.SkyBlue;
            Ans5.Location = new Point(40, 323);
            Ans5.MouseClickColor = Color.Navy;
            Ans5.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans5.Name = "Ans5";
            Ans5.Size = new Size(284, 69);
            Ans5.StayAfterClick = true;
            Ans5.TabIndex = 23;
            Ans5.Text = "3 (Абсолютно согласен)";
            Ans5.TextColor = Color.SkyBlue;
            Ans5.UseVisualStyleBackColor = false;
            Ans5.Click += Answer_Click;
            // 
            // Ans7
            // 
            Ans7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans7.AnswerNumber = 6;
            Ans7.BackColor = Color.Transparent;
            Ans7.BackgroundColor = Color.Transparent;
            Ans7.BorderColor = Color.CornflowerBlue;
            Ans7.BorderRadius = 30;
            Ans7.BorderSize = 2;
            Ans7.EnableEh = true;
            Ans7.FlatAppearance.BorderSize = 0;
            Ans7.FlatStyle = FlatStyle.Popup;
            Ans7.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans7.ForeColor = Color.SkyBlue;
            Ans7.Location = new Point(40, 402);
            Ans7.MouseClickColor = Color.Navy;
            Ans7.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans7.Name = "Ans7";
            Ans7.Size = new Size(284, 69);
            Ans7.StayAfterClick = true;
            Ans7.TabIndex = 24;
            Ans7.Text = "3 (Абсолютно согласен)";
            Ans7.TextColor = Color.SkyBlue;
            Ans7.UseVisualStyleBackColor = false;
            Ans7.Click += Answer_Click;
            // 
            // Ans4
            // 
            Ans4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans4.AnswerNumber = 3;
            Ans4.BackColor = Color.Transparent;
            Ans4.BackgroundColor = Color.Transparent;
            Ans4.BorderColor = Color.CornflowerBlue;
            Ans4.BorderRadius = 30;
            Ans4.BorderSize = 2;
            Ans4.EnableEh = true;
            Ans4.FlatAppearance.BorderSize = 0;
            Ans4.FlatStyle = FlatStyle.Popup;
            Ans4.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans4.ForeColor = Color.SkyBlue;
            Ans4.Location = new Point(330, 244);
            Ans4.MouseClickColor = Color.Navy;
            Ans4.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans4.Name = "Ans4";
            Ans4.Size = new Size(284, 69);
            Ans4.StayAfterClick = true;
            Ans4.TabIndex = 25;
            Ans4.Text = "3 (Абсолютно согласен)";
            Ans4.TextColor = Color.SkyBlue;
            Ans4.UseVisualStyleBackColor = false;
            Ans4.Click += Answer_Click;
            // 
            // Ans6
            // 
            Ans6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans6.AnswerNumber = 5;
            Ans6.BackColor = Color.Transparent;
            Ans6.BackgroundColor = Color.Transparent;
            Ans6.BorderColor = Color.CornflowerBlue;
            Ans6.BorderRadius = 30;
            Ans6.BorderSize = 2;
            Ans6.EnableEh = true;
            Ans6.FlatAppearance.BorderSize = 0;
            Ans6.FlatStyle = FlatStyle.Popup;
            Ans6.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans6.ForeColor = Color.SkyBlue;
            Ans6.Location = new Point(330, 323);
            Ans6.MouseClickColor = Color.Navy;
            Ans6.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans6.Name = "Ans6";
            Ans6.Size = new Size(284, 69);
            Ans6.StayAfterClick = true;
            Ans6.TabIndex = 26;
            Ans6.Text = "3 (Абсолютно согласен)";
            Ans6.TextColor = Color.SkyBlue;
            Ans6.UseVisualStyleBackColor = false;
            Ans6.Click += Answer_Click;
            // 
            // Ans8
            // 
            Ans8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ans8.AnswerNumber = 7;
            Ans8.BackColor = Color.Transparent;
            Ans8.BackgroundColor = Color.Transparent;
            Ans8.BorderColor = Color.CornflowerBlue;
            Ans8.BorderRadius = 30;
            Ans8.BorderSize = 2;
            Ans8.EnableEh = true;
            Ans8.FlatAppearance.BorderSize = 0;
            Ans8.FlatStyle = FlatStyle.Popup;
            Ans8.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Ans8.ForeColor = Color.SkyBlue;
            Ans8.Location = new Point(330, 402);
            Ans8.MouseClickColor = Color.Navy;
            Ans8.MouseEnterColor = Color.FromArgb(10, 4, 83);
            Ans8.Name = "Ans8";
            Ans8.Size = new Size(284, 69);
            Ans8.StayAfterClick = true;
            Ans8.TabIndex = 27;
            Ans8.Text = "3 (Абсолютно согласен)";
            Ans8.TextColor = Color.SkyBlue;
            Ans8.UseVisualStyleBackColor = false;
            Ans8.Click += Answer_Click;
            // 
            // MainQ
            // 
            MainQ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainQ.AnswerNumber = -1;
            MainQ.BackColor = Color.Transparent;
            MainQ.BackgroundColor = Color.Transparent;
            MainQ.BorderColor = Color.CornflowerBlue;
            MainQ.BorderRadius = 30;
            MainQ.BorderSize = 2;
            MainQ.EnableEh = false;
            MainQ.FlatAppearance.BorderSize = 0;
            MainQ.FlatStyle = FlatStyle.Popup;
            MainQ.Font = new Font("Yu Gothic UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MainQ.ForeColor = Color.SkyBlue;
            MainQ.Location = new Point(40, 28);
            MainQ.MouseClickColor = Color.Navy;
            MainQ.MouseEnterColor = Color.FromArgb(10, 4, 83);
            MainQ.Name = "MainQ";
            MainQ.Size = new Size(574, 131);
            MainQ.StayAfterClick = true;
            MainQ.TabIndex = 28;
            MainQ.Text = "3 (Абсолютно согласен)";
            MainQ.TextColor = Color.SkyBlue;
            MainQ.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(650, 542);
            Controls.Add(MainQ);
            Controls.Add(Ans8);
            Controls.Add(Ans6);
            Controls.Add(Ans4);
            Controls.Add(Ans7);
            Controls.Add(Ans5);
            Controls.Add(Ans3);
            Controls.Add(Ans2);
            Controls.Add(Ans1);
            Controls.Add(ExitButton);
            Controls.Add(ForwardButton);
            Controls.Add(BackButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Advanced QA";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private RJButton BackButton;
        private RJButton ForwardButton;
        private RJButton ExitButton;
        private RJButton Ans1;
        private RJButton Ans2;
        private RJButton Ans3;
        private RJButton Ans5;
        private RJButton Ans7;
        private RJButton Ans4;
        private RJButton Ans6;
        private RJButton Ans8;
        private RJButton MainQ;
    }
}