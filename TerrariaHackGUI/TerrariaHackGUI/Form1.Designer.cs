namespace TerrariaHackGUI
{
    partial class TerrariaEditor
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
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.SkinColorDisplay = new System.Windows.Forms.PictureBox();
            this.SkinColorLabel = new System.Windows.Forms.Label();
            this.HairColorLabel = new System.Windows.Forms.Label();
            this.HairColorDisplay = new System.Windows.Forms.PictureBox();
            this.EyeColorLabel = new System.Windows.Forms.Label();
            this.EyeColorDisplay = new System.Windows.Forms.PictureBox();
            this.ShirtColorLabel = new System.Windows.Forms.Label();
            this.ShirtColorDisplay = new System.Windows.Forms.PictureBox();
            this.UnderShirtColorLabel = new System.Windows.Forms.Label();
            this.UnderShirtColorDisplay = new System.Windows.Forms.PictureBox();
            this.PantsColorLabel = new System.Windows.Forms.Label();
            this.PantsColorDisplay = new System.Windows.Forms.PictureBox();
            this.ShoeColorLabel = new System.Windows.Forms.Label();
            this.ShoeColorDisplay = new System.Windows.Forms.PictureBox();
            this.LoadCharacterButton = new System.Windows.Forms.Button();
            this.FileChooser = new System.Windows.Forms.OpenFileDialog();
            this.SaveCharacterButton = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.TreeView();
            this.PrefixList = new System.Windows.Forms.ListBox();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.CountChooser = new System.Windows.Forms.NumericUpDown();
            this.SaveItemButton = new System.Windows.Forms.Button();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.DifficultyBox = new System.Windows.Forms.ComboBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SkinColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HairColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShirtColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderShirtColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PantsColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoeColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorPicker
            // 
            this.ColorPicker.SolidColorOnly = true;
            // 
            // SkinColorDisplay
            // 
            this.SkinColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SkinColorDisplay.Location = new System.Drawing.Point(796, 21);
            this.SkinColorDisplay.Name = "SkinColorDisplay";
            this.SkinColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.SkinColorDisplay.TabIndex = 0;
            this.SkinColorDisplay.TabStop = false;
            this.SkinColorDisplay.Click += new System.EventHandler(this.SkinColorDisplay_Click);
            // 
            // SkinColorLabel
            // 
            this.SkinColorLabel.AutoSize = true;
            this.SkinColorLabel.Location = new System.Drawing.Point(793, 5);
            this.SkinColorLabel.Name = "SkinColorLabel";
            this.SkinColorLabel.Size = new System.Drawing.Size(55, 13);
            this.SkinColorLabel.TabIndex = 1;
            this.SkinColorLabel.Text = "Skin Color";
            // 
            // HairColorLabel
            // 
            this.HairColorLabel.AutoSize = true;
            this.HairColorLabel.Location = new System.Drawing.Point(687, 5);
            this.HairColorLabel.Name = "HairColorLabel";
            this.HairColorLabel.Size = new System.Drawing.Size(53, 13);
            this.HairColorLabel.TabIndex = 3;
            this.HairColorLabel.Text = "Hair Color";
            // 
            // HairColorDisplay
            // 
            this.HairColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HairColorDisplay.Location = new System.Drawing.Point(690, 21);
            this.HairColorDisplay.Name = "HairColorDisplay";
            this.HairColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.HairColorDisplay.TabIndex = 2;
            this.HairColorDisplay.TabStop = false;
            this.HairColorDisplay.Click += new System.EventHandler(this.HairColorDisplay_Click);
            // 
            // EyeColorLabel
            // 
            this.EyeColorLabel.AutoSize = true;
            this.EyeColorLabel.Location = new System.Drawing.Point(687, 61);
            this.EyeColorLabel.Name = "EyeColorLabel";
            this.EyeColorLabel.Size = new System.Drawing.Size(52, 13);
            this.EyeColorLabel.TabIndex = 5;
            this.EyeColorLabel.Text = "Eye Color";
            // 
            // EyeColorDisplay
            // 
            this.EyeColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeColorDisplay.Location = new System.Drawing.Point(690, 77);
            this.EyeColorDisplay.Name = "EyeColorDisplay";
            this.EyeColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.EyeColorDisplay.TabIndex = 4;
            this.EyeColorDisplay.TabStop = false;
            this.EyeColorDisplay.Click += new System.EventHandler(this.EyeColorDisplay_Click);
            // 
            // ShirtColorLabel
            // 
            this.ShirtColorLabel.AutoSize = true;
            this.ShirtColorLabel.Location = new System.Drawing.Point(793, 61);
            this.ShirtColorLabel.Name = "ShirtColorLabel";
            this.ShirtColorLabel.Size = new System.Drawing.Size(55, 13);
            this.ShirtColorLabel.TabIndex = 7;
            this.ShirtColorLabel.Text = "Shirt Color";
            // 
            // ShirtColorDisplay
            // 
            this.ShirtColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShirtColorDisplay.Location = new System.Drawing.Point(796, 77);
            this.ShirtColorDisplay.Name = "ShirtColorDisplay";
            this.ShirtColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.ShirtColorDisplay.TabIndex = 6;
            this.ShirtColorDisplay.TabStop = false;
            this.ShirtColorDisplay.Click += new System.EventHandler(this.ShirtColorDisplay_Click);
            // 
            // UnderShirtColorLabel
            // 
            this.UnderShirtColorLabel.AutoSize = true;
            this.UnderShirtColorLabel.Location = new System.Drawing.Point(687, 117);
            this.UnderShirtColorLabel.Name = "UnderShirtColorLabel";
            this.UnderShirtColorLabel.Size = new System.Drawing.Size(82, 13);
            this.UnderShirtColorLabel.TabIndex = 9;
            this.UnderShirtColorLabel.Text = "Undershirt Color";
            // 
            // UnderShirtColorDisplay
            // 
            this.UnderShirtColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnderShirtColorDisplay.Location = new System.Drawing.Point(690, 133);
            this.UnderShirtColorDisplay.Name = "UnderShirtColorDisplay";
            this.UnderShirtColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.UnderShirtColorDisplay.TabIndex = 8;
            this.UnderShirtColorDisplay.TabStop = false;
            this.UnderShirtColorDisplay.Click += new System.EventHandler(this.UnderShirtColorDisplay_Click);
            // 
            // PantsColorLabel
            // 
            this.PantsColorLabel.AutoSize = true;
            this.PantsColorLabel.Location = new System.Drawing.Point(793, 117);
            this.PantsColorLabel.Name = "PantsColorLabel";
            this.PantsColorLabel.Size = new System.Drawing.Size(61, 13);
            this.PantsColorLabel.TabIndex = 11;
            this.PantsColorLabel.Text = "Pants Color";
            // 
            // PantsColorDisplay
            // 
            this.PantsColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PantsColorDisplay.Location = new System.Drawing.Point(796, 133);
            this.PantsColorDisplay.Name = "PantsColorDisplay";
            this.PantsColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.PantsColorDisplay.TabIndex = 10;
            this.PantsColorDisplay.TabStop = false;
            this.PantsColorDisplay.Click += new System.EventHandler(this.PantsColorDisplay_Click);
            // 
            // ShoeColorLabel
            // 
            this.ShoeColorLabel.AutoSize = true;
            this.ShoeColorLabel.Location = new System.Drawing.Point(793, 173);
            this.ShoeColorLabel.Name = "ShoeColorLabel";
            this.ShoeColorLabel.Size = new System.Drawing.Size(59, 13);
            this.ShoeColorLabel.TabIndex = 13;
            this.ShoeColorLabel.Text = "Shoe Color";
            // 
            // ShoeColorDisplay
            // 
            this.ShoeColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShoeColorDisplay.Location = new System.Drawing.Point(796, 189);
            this.ShoeColorDisplay.Name = "ShoeColorDisplay";
            this.ShoeColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.ShoeColorDisplay.TabIndex = 12;
            this.ShoeColorDisplay.TabStop = false;
            this.ShoeColorDisplay.Click += new System.EventHandler(this.ShoeColorDisplay_Click);
            // 
            // LoadCharacterButton
            // 
            this.LoadCharacterButton.Location = new System.Drawing.Point(12, 12);
            this.LoadCharacterButton.Name = "LoadCharacterButton";
            this.LoadCharacterButton.Size = new System.Drawing.Size(96, 23);
            this.LoadCharacterButton.TabIndex = 14;
            this.LoadCharacterButton.Text = "Load Character";
            this.LoadCharacterButton.UseVisualStyleBackColor = true;
            this.LoadCharacterButton.Click += new System.EventHandler(this.LoadCharacterButton_Click);
            // 
            // FileChooser
            // 
            this.FileChooser.DefaultExt = "plr";
            this.FileChooser.FileName = "Player.plr";
            this.FileChooser.Title = "Chooser player file";
            // 
            // SaveCharacterButton
            // 
            this.SaveCharacterButton.Location = new System.Drawing.Point(12, 41);
            this.SaveCharacterButton.Name = "SaveCharacterButton";
            this.SaveCharacterButton.Size = new System.Drawing.Size(96, 23);
            this.SaveCharacterButton.TabIndex = 15;
            this.SaveCharacterButton.Text = "Save Character";
            this.SaveCharacterButton.UseVisualStyleBackColor = true;
            this.SaveCharacterButton.Click += new System.EventHandler(this.SaveCharacterButton_Click);
            // 
            // Inventory
            // 
            this.Inventory.HideSelection = false;
            this.Inventory.Location = new System.Drawing.Point(13, 78);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(265, 469);
            this.Inventory.TabIndex = 16;
            // 
            // PrefixList
            // 
            this.PrefixList.FormattingEnabled = true;
            this.PrefixList.Location = new System.Drawing.Point(297, 78);
            this.PrefixList.Name = "PrefixList";
            this.PrefixList.Size = new System.Drawing.Size(120, 134);
            this.PrefixList.TabIndex = 17;
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(297, 218);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(120, 277);
            this.ItemList.TabIndex = 18;
            // 
            // CountChooser
            // 
            this.CountChooser.Location = new System.Drawing.Point(297, 501);
            this.CountChooser.Name = "CountChooser";
            this.CountChooser.Size = new System.Drawing.Size(120, 20);
            this.CountChooser.TabIndex = 19;
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.Location = new System.Drawing.Point(297, 524);
            this.SaveItemButton.Name = "SaveItemButton";
            this.SaveItemButton.Size = new System.Drawing.Size(120, 23);
            this.SaveItemButton.TabIndex = 20;
            this.SaveItemButton.Text = "Save Item";
            this.SaveItemButton.UseVisualStyleBackColor = true;
            this.SaveItemButton.Click += new System.EventHandler(this.SaveItemButton_Click);
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.Location = new System.Drawing.Point(126, 32);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.Size = new System.Drawing.Size(49, 13);
            this.ReleaseLabel.TabIndex = 21;
            this.ReleaseLabel.Text = "Release:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(256, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 22;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(212, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name:";
            // 
            // GenderBox
            // 
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(256, 43);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(100, 21);
            this.GenderBox.TabIndex = 24;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(205, 46);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(45, 13);
            this.GenderLabel.TabIndex = 25;
            this.GenderLabel.Text = "Gender:";
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Softcore",
            "Mediumcore",
            "Hardcore"});
            this.DifficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyBox.FormattingEnabled = true;
            this.DifficultyBox.Items.AddRange(new object[] {
            "Softcore",
            "Mediumcore",
            "Hardcore"});
            this.DifficultyBox.Location = new System.Drawing.Point(429, 12);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(100, 21);
            this.DifficultyBox.TabIndex = 26;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(373, 15);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(50, 13);
            this.DifficultyLabel.TabIndex = 27;
            this.DifficultyLabel.Text = "Difficulty:";
            // 
            // TerrariaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 559);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ReleaseLabel);
            this.Controls.Add(this.SaveItemButton);
            this.Controls.Add(this.CountChooser);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.PrefixList);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.SaveCharacterButton);
            this.Controls.Add(this.LoadCharacterButton);
            this.Controls.Add(this.ShoeColorLabel);
            this.Controls.Add(this.ShoeColorDisplay);
            this.Controls.Add(this.PantsColorLabel);
            this.Controls.Add(this.PantsColorDisplay);
            this.Controls.Add(this.UnderShirtColorLabel);
            this.Controls.Add(this.UnderShirtColorDisplay);
            this.Controls.Add(this.ShirtColorLabel);
            this.Controls.Add(this.ShirtColorDisplay);
            this.Controls.Add(this.EyeColorLabel);
            this.Controls.Add(this.EyeColorDisplay);
            this.Controls.Add(this.HairColorLabel);
            this.Controls.Add(this.HairColorDisplay);
            this.Controls.Add(this.SkinColorLabel);
            this.Controls.Add(this.SkinColorDisplay);
            this.Name = "TerrariaEditor";
            this.Text = "TerrariaEditor";
            ((System.ComponentModel.ISupportInitialize)(this.SkinColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HairColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShirtColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderShirtColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PantsColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoeColorDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.PictureBox SkinColorDisplay;
        private System.Windows.Forms.Label SkinColorLabel;
        private System.Windows.Forms.Label HairColorLabel;
        private System.Windows.Forms.PictureBox HairColorDisplay;
        private System.Windows.Forms.Label EyeColorLabel;
        private System.Windows.Forms.PictureBox EyeColorDisplay;
        private System.Windows.Forms.Label ShirtColorLabel;
        private System.Windows.Forms.PictureBox ShirtColorDisplay;
        private System.Windows.Forms.Label UnderShirtColorLabel;
        private System.Windows.Forms.PictureBox UnderShirtColorDisplay;
        private System.Windows.Forms.Label PantsColorLabel;
        private System.Windows.Forms.PictureBox PantsColorDisplay;
        private System.Windows.Forms.Label ShoeColorLabel;
        private System.Windows.Forms.PictureBox ShoeColorDisplay;
        private System.Windows.Forms.Button LoadCharacterButton;
        private System.Windows.Forms.OpenFileDialog FileChooser;
        private System.Windows.Forms.Button SaveCharacterButton;
        private System.Windows.Forms.TreeView Inventory;
        private System.Windows.Forms.ListBox PrefixList;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.NumericUpDown CountChooser;
        private System.Windows.Forms.Button SaveItemButton;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.ComboBox DifficultyBox;
        private System.Windows.Forms.Label DifficultyLabel;

    }
}

