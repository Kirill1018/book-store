namespace BookStore
{
    partial class Store
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
            adding = new Button();
            volumes = new DataGridView();
            deletion = new Button();
            editing = new Button();
            sale = new Button();
            checkSal = new Button();
            deduction = new Button();
            writtOffGoods = new Button();
            usDisc = new Button();
            request = new Button();
            organizations = new Button();
            search = new Button();
            label1 = new Label();
            option = new ComboBox();
            label2 = new Label();
            searchVal = new TextBox();
            reset = new Button();
            label4 = new Label();
            period = new ComboBox();
            quest = new Button();
            reboot = new Button();
            label3 = new Label();
            group = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)volumes).BeginInit();
            SuspendLayout();
            // 
            // adding
            // 
            adding.Location = new Point(12, 418);
            adding.Name = "adding";
            adding.Size = new Size(75, 23);
            adding.TabIndex = 0;
            adding.Text = "добавить";
            adding.UseVisualStyleBackColor = true;
            adding.Click += OnClickAdd;
            // 
            // volumes
            // 
            volumes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            volumes.Location = new Point(12, 12);
            volumes.MultiSelect = false;
            volumes.Name = "volumes";
            volumes.Size = new Size(1000, 400);
            volumes.TabIndex = 1;
            // 
            // deletion
            // 
            deletion.Location = new Point(93, 418);
            deletion.Name = "deletion";
            deletion.Size = new Size(75, 23);
            deletion.TabIndex = 2;
            deletion.Text = "удалить";
            deletion.UseVisualStyleBackColor = true;
            deletion.Click += OnClickDel;
            // 
            // editing
            // 
            editing.Location = new Point(174, 418);
            editing.Name = "editing";
            editing.Size = new Size(98, 23);
            editing.TabIndex = 3;
            editing.Text = "редактировать";
            editing.UseVisualStyleBackColor = true;
            editing.Click += OnClickEd;
            // 
            // sale
            // 
            sale.Location = new Point(278, 418);
            sale.Name = "sale";
            sale.Size = new Size(75, 23);
            sale.TabIndex = 4;
            sale.Text = "продать";
            sale.UseVisualStyleBackColor = true;
            sale.Click += OnClickSale;
            // 
            // checkSal
            // 
            checkSal.Location = new Point(359, 418);
            checkSal.Name = "checkSal";
            checkSal.Size = new Size(75, 23);
            checkSal.TabIndex = 5;
            checkSal.Text = "продажи";
            checkSal.UseVisualStyleBackColor = true;
            checkSal.Click += OnClickCheckSal;
            // 
            // deduction
            // 
            deduction.Location = new Point(440, 418);
            deduction.Name = "deduction";
            deduction.Size = new Size(75, 23);
            deduction.TabIndex = 6;
            deduction.Text = "списать";
            deduction.UseVisualStyleBackColor = true;
            deduction.Click += OnClickDed;
            // 
            // writtOffGoods
            // 
            writtOffGoods.Location = new Point(521, 418);
            writtOffGoods.Name = "writtOffGoods";
            writtOffGoods.Size = new Size(119, 23);
            writtOffGoods.TabIndex = 7;
            writtOffGoods.Text = "списанные товары";
            writtOffGoods.UseVisualStyleBackColor = true;
            writtOffGoods.Click += OnClickWrittOffGoods;
            // 
            // usDisc
            // 
            usDisc.Location = new Point(646, 418);
            usDisc.Name = "usDisc";
            usDisc.Size = new Size(116, 23);
            usDisc.TabIndex = 8;
            usDisc.Text = "применить скидку";
            usDisc.UseVisualStyleBackColor = true;
            usDisc.Click += OnClickUseDisc;
            // 
            // request
            // 
            request.Location = new Point(768, 418);
            request.Name = "request";
            request.Size = new Size(104, 23);
            request.TabIndex = 9;
            request.Text = "оформить заказ";
            request.UseVisualStyleBackColor = true;
            request.Click += OnClickReq;
            // 
            // organizations
            // 
            organizations.Location = new Point(878, 418);
            organizations.Name = "organizations";
            organizations.Size = new Size(75, 23);
            organizations.TabIndex = 10;
            organizations.Text = "заказы";
            organizations.UseVisualStyleBackColor = true;
            organizations.Click += OnClickOrg;
            // 
            // search
            // 
            search.Location = new Point(1018, 103);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 11;
            search.Text = "поиск";
            search.UseVisualStyleBackColor = true;
            search.Click += OnClickSearch;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1018, 12);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 12;
            label1.Text = "параметр";
            // 
            // option
            // 
            option.FormattingEnabled = true;
            option.Location = new Point(1018, 30);
            option.Name = "option";
            option.Size = new Size(121, 23);
            option.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1018, 56);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 14;
            label2.Text = "значение";
            // 
            // searchVal
            // 
            searchVal.Location = new Point(1018, 74);
            searchVal.Name = "searchVal";
            searchVal.Size = new Size(100, 23);
            searchVal.TabIndex = 15;
            // 
            // reset
            // 
            reset.Location = new Point(1018, 132);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 16;
            reset.Text = "сбросить";
            reset.UseVisualStyleBackColor = true;
            reset.Click += OnClickRes;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1018, 202);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 19;
            label4.Text = "период";
            // 
            // period
            // 
            period.FormattingEnabled = true;
            period.Location = new Point(1018, 220);
            period.Name = "period";
            period.Size = new Size(121, 23);
            period.TabIndex = 20;
            // 
            // quest
            // 
            quest.Location = new Point(1018, 249);
            quest.Name = "quest";
            quest.Size = new Size(75, 23);
            quest.TabIndex = 21;
            quest.Text = "поиск";
            quest.UseVisualStyleBackColor = true;
            quest.Click += OnClickQuest;
            // 
            // reboot
            // 
            reboot.Location = new Point(1018, 278);
            reboot.Name = "reboot";
            reboot.Size = new Size(75, 23);
            reboot.TabIndex = 22;
            reboot.Text = "сбросить";
            reboot.UseVisualStyleBackColor = true;
            reboot.Click += OnClickReb;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1018, 158);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "категория";
            // 
            // group
            // 
            group.FormattingEnabled = true;
            group.Location = new Point(1018, 176);
            group.Name = "group";
            group.Size = new Size(200, 23);
            group.TabIndex = 23;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 450);
            Controls.Add(group);
            Controls.Add(reboot);
            Controls.Add(quest);
            Controls.Add(period);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(reset);
            Controls.Add(searchVal);
            Controls.Add(label2);
            Controls.Add(option);
            Controls.Add(label1);
            Controls.Add(search);
            Controls.Add(organizations);
            Controls.Add(request);
            Controls.Add(usDisc);
            Controls.Add(writtOffGoods);
            Controls.Add(deduction);
            Controls.Add(checkSal);
            Controls.Add(sale);
            Controls.Add(editing);
            Controls.Add(deletion);
            Controls.Add(volumes);
            Controls.Add(adding);
            Name = "Store";
            Text = "Store";
            ((System.ComponentModel.ISupportInitialize)volumes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adding;
        public DataGridView volumes;
        private Button deletion;
        private Button editing;
        private Button sale;
        private Button checkSal;
        private Button deduction;
        private Button writtOffGoods;
        private Button usDisc;
        private Button request;
        private Button organizations;
        private Button search;
        private Label label1;
        public ComboBox option;
        private Label label2;
        private TextBox searchVal;
        private Button reset;
        private Label label4;
        public ComboBox period;
        private Button quest;
        private Button reboot;
        private Label label3;
        public ComboBox group;
    }
}