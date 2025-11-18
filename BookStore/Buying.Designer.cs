namespace BookStore
{
    partial class Buying
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
            purchase = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)purchase).BeginInit();
            SuspendLayout();
            // 
            // purchase
            // 
            purchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            purchase.Location = new Point(12, 12);
            purchase.Name = "purchase";
            purchase.Size = new Size(1000, 400);
            purchase.TabIndex = 0;
            // 
            // Buying
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 450);
            Controls.Add(purchase);
            Name = "Buying";
            Text = "Buying";
            ((System.ComponentModel.ISupportInitialize)purchase).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView purchase;
    }
}