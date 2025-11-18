namespace BookStore
{
    partial class Markdown
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
            markdowns = new DataGridView();
            use = new Button();
            ((System.ComponentModel.ISupportInitialize)markdowns).BeginInit();
            SuspendLayout();
            // 
            // markdowns
            // 
            markdowns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            markdowns.Location = new Point(12, 12);
            markdowns.MultiSelect = false;
            markdowns.Name = "markdowns";
            markdowns.Size = new Size(240, 150);
            markdowns.TabIndex = 0;
            // 
            // use
            // 
            use.Location = new Point(12, 168);
            use.Name = "use";
            use.Size = new Size(76, 23);
            use.TabIndex = 1;
            use.Text = "применить";
            use.UseVisualStyleBackColor = true;
            use.Click += OnClickUse;
            // 
            // Markdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(use);
            Controls.Add(markdowns);
            Name = "Markdown";
            Text = "Markdown";
            ((System.ComponentModel.ISupportInitialize)markdowns).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView markdowns;
        private Button use;
    }
}