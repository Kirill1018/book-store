namespace BookStore
{
    partial class WrittOffGood
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
            goods = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)goods).BeginInit();
            SuspendLayout();
            // 
            // goods
            // 
            goods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            goods.Location = new Point(12, 12);
            goods.Name = "goods";
            goods.Size = new Size(1000, 400);
            goods.TabIndex = 0;
            // 
            // WrittOffGood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 450);
            Controls.Add(goods);
            Name = "WrittOffGood";
            Text = "WrittOffGood";
            ((System.ComponentModel.ISupportInitialize)goods).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView goods;
    }
}