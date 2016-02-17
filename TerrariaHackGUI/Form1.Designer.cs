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
            this.LifeBox = new System.Windows.Forms.NumericUpDown();
            this.MaxLifeBox = new System.Windows.Forms.NumericUpDown();
            this.ManaBox = new System.Windows.Forms.NumericUpDown();
            this.MaxManaBox = new System.Windows.Forms.NumericUpDown();
            this.ItemsGroup = new System.Windows.Forms.GroupBox();
            this.ColorsGroup = new System.Windows.Forms.GroupBox();
            this.StatsGroup = new System.Windows.Forms.GroupBox();
            this.MaxManaLabel = new System.Windows.Forms.Label();
            this.ManaLabel = new System.Windows.Forms.Label();
            this.MaxLifeLabel = new System.Windows.Forms.Label();
            this.LifeLabel = new System.Windows.Forms.Label();
            this.HairGroup = new System.Windows.Forms.GroupBox();
            this.HairDyeLabel = new System.Windows.Forms.Label();
            this.HairStyleLabel = new System.Windows.Forms.Label();
            this.HairDyeBox = new System.Windows.Forms.ComboBox();
            this.HairStyleBox = new System.Windows.Forms.NumericUpDown();
            this.ExtraAccessoryBox = new System.Windows.Forms.CheckBox();
            this.AnglerQuestsBox = new System.Windows.Forms.NumericUpDown();
            this.TaxMoneyBox = new System.Windows.Forms.NumericUpDown();
            this.AnglerQuestsLabel = new System.Windows.Forms.Label();
            this.TaxMoneyLabel = new System.Windows.Forms.Label();
            this.BuffsGroup = new System.Windows.Forms.GroupBox();
            this.BuffBox = new System.Windows.Forms.TreeView();
            this.BuffList = new System.Windows.Forms.ListBox();
            this.BuffTimeChooser = new System.Windows.Forms.NumericUpDown();
            this.BuffSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SkinColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HairColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyeColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShirtColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderShirtColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PantsColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShoeColorDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLifeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxManaBox)).BeginInit();
            this.ItemsGroup.SuspendLayout();
            this.ColorsGroup.SuspendLayout();
            this.StatsGroup.SuspendLayout();
            this.HairGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HairStyleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglerQuestsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxMoneyBox)).BeginInit();
            this.BuffsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuffTimeChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorPicker
            // 
            this.ColorPicker.SolidColorOnly = true;
            // 
            // SkinColorDisplay
            // 
            this.SkinColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SkinColorDisplay.Location = new System.Drawing.Point(117, 34);
            this.SkinColorDisplay.Name = "SkinColorDisplay";
            this.SkinColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.SkinColorDisplay.TabIndex = 0;
            this.SkinColorDisplay.TabStop = false;
            this.SkinColorDisplay.Click += new System.EventHandler(this.SkinColorDisplay_Click);
            // 
            // SkinColorLabel
            // 
            this.SkinColorLabel.AutoSize = true;
            this.SkinColorLabel.Location = new System.Drawing.Point(114, 18);
            this.SkinColorLabel.Name = "SkinColorLabel";
            this.SkinColorLabel.Size = new System.Drawing.Size(55, 13);
            this.SkinColorLabel.TabIndex = 1;
            this.SkinColorLabel.Text = "Skin Color";
            // 
            // HairColorLabel
            // 
            this.HairColorLabel.AutoSize = true;
            this.HairColorLabel.Location = new System.Drawing.Point(8, 18);
            this.HairColorLabel.Name = "HairColorLabel";
            this.HairColorLabel.Size = new System.Drawing.Size(53, 13);
            this.HairColorLabel.TabIndex = 3;
            this.HairColorLabel.Text = "Hair Color";
            // 
            // HairColorDisplay
            // 
            this.HairColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HairColorDisplay.Location = new System.Drawing.Point(11, 34);
            this.HairColorDisplay.Name = "HairColorDisplay";
            this.HairColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.HairColorDisplay.TabIndex = 2;
            this.HairColorDisplay.TabStop = false;
            this.HairColorDisplay.Click += new System.EventHandler(this.HairColorDisplay_Click);
            // 
            // EyeColorLabel
            // 
            this.EyeColorLabel.AutoSize = true;
            this.EyeColorLabel.Location = new System.Drawing.Point(8, 74);
            this.EyeColorLabel.Name = "EyeColorLabel";
            this.EyeColorLabel.Size = new System.Drawing.Size(52, 13);
            this.EyeColorLabel.TabIndex = 5;
            this.EyeColorLabel.Text = "Eye Color";
            // 
            // EyeColorDisplay
            // 
            this.EyeColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyeColorDisplay.Location = new System.Drawing.Point(11, 90);
            this.EyeColorDisplay.Name = "EyeColorDisplay";
            this.EyeColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.EyeColorDisplay.TabIndex = 4;
            this.EyeColorDisplay.TabStop = false;
            this.EyeColorDisplay.Click += new System.EventHandler(this.EyeColorDisplay_Click);
            // 
            // ShirtColorLabel
            // 
            this.ShirtColorLabel.AutoSize = true;
            this.ShirtColorLabel.Location = new System.Drawing.Point(114, 74);
            this.ShirtColorLabel.Name = "ShirtColorLabel";
            this.ShirtColorLabel.Size = new System.Drawing.Size(55, 13);
            this.ShirtColorLabel.TabIndex = 7;
            this.ShirtColorLabel.Text = "Shirt Color";
            // 
            // ShirtColorDisplay
            // 
            this.ShirtColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShirtColorDisplay.Location = new System.Drawing.Point(117, 90);
            this.ShirtColorDisplay.Name = "ShirtColorDisplay";
            this.ShirtColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.ShirtColorDisplay.TabIndex = 6;
            this.ShirtColorDisplay.TabStop = false;
            this.ShirtColorDisplay.Click += new System.EventHandler(this.ShirtColorDisplay_Click);
            // 
            // UnderShirtColorLabel
            // 
            this.UnderShirtColorLabel.AutoSize = true;
            this.UnderShirtColorLabel.Location = new System.Drawing.Point(8, 130);
            this.UnderShirtColorLabel.Name = "UnderShirtColorLabel";
            this.UnderShirtColorLabel.Size = new System.Drawing.Size(82, 13);
            this.UnderShirtColorLabel.TabIndex = 9;
            this.UnderShirtColorLabel.Text = "Undershirt Color";
            // 
            // UnderShirtColorDisplay
            // 
            this.UnderShirtColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnderShirtColorDisplay.Location = new System.Drawing.Point(11, 146);
            this.UnderShirtColorDisplay.Name = "UnderShirtColorDisplay";
            this.UnderShirtColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.UnderShirtColorDisplay.TabIndex = 8;
            this.UnderShirtColorDisplay.TabStop = false;
            this.UnderShirtColorDisplay.Click += new System.EventHandler(this.UnderShirtColorDisplay_Click);
            // 
            // PantsColorLabel
            // 
            this.PantsColorLabel.AutoSize = true;
            this.PantsColorLabel.Location = new System.Drawing.Point(114, 130);
            this.PantsColorLabel.Name = "PantsColorLabel";
            this.PantsColorLabel.Size = new System.Drawing.Size(61, 13);
            this.PantsColorLabel.TabIndex = 11;
            this.PantsColorLabel.Text = "Pants Color";
            // 
            // PantsColorDisplay
            // 
            this.PantsColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PantsColorDisplay.Location = new System.Drawing.Point(117, 146);
            this.PantsColorDisplay.Name = "PantsColorDisplay";
            this.PantsColorDisplay.Size = new System.Drawing.Size(100, 34);
            this.PantsColorDisplay.TabIndex = 10;
            this.PantsColorDisplay.TabStop = false;
            this.PantsColorDisplay.Click += new System.EventHandler(this.PantsColorDisplay_Click);
            // 
            // ShoeColorLabel
            // 
            this.ShoeColorLabel.AutoSize = true;
            this.ShoeColorLabel.Location = new System.Drawing.Point(114, 186);
            this.ShoeColorLabel.Name = "ShoeColorLabel";
            this.ShoeColorLabel.Size = new System.Drawing.Size(59, 13);
            this.ShoeColorLabel.TabIndex = 13;
            this.ShoeColorLabel.Text = "Shoe Color";
            // 
            // ShoeColorDisplay
            // 
            this.ShoeColorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShoeColorDisplay.Location = new System.Drawing.Point(117, 202);
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
            this.Inventory.Location = new System.Drawing.Point(6, 19);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(241, 475);
            this.Inventory.TabIndex = 16;
            // 
            // PrefixList
            // 
            this.PrefixList.FormattingEnabled = true;
            this.PrefixList.Location = new System.Drawing.Point(261, 19);
            this.PrefixList.Name = "PrefixList";
            this.PrefixList.Size = new System.Drawing.Size(120, 134);
            this.PrefixList.TabIndex = 17;
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(261, 159);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(120, 277);
            this.ItemList.TabIndex = 18;
            // 
            // CountChooser
            // 
            this.CountChooser.Location = new System.Drawing.Point(261, 445);
            this.CountChooser.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.CountChooser.Name = "CountChooser";
            this.CountChooser.Size = new System.Drawing.Size(120, 20);
            this.CountChooser.TabIndex = 19;
            // 
            // SaveItemButton
            // 
            this.SaveItemButton.Location = new System.Drawing.Point(261, 471);
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
            this.NameBox.Location = new System.Drawing.Point(263, 12);
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
            this.GenderBox.Location = new System.Drawing.Point(263, 43);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(100, 21);
            this.GenderBox.TabIndex = 24;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(212, 46);
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
            this.DifficultyBox.Location = new System.Drawing.Point(435, 12);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(100, 21);
            this.DifficultyBox.TabIndex = 26;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(379, 15);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(50, 13);
            this.DifficultyLabel.TabIndex = 27;
            this.DifficultyLabel.Text = "Difficulty:";
            // 
            // LifeBox
            // 
            this.LifeBox.Location = new System.Drawing.Point(88, 19);
            this.LifeBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.LifeBox.Name = "LifeBox";
            this.LifeBox.Size = new System.Drawing.Size(120, 20);
            this.LifeBox.TabIndex = 28;
            // 
            // MaxLifeBox
            // 
            this.MaxLifeBox.Location = new System.Drawing.Point(88, 45);
            this.MaxLifeBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.MaxLifeBox.Name = "MaxLifeBox";
            this.MaxLifeBox.Size = new System.Drawing.Size(120, 20);
            this.MaxLifeBox.TabIndex = 29;
            // 
            // ManaBox
            // 
            this.ManaBox.Location = new System.Drawing.Point(88, 88);
            this.ManaBox.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.ManaBox.Name = "ManaBox";
            this.ManaBox.Size = new System.Drawing.Size(120, 20);
            this.ManaBox.TabIndex = 30;
            // 
            // MaxManaBox
            // 
            this.MaxManaBox.Location = new System.Drawing.Point(88, 114);
            this.MaxManaBox.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.MaxManaBox.Name = "MaxManaBox";
            this.MaxManaBox.Size = new System.Drawing.Size(120, 20);
            this.MaxManaBox.TabIndex = 31;
            // 
            // ItemsGroup
            // 
            this.ItemsGroup.Controls.Add(this.Inventory);
            this.ItemsGroup.Controls.Add(this.PrefixList);
            this.ItemsGroup.Controls.Add(this.ItemList);
            this.ItemsGroup.Controls.Add(this.CountChooser);
            this.ItemsGroup.Controls.Add(this.SaveItemButton);
            this.ItemsGroup.Location = new System.Drawing.Point(12, 70);
            this.ItemsGroup.Name = "ItemsGroup";
            this.ItemsGroup.Size = new System.Drawing.Size(387, 500);
            this.ItemsGroup.TabIndex = 32;
            this.ItemsGroup.TabStop = false;
            this.ItemsGroup.Text = "Items";
            // 
            // ColorsGroup
            // 
            this.ColorsGroup.Controls.Add(this.SkinColorDisplay);
            this.ColorsGroup.Controls.Add(this.SkinColorLabel);
            this.ColorsGroup.Controls.Add(this.HairColorDisplay);
            this.ColorsGroup.Controls.Add(this.HairColorLabel);
            this.ColorsGroup.Controls.Add(this.EyeColorDisplay);
            this.ColorsGroup.Controls.Add(this.EyeColorLabel);
            this.ColorsGroup.Controls.Add(this.ShirtColorDisplay);
            this.ColorsGroup.Controls.Add(this.ShirtColorLabel);
            this.ColorsGroup.Controls.Add(this.UnderShirtColorDisplay);
            this.ColorsGroup.Controls.Add(this.UnderShirtColorLabel);
            this.ColorsGroup.Controls.Add(this.PantsColorDisplay);
            this.ColorsGroup.Controls.Add(this.PantsColorLabel);
            this.ColorsGroup.Controls.Add(this.ShoeColorDisplay);
            this.ColorsGroup.Controls.Add(this.ShoeColorLabel);
            this.ColorsGroup.Location = new System.Drawing.Point(405, 219);
            this.ColorsGroup.Name = "ColorsGroup";
            this.ColorsGroup.Size = new System.Drawing.Size(228, 246);
            this.ColorsGroup.TabIndex = 0;
            this.ColorsGroup.TabStop = false;
            this.ColorsGroup.Text = "Colors";
            // 
            // StatsGroup
            // 
            this.StatsGroup.Controls.Add(this.MaxManaLabel);
            this.StatsGroup.Controls.Add(this.ManaLabel);
            this.StatsGroup.Controls.Add(this.MaxLifeLabel);
            this.StatsGroup.Controls.Add(this.LifeLabel);
            this.StatsGroup.Controls.Add(this.MaxLifeBox);
            this.StatsGroup.Controls.Add(this.LifeBox);
            this.StatsGroup.Controls.Add(this.ManaBox);
            this.StatsGroup.Controls.Add(this.MaxManaBox);
            this.StatsGroup.Location = new System.Drawing.Point(410, 70);
            this.StatsGroup.Name = "StatsGroup";
            this.StatsGroup.Size = new System.Drawing.Size(217, 143);
            this.StatsGroup.TabIndex = 33;
            this.StatsGroup.TabStop = false;
            this.StatsGroup.Text = "Stats";
            // 
            // MaxManaLabel
            // 
            this.MaxManaLabel.AutoSize = true;
            this.MaxManaLabel.Location = new System.Drawing.Point(8, 116);
            this.MaxManaLabel.Name = "MaxManaLabel";
            this.MaxManaLabel.Size = new System.Drawing.Size(60, 13);
            this.MaxManaLabel.TabIndex = 35;
            this.MaxManaLabel.Text = "Max Mana:";
            // 
            // ManaLabel
            // 
            this.ManaLabel.AutoSize = true;
            this.ManaLabel.Location = new System.Drawing.Point(8, 90);
            this.ManaLabel.Name = "ManaLabel";
            this.ManaLabel.Size = new System.Drawing.Size(74, 13);
            this.ManaLabel.TabIndex = 34;
            this.ManaLabel.Text = "Current Mana:";
            // 
            // MaxLifeLabel
            // 
            this.MaxLifeLabel.AutoSize = true;
            this.MaxLifeLabel.Location = new System.Drawing.Point(8, 47);
            this.MaxLifeLabel.Name = "MaxLifeLabel";
            this.MaxLifeLabel.Size = new System.Drawing.Size(50, 13);
            this.MaxLifeLabel.TabIndex = 33;
            this.MaxLifeLabel.Text = "Max Life:";
            // 
            // LifeLabel
            // 
            this.LifeLabel.AutoSize = true;
            this.LifeLabel.Location = new System.Drawing.Point(8, 21);
            this.LifeLabel.Name = "LifeLabel";
            this.LifeLabel.Size = new System.Drawing.Size(64, 13);
            this.LifeLabel.TabIndex = 32;
            this.LifeLabel.Text = "Current Life:";
            // 
            // HairGroup
            // 
            this.HairGroup.Controls.Add(this.HairDyeLabel);
            this.HairGroup.Controls.Add(this.HairStyleLabel);
            this.HairGroup.Controls.Add(this.HairDyeBox);
            this.HairGroup.Controls.Add(this.HairStyleBox);
            this.HairGroup.Location = new System.Drawing.Point(405, 471);
            this.HairGroup.Name = "HairGroup";
            this.HairGroup.Size = new System.Drawing.Size(228, 74);
            this.HairGroup.TabIndex = 34;
            this.HairGroup.TabStop = false;
            this.HairGroup.Text = "Hair";
            // 
            // HairDyeLabel
            // 
            this.HairDyeLabel.AutoSize = true;
            this.HairDyeLabel.Location = new System.Drawing.Point(8, 45);
            this.HairDyeLabel.Name = "HairDyeLabel";
            this.HairDyeLabel.Size = new System.Drawing.Size(51, 13);
            this.HairDyeLabel.TabIndex = 3;
            this.HairDyeLabel.Text = "Hair Dye:";
            // 
            // HairStyleLabel
            // 
            this.HairStyleLabel.AutoSize = true;
            this.HairStyleLabel.Location = new System.Drawing.Point(8, 17);
            this.HairStyleLabel.Name = "HairStyleLabel";
            this.HairStyleLabel.Size = new System.Drawing.Size(55, 13);
            this.HairStyleLabel.TabIndex = 2;
            this.HairStyleLabel.Text = "Hair Style:";
            // 
            // HairDyeBox
            // 
            this.HairDyeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HairDyeBox.FormattingEnabled = true;
            this.HairDyeBox.Items.AddRange(new object[] {
            "No Hair Dye",
            "Life Hair Dye",
            "Mana Hair Dye",
            "Depth Hair Dye",
            "Money Hair Dye",
            "Time Hair Dye",
            "Team Hair Dye",
            "Biome Hair Dye",
            "Party Hair Dye",
            "Rainbow Hair Dye",
            "Speed Hair Dye",
            "Martian Hair Dye",
            "Twilight Hair Dye"});
            this.HairDyeBox.Location = new System.Drawing.Point(69, 42);
            this.HairDyeBox.Name = "HairDyeBox";
            this.HairDyeBox.Size = new System.Drawing.Size(153, 21);
            this.HairDyeBox.TabIndex = 1;
            // 
            // HairStyleBox
            // 
            this.HairStyleBox.Location = new System.Drawing.Point(69, 15);
            this.HairStyleBox.Maximum = new decimal(new int[] {
            133,
            0,
            0,
            0});
            this.HairStyleBox.Name = "HairStyleBox";
            this.HairStyleBox.Size = new System.Drawing.Size(153, 20);
            this.HairStyleBox.TabIndex = 0;
            // 
            // ExtraAccessoryBox
            // 
            this.ExtraAccessoryBox.AutoSize = true;
            this.ExtraAccessoryBox.Location = new System.Drawing.Point(382, 45);
            this.ExtraAccessoryBox.Name = "ExtraAccessoryBox";
            this.ExtraAccessoryBox.Size = new System.Drawing.Size(102, 17);
            this.ExtraAccessoryBox.TabIndex = 36;
            this.ExtraAccessoryBox.Text = "Extra Accessory";
            this.ExtraAccessoryBox.UseVisualStyleBackColor = true;
            // 
            // AnglerQuestsBox
            // 
            this.AnglerQuestsBox.Location = new System.Drawing.Point(635, 13);
            this.AnglerQuestsBox.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.AnglerQuestsBox.Name = "AnglerQuestsBox";
            this.AnglerQuestsBox.Size = new System.Drawing.Size(120, 20);
            this.AnglerQuestsBox.TabIndex = 37;
            // 
            // TaxMoneyBox
            // 
            this.TaxMoneyBox.Location = new System.Drawing.Point(635, 44);
            this.TaxMoneyBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TaxMoneyBox.Name = "TaxMoneyBox";
            this.TaxMoneyBox.Size = new System.Drawing.Size(120, 20);
            this.TaxMoneyBox.TabIndex = 38;
            // 
            // AnglerQuestsLabel
            // 
            this.AnglerQuestsLabel.AutoSize = true;
            this.AnglerQuestsLabel.Location = new System.Drawing.Point(555, 15);
            this.AnglerQuestsLabel.Name = "AnglerQuestsLabel";
            this.AnglerQuestsLabel.Size = new System.Drawing.Size(76, 13);
            this.AnglerQuestsLabel.TabIndex = 39;
            this.AnglerQuestsLabel.Text = "Angler Quests:";
            // 
            // TaxMoneyLabel
            // 
            this.TaxMoneyLabel.AutoSize = true;
            this.TaxMoneyLabel.Location = new System.Drawing.Point(555, 46);
            this.TaxMoneyLabel.Name = "TaxMoneyLabel";
            this.TaxMoneyLabel.Size = new System.Drawing.Size(63, 13);
            this.TaxMoneyLabel.TabIndex = 40;
            this.TaxMoneyLabel.Text = "Tax Money:";
            // 
            // BuffsGroup
            // 
            this.BuffsGroup.Controls.Add(this.BuffSaveButton);
            this.BuffsGroup.Controls.Add(this.BuffTimeChooser);
            this.BuffsGroup.Controls.Add(this.BuffList);
            this.BuffsGroup.Controls.Add(this.BuffBox);
            this.BuffsGroup.Location = new System.Drawing.Point(635, 70);
            this.BuffsGroup.Name = "BuffsGroup";
            this.BuffsGroup.Size = new System.Drawing.Size(231, 500);
            this.BuffsGroup.TabIndex = 41;
            this.BuffsGroup.TabStop = false;
            this.BuffsGroup.Text = "Buffs";
            // 
            // BuffBox
            // 
            this.BuffBox.Location = new System.Drawing.Point(6, 19);
            this.BuffBox.Name = "BuffBox";
            this.BuffBox.Size = new System.Drawing.Size(219, 198);
            this.BuffBox.TabIndex = 0;
            // 
            // BuffList
            // 
            this.BuffList.FormattingEnabled = true;
            this.BuffList.Location = new System.Drawing.Point(6, 223);
            this.BuffList.Name = "BuffList";
            this.BuffList.Size = new System.Drawing.Size(219, 212);
            this.BuffList.TabIndex = 1;
            // 
            // BuffTimeChooser
            // 
            this.BuffTimeChooser.Location = new System.Drawing.Point(6, 446);
            this.BuffTimeChooser.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.BuffTimeChooser.Name = "BuffTimeChooser";
            this.BuffTimeChooser.Size = new System.Drawing.Size(219, 20);
            this.BuffTimeChooser.TabIndex = 2;
            // 
            // BuffSaveButton
            // 
            this.BuffSaveButton.Location = new System.Drawing.Point(6, 471);
            this.BuffSaveButton.Name = "BuffSaveButton";
            this.BuffSaveButton.Size = new System.Drawing.Size(219, 23);
            this.BuffSaveButton.TabIndex = 3;
            this.BuffSaveButton.Text = "Save Buff";
            this.BuffSaveButton.UseVisualStyleBackColor = true;
            this.BuffSaveButton.Click += new System.EventHandler(this.BuffSaveButton_Click);
            // 
            // TerrariaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 582);
            this.Controls.Add(this.BuffsGroup);
            this.Controls.Add(this.TaxMoneyLabel);
            this.Controls.Add(this.AnglerQuestsLabel);
            this.Controls.Add(this.TaxMoneyBox);
            this.Controls.Add(this.AnglerQuestsBox);
            this.Controls.Add(this.ExtraAccessoryBox);
            this.Controls.Add(this.HairGroup);
            this.Controls.Add(this.StatsGroup);
            this.Controls.Add(this.ColorsGroup);
            this.Controls.Add(this.ItemsGroup);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.ReleaseLabel);
            this.Controls.Add(this.SaveCharacterButton);
            this.Controls.Add(this.LoadCharacterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)(this.LifeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLifeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxManaBox)).EndInit();
            this.ItemsGroup.ResumeLayout(false);
            this.ColorsGroup.ResumeLayout(false);
            this.ColorsGroup.PerformLayout();
            this.StatsGroup.ResumeLayout(false);
            this.StatsGroup.PerformLayout();
            this.HairGroup.ResumeLayout(false);
            this.HairGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HairStyleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnglerQuestsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaxMoneyBox)).EndInit();
            this.BuffsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuffTimeChooser)).EndInit();
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
        private System.Windows.Forms.NumericUpDown LifeBox;
        private System.Windows.Forms.NumericUpDown MaxLifeBox;
        private System.Windows.Forms.NumericUpDown ManaBox;
        private System.Windows.Forms.NumericUpDown MaxManaBox;
        private System.Windows.Forms.GroupBox ItemsGroup;
        private System.Windows.Forms.GroupBox ColorsGroup;
        private System.Windows.Forms.GroupBox StatsGroup;
        private System.Windows.Forms.Label MaxManaLabel;
        private System.Windows.Forms.Label ManaLabel;
        private System.Windows.Forms.Label MaxLifeLabel;
        private System.Windows.Forms.Label LifeLabel;
        private System.Windows.Forms.GroupBox HairGroup;
        private System.Windows.Forms.Label HairDyeLabel;
        private System.Windows.Forms.Label HairStyleLabel;
        private System.Windows.Forms.ComboBox HairDyeBox;
        private System.Windows.Forms.NumericUpDown HairStyleBox;
        private System.Windows.Forms.CheckBox ExtraAccessoryBox;
        private System.Windows.Forms.NumericUpDown AnglerQuestsBox;
        private System.Windows.Forms.NumericUpDown TaxMoneyBox;
        private System.Windows.Forms.Label AnglerQuestsLabel;
        private System.Windows.Forms.Label TaxMoneyLabel;
        private System.Windows.Forms.GroupBox BuffsGroup;
        private System.Windows.Forms.Button BuffSaveButton;
        private System.Windows.Forms.NumericUpDown BuffTimeChooser;
        private System.Windows.Forms.ListBox BuffList;
        private System.Windows.Forms.TreeView BuffBox;

    }
}

