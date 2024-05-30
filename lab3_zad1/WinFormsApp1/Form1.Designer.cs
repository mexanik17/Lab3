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
            tbname = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbname
            // 
            tbname.Location = new Point(277, 100);
            tbname.Name = "tbname";
            tbname.Size = new Size(194, 25);
            tbname.TabIndex = 0;
            tbname.Tag = "";
            tbname.TextChanged += tbname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 103);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 1;
            label1.Text = "Введите свое имя";
            // 
            // button1
            // 
            button1.Location = new Point(164, 165);
            button1.Name = "button1";
            button1.Size = new Size(276, 23);
            button1.TabIndex = 2;
            button1.Text = "Hello";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnHello_Click;
            // 
            // button2
            // 
            button2.Location = new Point(164, 205);
            button2.Name = "button2";
            button2.Size = new Size(276, 23);
            button2.TabIndex = 3;
            button2.Text = "Выйти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 328);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tbname);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Location = new Point(255, 255);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbname;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}
