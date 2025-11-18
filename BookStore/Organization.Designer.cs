namespace BookStore
{
    partial class Organization
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
            view = new Button();
            requests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)requests).BeginInit();
            SuspendLayout();
            // 
            // view
            // 
            view.Location = new Point(12, 168);
            view.Name = "view";
            view.Size = new Size(111, 23);
            view.TabIndex = 2;
            view.Text = "посмотреть заказ";
            view.UseVisualStyleBackColor = true;
            view.Click += OnClickView;
            // 
            // requests
            // 
            requests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requests.Location = new Point(12, 12);
            requests.MultiSelect = false;
            requests.Name = "requests";
            requests.Size = new Size(240, 150);
            requests.TabIndex = 3;
            // 
            // Organization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(requests);
            Controls.Add(view);
            Name = "Organization";
            Text = "Organization";
            ((System.ComponentModel.ISupportInitialize)requests).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button view;
        private DataGridView requests;
    }
}