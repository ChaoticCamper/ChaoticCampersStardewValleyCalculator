namespace StardewValleyConstructionCalculator
{
    partial class MainWindow
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
            this.BuildingsLabel = new System.Windows.Forms.Label();
            this.BuildingsComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsComboBox = new System.Windows.Forms.ComboBox();
            this.BuildingsButton = new System.Windows.Forms.Button();
            this.ItemsButton = new System.Windows.Forms.Button();
            this.BuildingsNumberBox = new System.Windows.Forms.NumericUpDown();
            this.ItemsNumberBox = new System.Windows.Forms.NumericUpDown();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.InventoryGoldTextBox = new System.Windows.Forms.TextBox();
            this.InventoryGoldLabel = new System.Windows.Forms.Label();
            this.InventoryWoodLabel = new System.Windows.Forms.Label();
            this.InventoryWoodTextBox = new System.Windows.Forms.TextBox();
            this.InventoryHardwoodLabel = new System.Windows.Forms.Label();
            this.InventoryHardwoodTextBox = new System.Windows.Forms.TextBox();
            this.InventoryStoneLabel = new System.Windows.Forms.Label();
            this.InventoryStoneTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingsNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildingsLabel
            // 
            this.BuildingsLabel.AutoSize = true;
            this.BuildingsLabel.Location = new System.Drawing.Point(411, 41);
            this.BuildingsLabel.Name = "BuildingsLabel";
            this.BuildingsLabel.Size = new System.Drawing.Size(56, 15);
            this.BuildingsLabel.TabIndex = 1;
            this.BuildingsLabel.Text = "Buildings";
            this.BuildingsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuildingsComboBox
            // 
            this.BuildingsComboBox.FormattingEnabled = true;
            this.BuildingsComboBox.Items.AddRange(new object[] {
            "Barn lvl 1",
            "Barn lvl 2",
            "Barn lvl 3",
            "Coop lvl 1",
            "Coop lvl 2",
            "Coop lvl 3",
            "Shed lvl 1",
            "Shed lvl 2",
            "House Upgrade 1",
            "House Upgrade 2",
            "House Upgrade 3",
            "Shipping Bin"});
            this.BuildingsComboBox.Location = new System.Drawing.Point(473, 38);
            this.BuildingsComboBox.Name = "BuildingsComboBox";
            this.BuildingsComboBox.Size = new System.Drawing.Size(121, 23);
            this.BuildingsComboBox.TabIndex = 2;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Location = new System.Drawing.Point(411, 72);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(36, 15);
            this.ItemsLabel.TabIndex = 3;
            this.ItemsLabel.Text = "Items";
            this.ItemsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ItemsComboBox
            // 
            this.ItemsComboBox.FormattingEnabled = true;
            this.ItemsComboBox.Items.AddRange(new object[] {
            "Chest",
            "Barrel"});
            this.ItemsComboBox.Location = new System.Drawing.Point(473, 68);
            this.ItemsComboBox.Name = "ItemsComboBox";
            this.ItemsComboBox.Size = new System.Drawing.Size(121, 23);
            this.ItemsComboBox.TabIndex = 4;
            // 
            // BuildingsButton
            // 
            this.BuildingsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuildingsButton.Location = new System.Drawing.Point(726, 39);
            this.BuildingsButton.Name = "BuildingsButton";
            this.BuildingsButton.Size = new System.Drawing.Size(50, 23);
            this.BuildingsButton.TabIndex = 5;
            this.BuildingsButton.Text = "Add";
            this.BuildingsButton.UseVisualStyleBackColor = true;
            this.BuildingsButton.Click += new System.EventHandler(this.BuildingsButton_Click);
            // 
            // ItemsButton
            // 
            this.ItemsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ItemsButton.Location = new System.Drawing.Point(726, 68);
            this.ItemsButton.Name = "ItemsButton";
            this.ItemsButton.Size = new System.Drawing.Size(50, 23);
            this.ItemsButton.TabIndex = 6;
            this.ItemsButton.Text = "Add";
            this.ItemsButton.UseVisualStyleBackColor = true;
            // 
            // BuildingsNumberBox
            // 
            this.BuildingsNumberBox.Location = new System.Drawing.Point(600, 39);
            this.BuildingsNumberBox.Name = "BuildingsNumberBox";
            this.BuildingsNumberBox.Size = new System.Drawing.Size(120, 23);
            this.BuildingsNumberBox.TabIndex = 7;
            // 
            // ItemsNumberBox
            // 
            this.ItemsNumberBox.Location = new System.Drawing.Point(600, 68);
            this.ItemsNumberBox.Name = "ItemsNumberBox";
            this.ItemsNumberBox.Size = new System.Drawing.Size(120, 23);
            this.ItemsNumberBox.TabIndex = 8;
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectLabel.Location = new System.Drawing.Point(526, 9);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(143, 21);
            this.ProjectLabel.TabIndex = 9;
            this.ProjectLabel.Text = "Create Your Project";
            this.ProjectLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InventoryLabel.Location = new System.Drawing.Point(23, 9);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(152, 21);
            this.InventoryLabel.TabIndex = 10;
            this.InventoryLabel.Text = "Enter Your Inventory";
            this.InventoryLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // InventoryGoldTextBox
            // 
            this.InventoryGoldTextBox.Location = new System.Drawing.Point(84, 39);
            this.InventoryGoldTextBox.Name = "InventoryGoldTextBox";
            this.InventoryGoldTextBox.Size = new System.Drawing.Size(100, 23);
            this.InventoryGoldTextBox.TabIndex = 11;
            // 
            // InventoryGoldLabel
            // 
            this.InventoryGoldLabel.AutoSize = true;
            this.InventoryGoldLabel.Location = new System.Drawing.Point(12, 43);
            this.InventoryGoldLabel.Name = "InventoryGoldLabel";
            this.InventoryGoldLabel.Size = new System.Drawing.Size(35, 15);
            this.InventoryGoldLabel.TabIndex = 12;
            this.InventoryGoldLabel.Text = "Gold:";
            // 
            // InventoryWoodLabel
            // 
            this.InventoryWoodLabel.AutoSize = true;
            this.InventoryWoodLabel.Location = new System.Drawing.Point(12, 72);
            this.InventoryWoodLabel.Name = "InventoryWoodLabel";
            this.InventoryWoodLabel.Size = new System.Drawing.Size(42, 15);
            this.InventoryWoodLabel.TabIndex = 13;
            this.InventoryWoodLabel.Text = "Wood:";
            // 
            // InventoryWoodTextBox
            // 
            this.InventoryWoodTextBox.Location = new System.Drawing.Point(84, 68);
            this.InventoryWoodTextBox.Name = "InventoryWoodTextBox";
            this.InventoryWoodTextBox.Size = new System.Drawing.Size(100, 23);
            this.InventoryWoodTextBox.TabIndex = 14;
            // 
            // InventoryHardwoodLabel
            // 
            this.InventoryHardwoodLabel.AutoSize = true;
            this.InventoryHardwoodLabel.Location = new System.Drawing.Point(12, 100);
            this.InventoryHardwoodLabel.Name = "InventoryHardwoodLabel";
            this.InventoryHardwoodLabel.Size = new System.Drawing.Size(66, 15);
            this.InventoryHardwoodLabel.TabIndex = 15;
            this.InventoryHardwoodLabel.Text = "Hardwood:";
            // 
            // InventoryHardwoodTextBox
            // 
            this.InventoryHardwoodTextBox.Location = new System.Drawing.Point(84, 97);
            this.InventoryHardwoodTextBox.Name = "InventoryHardwoodTextBox";
            this.InventoryHardwoodTextBox.Size = new System.Drawing.Size(100, 23);
            this.InventoryHardwoodTextBox.TabIndex = 16;
            // 
            // InventoryStoneLabel
            // 
            this.InventoryStoneLabel.AutoSize = true;
            this.InventoryStoneLabel.Location = new System.Drawing.Point(12, 129);
            this.InventoryStoneLabel.Name = "InventoryStoneLabel";
            this.InventoryStoneLabel.Size = new System.Drawing.Size(40, 15);
            this.InventoryStoneLabel.TabIndex = 17;
            this.InventoryStoneLabel.Text = "Stone:";
            // 
            // InventoryStoneTextBox
            // 
            this.InventoryStoneTextBox.Location = new System.Drawing.Point(84, 126);
            this.InventoryStoneTextBox.Name = "InventoryStoneTextBox";
            this.InventoryStoneTextBox.Size = new System.Drawing.Size(100, 23);
            this.InventoryStoneTextBox.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(788, 687);
            this.Controls.Add(this.InventoryStoneTextBox);
            this.Controls.Add(this.InventoryStoneLabel);
            this.Controls.Add(this.InventoryHardwoodTextBox);
            this.Controls.Add(this.InventoryHardwoodLabel);
            this.Controls.Add(this.InventoryWoodTextBox);
            this.Controls.Add(this.InventoryWoodLabel);
            this.Controls.Add(this.InventoryGoldLabel);
            this.Controls.Add(this.InventoryGoldTextBox);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.ItemsNumberBox);
            this.Controls.Add(this.BuildingsNumberBox);
            this.Controls.Add(this.ItemsButton);
            this.Controls.Add(this.BuildingsButton);
            this.Controls.Add(this.ItemsComboBox);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.BuildingsComboBox);
            this.Controls.Add(this.BuildingsLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(544, 571);
            this.Name = "MainWindow";
            this.Text = "Stardew Valley Construction Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.BuildingsNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BuildingsLabel;
        private System.Windows.Forms.ComboBox BuildingsComboBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ComboBox ItemsComboBox;
        private System.Windows.Forms.Button BuildingsButton;
        private System.Windows.Forms.Button ItemsButton;
        private System.Windows.Forms.NumericUpDown BuildingsNumberBox;
        private System.Windows.Forms.NumericUpDown ItemsNumberBox;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label InventoryLabel;
        private System.Windows.Forms.TextBox InventoryGoldTextBox;
        private System.Windows.Forms.Label InventoryGoldLabel;
        private System.Windows.Forms.Label InventoryWoodLabel;
        private System.Windows.Forms.TextBox InventoryWoodTextBox;
        private System.Windows.Forms.Label InventoryHardwoodLabel;
        private System.Windows.Forms.TextBox InventoryHardwoodTextBox;
        private System.Windows.Forms.Label InventoryStoneLabel;
        private System.Windows.Forms.TextBox InventoryStoneTextBox;
    }
}

