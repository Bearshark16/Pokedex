namespace Pokedex
{
    partial class Form1
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pokemonName = new System.Windows.Forms.Label();
            this.heightLable = new System.Windows.Forms.Label();
            this.expLable = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.typeLable = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.AbilityListView = new System.Windows.Forms.ListView();
            this.chAbility = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHidden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.StatListView = new System.Windows.Forms.ListView();
            this.statHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.warnngLable = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pokemonImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chMove = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.InventoryListView = new System.Windows.Forms.ListView();
            this.chItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFlingPower = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pokemonName);
            this.flowLayoutPanel3.Controls.Add(this.heightLable);
            this.flowLayoutPanel3.Controls.Add(this.expLable);
            this.flowLayoutPanel3.Controls.Add(this.progressBar1);
            this.flowLayoutPanel3.Controls.Add(this.typeLable);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(258, 80);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(237, 214);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // pokemonName
            // 
            this.pokemonName.AutoSize = true;
            this.pokemonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonName.Location = new System.Drawing.Point(3, 0);
            this.pokemonName.Name = "pokemonName";
            this.pokemonName.Size = new System.Drawing.Size(86, 31);
            this.pokemonName.TabIndex = 7;
            this.pokemonName.Text = "Name";
            // 
            // heightLable
            // 
            this.heightLable.AutoSize = true;
            this.heightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLable.Location = new System.Drawing.Point(8, 36);
            this.heightLable.Margin = new System.Windows.Forms.Padding(8, 5, 3, 0);
            this.heightLable.Name = "heightLable";
            this.heightLable.Size = new System.Drawing.Size(56, 20);
            this.heightLable.TabIndex = 8;
            this.heightLable.Text = "Height";
            // 
            // expLable
            // 
            this.expLable.AutoSize = true;
            this.expLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expLable.Location = new System.Drawing.Point(8, 61);
            this.expLable.Margin = new System.Windows.Forms.Padding(8, 5, 3, 0);
            this.expLable.Name = "expLable";
            this.expLable.Size = new System.Drawing.Size(41, 20);
            this.expLable.TabIndex = 9;
            this.expLable.Text = "EXP";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 84);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // typeLable
            // 
            this.typeLable.AutoSize = true;
            this.typeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLable.Location = new System.Drawing.Point(8, 115);
            this.typeLable.Margin = new System.Windows.Forms.Padding(8, 5, 3, 0);
            this.typeLable.Name = "typeLable";
            this.typeLable.Size = new System.Drawing.Size(43, 20);
            this.typeLable.TabIndex = 10;
            this.typeLable.Text = "Type";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.AbilityListView);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(258, 300);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(237, 461);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Abilities";
            // 
            // AbilityListView
            // 
            this.AbilityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAbility,
            this.chHidden,
            this.columnHeader1});
            this.AbilityListView.HideSelection = false;
            this.AbilityListView.Location = new System.Drawing.Point(3, 42);
            this.AbilityListView.Name = "AbilityListView";
            this.AbilityListView.Size = new System.Drawing.Size(230, 416);
            this.AbilityListView.TabIndex = 6;
            this.AbilityListView.UseCompatibleStateImageBehavior = false;
            this.AbilityListView.View = System.Windows.Forms.View.Details;
            // 
            // chAbility
            // 
            this.chAbility.Text = "Ability";
            this.chAbility.Width = 100;
            // 
            // chHidden
            // 
            this.chHidden.Text = "Hidden";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Slot";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.StatListView);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 461);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stats";
            // 
            // StatListView
            // 
            this.StatListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statHeader,
            this.statValueHeader});
            this.StatListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatListView.HideSelection = false;
            this.StatListView.Location = new System.Drawing.Point(3, 42);
            this.StatListView.Name = "StatListView";
            this.StatListView.Size = new System.Drawing.Size(223, 416);
            this.StatListView.TabIndex = 9;
            this.StatListView.UseCompatibleStateImageBehavior = false;
            this.StatListView.View = System.Windows.Forms.View.Details;
            // 
            // statHeader
            // 
            this.statHeader.Text = "Stat";
            this.statHeader.Width = 110;
            // 
            // statValueHeader
            // 
            this.statValueHeader.Text = "Value";
            this.statValueHeader.Width = 95;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.warnngLable);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(26, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 71);
            this.panel1.TabIndex = 1;
            // 
            // warnngLable
            // 
            this.warnngLable.AutoSize = true;
            this.warnngLable.ForeColor = System.Drawing.Color.Red;
            this.warnngLable.Location = new System.Drawing.Point(98, 50);
            this.warnngLable.Name = "warnngLable";
            this.warnngLable.Size = new System.Drawing.Size(0, 16);
            this.warnngLable.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Location = new System.Drawing.Point(100, 25);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(114, 22);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchButton.Location = new System.Drawing.Point(2, 25);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 22);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pokemonImage
            // 
            this.pokemonImage.BackColor = System.Drawing.Color.White;
            this.pokemonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemonImage.Location = new System.Drawing.Point(26, 80);
            this.pokemonImage.Name = "pokemonImage";
            this.pokemonImage.Size = new System.Drawing.Size(226, 214);
            this.pokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pokemonImage.TabIndex = 0;
            this.pokemonImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.146341F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.85366F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel1.Controls.Add(this.pokemonImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.07407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 467F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1276, 775);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMove});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(986, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(283, 461);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chMove
            // 
            this.chMove.Text = "Move";
            this.chMove.Width = 100;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.InventoryListView);
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.listView3);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(501, 300);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(243, 461);
            this.flowLayoutPanel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inventory";
            // 
            // InventoryListView
            // 
            this.InventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItem,
            this.chCost,
            this.chFlingPower});
            this.InventoryListView.HideSelection = false;
            this.InventoryListView.Location = new System.Drawing.Point(3, 42);
            this.InventoryListView.Name = "InventoryListView";
            this.InventoryListView.Size = new System.Drawing.Size(240, 175);
            this.InventoryListView.TabIndex = 7;
            this.InventoryListView.UseCompatibleStateImageBehavior = false;
            this.InventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // chItem
            // 
            this.chItem.Text = "Item";
            this.chItem.Width = 90;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            // 
            // chFlingPower
            // 
            this.chFlingPower.Text = "Fling Power";
            this.chFlingPower.Width = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Moves";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 262);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(240, 197);
            this.listView3.TabIndex = 9;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 810);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1282, 781);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Name Search";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 781);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 810);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Pokédex";
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label pokemonName;
        private System.Windows.Forms.Label heightLable;
        private System.Windows.Forms.Label expLable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label warnngLable;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.PictureBox pokemonImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label typeLable;
        private System.Windows.Forms.ListView StatListView;
        private System.Windows.Forms.ColumnHeader statHeader;
        private System.Windows.Forms.ColumnHeader statValueHeader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView AbilityListView;
        private System.Windows.Forms.ColumnHeader chAbility;
        private System.Windows.Forms.ColumnHeader chHidden;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chMove;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView InventoryListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader chItem;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chFlingPower;
    }
}

