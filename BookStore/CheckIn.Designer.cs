namespace BookStore
{
    partial class CheckIn
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
            label1 = new Label();
            username = new TextBox();
            label2 = new Label();
            parole = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "логин";
            // 
            // username
            // 
            username.Location = new Point(12, 27);
            username.Name = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "пароль";
            // 
            // parole
            // 
            parole.Location = new Point(12, 71);
            parole.Name = "parole";
            parole.Size = new Size(100, 23);
            parole.TabIndex = 3;
            // 
            // submit
            // 
            submit.Location = new Point(12, 100);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 4;
            submit.Text = "войти";
            submit.UseVisualStyleBackColor = true;
            submit.Click += OnClickSubm;
            // 
            // CheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(submit);
            Controls.Add(parole);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(label1);
            Name = "CheckIn";
            Text = "вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox username;
        private Label label2;
        private TextBox parole;
        private Button submit;
    }
}