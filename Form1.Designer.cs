namespace ChaoticCampersStardewValleyCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GoldLabel = new System.Windows.Forms.Label();
            this.GoldTextBox = new System.Windows.Forms.TextBox();
            this.WoodTextBox = new System.Windows.Forms.TextBox();
            this.StoneTextBox = new System.Windows.Forms.TextBox();
            this.WoodLabel = new System.Windows.Forms.Label();
            this.StoneLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.YearOneTableLabel = new System.Windows.Forms.Label();
            this.YearOneTable = new System.Windows.Forms.TextBox();
            this.YearTwoTable = new System.Windows.Forms.TextBox();
            this.YearTwoTableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.Location = new System.Drawing.Point(13, 16);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(35, 15);
            this.GoldLabel.TabIndex = 0;
            this.GoldLabel.Text = "Gold:";
            // 
            // GoldTextBox
            // 
            this.GoldTextBox.Location = new System.Drawing.Point(68, 13);
            this.GoldTextBox.Name = "GoldTextBox";
            this.GoldTextBox.Size = new System.Drawing.Size(100, 23);
            this.GoldTextBox.TabIndex = 1;
            this.GoldTextBox.TextChanged += new System.EventHandler(this.GoldTextBox_TextChanged);
            // 
            // WoodTextBox
            // 
            this.WoodTextBox.Location = new System.Drawing.Point(68, 43);
            this.WoodTextBox.Name = "WoodTextBox";
            this.WoodTextBox.Size = new System.Drawing.Size(100, 23);
            this.WoodTextBox.TabIndex = 2;
            // 
            // StoneTextBox
            // 
            this.StoneTextBox.Location = new System.Drawing.Point(68, 73);
            this.StoneTextBox.Name = "StoneTextBox";
            this.StoneTextBox.Size = new System.Drawing.Size(100, 23);
            this.StoneTextBox.TabIndex = 3;
            // 
            // WoodLabel
            // 
            this.WoodLabel.AutoSize = true;
            this.WoodLabel.Location = new System.Drawing.Point(12, 46);
            this.WoodLabel.Name = "WoodLabel";
            this.WoodLabel.Size = new System.Drawing.Size(42, 15);
            this.WoodLabel.TabIndex = 4;
            this.WoodLabel.Text = "Wood:";
            // 
            // StoneLabel
            // 
            this.StoneLabel.AutoSize = true;
            this.StoneLabel.Location = new System.Drawing.Point(13, 76);
            this.StoneLabel.Name = "StoneLabel";
            this.StoneLabel.Size = new System.Drawing.Size(40, 15);
            this.StoneLabel.TabIndex = 5;
            this.StoneLabel.Text = "Stone:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(175, 13);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(84, 83);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // YearOneTableLabel
            // 
            this.YearOneTableLabel.AutoSize = true;
            this.YearOneTableLabel.Location = new System.Drawing.Point(12, 140);
            this.YearOneTableLabel.Name = "YearOneTableLabel";
            this.YearOneTableLabel.Size = new System.Drawing.Size(133, 15);
            this.YearOneTableLabel.TabIndex = 7;
            this.YearOneTableLabel.Text = "Year 1 Remaining Costs:";
            // 
            // YearOneTable
            // 
            this.YearOneTable.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearOneTable.Location = new System.Drawing.Point(13, 158);
            this.YearOneTable.Multiline = true;
            this.YearOneTable.Name = "YearOneTable";
            this.YearOneTable.Size = new System.Drawing.Size(246, 395);
            this.YearOneTable.TabIndex = 8;
            // 
            // YearTwoTable
            // 
            this.YearTwoTable.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearTwoTable.Location = new System.Drawing.Point(270, 158);
            this.YearTwoTable.Multiline = true;
            this.YearTwoTable.Name = "YearTwoTable";
            this.YearTwoTable.Size = new System.Drawing.Size(246, 395);
            this.YearTwoTable.TabIndex = 9;
            // 
            // YearTwoTableLabel
            // 
            this.YearTwoTableLabel.AutoSize = true;
            this.YearTwoTableLabel.Location = new System.Drawing.Point(270, 140);
            this.YearTwoTableLabel.Name = "YearTwoTableLabel";
            this.YearTwoTableLabel.Size = new System.Drawing.Size(141, 15);
            this.YearTwoTableLabel.TabIndex = 10;
            this.YearTwoTableLabel.Text = "Year 2+ Remaining Costs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 90);
            this.label1.TabIndex = 11;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearTwoTableLabel);
            this.Controls.Add(this.YearTwoTable);
            this.Controls.Add(this.YearOneTable);
            this.Controls.Add(this.YearOneTableLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.StoneLabel);
            this.Controls.Add(this.WoodLabel);
            this.Controls.Add(this.StoneTextBox);
            this.Controls.Add(this.WoodTextBox);
            this.Controls.Add(this.GoldTextBox);
            this.Controls.Add(this.GoldLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(544, 571);
            this.Name = "Form1";
            this.Text = "Chaotic Camper\'s Stardew Valley Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.TextBox GoldTextBox;
        private System.Windows.Forms.TextBox WoodTextBox;
        private System.Windows.Forms.TextBox StoneTextBox;
        private System.Windows.Forms.Label WoodLabel;
        private System.Windows.Forms.Label StoneLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label YearOneTableLabel;
        private System.Windows.Forms.TextBox YearOneTable;
        private System.Windows.Forms.TextBox YearTwoTable;
        private System.Windows.Forms.Label YearTwoTableLabel;
        private System.Windows.Forms.Label label1;
    }
}

