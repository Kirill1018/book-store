namespace BookStore
{
    partial class Purchase
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
            buyer = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "имя покупателя";
            // 
            // buyer
            // 
            buyer.Location = new Point(12, 27);
            buyer.Name = "buyer";
            buyer.Size = new Size(100, 23);
            buyer.TabIndex = 1;
            // 
            // submit
            // 
            submit.Location = new Point(12, 56);
            submit.Name = "submit";
            submit.Size = new Size(109, 23);
            submit.TabIndex = 2;
            submit.Text = "оформить заказ";
            submit.UseVisualStyleBackColor = true;
            submit.Click += OnClickSubm;
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(submit);
            Controls.Add(buyer);
            Controls.Add(label1);
            Name = "Purchase";
            Text = "Purchase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox buyer;
        private Button submit;
    }
}