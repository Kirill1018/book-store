namespace BookStore
{
    partial class Revision
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
            title = new TextBox();
            label2 = new Label();
            writer = new TextBox();
            label3 = new Label();
            publisher = new TextBox();
            label4 = new Label();
            pageAm = new TextBox();
            label5 = new Label();
            category = new TextBox();
            label6 = new Label();
            edYear = new TextBox();
            label7 = new Label();
            prodCost = new TextBox();
            label8 = new Label();
            costForSale = new TextBox();
            label9 = new Label();
            confirmation = new RadioButton();
            denial = new RadioButton();
            modification = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "название";
            // 
            // title
            // 
            title.Location = new Point(12, 27);
            title.Name = "title";
            title.Size = new Size(100, 23);
            title.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "фио автора";
            // 
            // writer
            // 
            writer.Location = new Point(12, 71);
            writer.Name = "writer";
            writer.Size = new Size(100, 23);
            writer.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "издательство";
            // 
            // publisher
            // 
            publisher.Location = new Point(12, 115);
            publisher.Name = "publisher";
            publisher.Size = new Size(100, 23);
            publisher.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 6;
            label4.Text = "количество страниц";
            // 
            // pageAm
            // 
            pageAm.Location = new Point(12, 159);
            pageAm.Name = "pageAm";
            pageAm.Size = new Size(100, 23);
            pageAm.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "жанр";
            // 
            // category
            // 
            category.Location = new Point(12, 203);
            category.Name = "category";
            category.Size = new Size(100, 23);
            category.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 10;
            label6.Text = "год издания";
            // 
            // edYear
            // 
            edYear.Location = new Point(12, 247);
            edYear.Name = "edYear";
            edYear.Size = new Size(100, 23);
            edYear.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 273);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 12;
            label7.Text = "себестоимость";
            // 
            // prodCost
            // 
            prodCost.Location = new Point(12, 291);
            prodCost.Name = "prodCost";
            prodCost.Size = new Size(100, 23);
            prodCost.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 317);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 14;
            label8.Text = "цена для продажи";
            // 
            // costForSale
            // 
            costForSale.Location = new Point(12, 335);
            costForSale.Name = "costForSale";
            costForSale.Size = new Size(100, 23);
            costForSale.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 361);
            label9.Name = "label9";
            label9.Size = new Size(275, 15);
            label9.TabIndex = 16;
            label9.Text = "является ли книга продолжением другой книги?";
            // 
            // confirmation
            // 
            confirmation.AutoSize = true;
            confirmation.Location = new Point(12, 379);
            confirmation.Name = "confirmation";
            confirmation.Size = new Size(37, 19);
            confirmation.TabIndex = 17;
            confirmation.TabStop = true;
            confirmation.Text = "да";
            confirmation.UseVisualStyleBackColor = true;
            // 
            // denial
            // 
            denial.AutoSize = true;
            denial.Location = new Point(55, 379);
            denial.Name = "denial";
            denial.Size = new Size(43, 19);
            denial.TabIndex = 18;
            denial.TabStop = true;
            denial.Text = "нет";
            denial.UseVisualStyleBackColor = true;
            // 
            // modification
            // 
            modification.Location = new Point(12, 404);
            modification.Name = "modification";
            modification.Size = new Size(100, 23);
            modification.TabIndex = 19;
            modification.Text = "редактировать";
            modification.UseVisualStyleBackColor = true;
            modification.Click += OnClickMod;
            // 
            // Revision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(modification);
            Controls.Add(denial);
            Controls.Add(confirmation);
            Controls.Add(label9);
            Controls.Add(costForSale);
            Controls.Add(label8);
            Controls.Add(prodCost);
            Controls.Add(label7);
            Controls.Add(edYear);
            Controls.Add(label6);
            Controls.Add(category);
            Controls.Add(label5);
            Controls.Add(pageAm);
            Controls.Add(label4);
            Controls.Add(publisher);
            Controls.Add(label3);
            Controls.Add(writer);
            Controls.Add(label2);
            Controls.Add(title);
            Controls.Add(label1);
            Name = "Revision";
            Text = "Revision";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox title;
        private Label label2;
        private TextBox writer;
        private Label label3;
        private TextBox publisher;
        private Label label4;
        private TextBox pageAm;
        private Label label5;
        private TextBox category;
        private Label label6;
        private TextBox edYear;
        private Label label7;
        private TextBox prodCost;
        private Label label8;
        private TextBox costForSale;
        private Label label9;
        private RadioButton confirmation;
        private RadioButton denial;
        private Button modification;
    }
}