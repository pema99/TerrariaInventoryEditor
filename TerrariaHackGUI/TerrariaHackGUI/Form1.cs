using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerrariaHack;

namespace TerrariaHackGUI
{
    public partial class TerrariaEditor : Form
    {
        Player player;
        string CurrentPath;
        int CurrentRelease = 156;

        public TerrariaEditor()
        {
            InitializeComponent();

            MessageBox.Show("Use this software at your own risk, I will not take responsibility for any damage done to anything whatsoever.\nSoftware by pema99 [http://pema99.net].");

            IDNameDictionary.Initialize();

            FileChooser.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\Terraria\Players\";

            player = new Player();

            Inventory.Nodes.Add("Inventory");
            Inventory.Nodes[0].Nodes.Add("HotBar");
            Inventory.Nodes[0].Nodes.Add("Main");
            Inventory.Nodes[0].Nodes.Add("Purse");
            Inventory.Nodes[0].Nodes.Add("Ammo");
            Inventory.Nodes.Add("Armor");
            Inventory.Nodes.Add("Dye");
            Inventory.Nodes.Add("Bank");
            Inventory.Nodes.Add("Safe");
            Inventory.Nodes.Add("MiscEquips");
            Inventory.Nodes.Add("MiscDye");

            foreach (var i in IDNameDictionary.Prefixes)
            {
                PrefixList.Items.Add(i.Value);
            }

            foreach (var i in IDNameDictionary.ItemNames)
            {
                if (i.Key >= 0)
                    ItemList.Items.Add(i.Value);
            }
        }

        public void PlayerLoaded()
        {
            #region Colors
            HairColorDisplay.BackColor = MakeSystemColor(player.HairColor);
            SkinColorDisplay.BackColor = MakeSystemColor(player.SkinColor);
            EyeColorDisplay.BackColor = MakeSystemColor(player.EyeColor);
            ShirtColorDisplay.BackColor = MakeSystemColor(player.ShirtColor);
            UnderShirtColorDisplay.BackColor = MakeSystemColor(player.UnderShirtColor);
            PantsColorDisplay.BackColor = MakeSystemColor(player.PantsColor);
            ShoeColorDisplay.BackColor = MakeSystemColor(player.ShoeColor);
            #endregion

            #region Inventory
            Inventory.Nodes[0].Nodes[0].Nodes.Clear();
            for (int i = 0; i < 10; i++)
            {
                TreeNode item = new TreeNode(player.Inventory[i].ToString());
                item.Tag = player.Inventory[i];
                Inventory.Nodes[0].Nodes[0].Nodes.Add(item);
            }

            Inventory.Nodes[0].Nodes[1].Nodes.Clear();
            for (int i = 10; i < 50; i++)
            {
                TreeNode item = new TreeNode(player.Inventory[i].ToString());
                item.Tag = player.Inventory[i];
                Inventory.Nodes[0].Nodes[1].Nodes.Add(item);
            }

            Inventory.Nodes[0].Nodes[2].Nodes.Clear();
            for (int i = 50; i < 54; i++)
            {
                TreeNode item = new TreeNode(player.Inventory[i].ToString());
                item.Tag = player.Inventory[i];
                Inventory.Nodes[0].Nodes[2].Nodes.Add(item);
            }

            Inventory.Nodes[0].Nodes[3].Nodes.Clear();
            for (int i = 54; i < 58; i++)
            {
                TreeNode item = new TreeNode(player.Inventory[i].ToString());
                item.Tag = player.Inventory[i];
                Inventory.Nodes[0].Nodes[3].Nodes.Add(item);
            }

            Inventory.Nodes[1].Nodes.Clear();
            foreach (Item i in player.Armor)
            {
                TreeNode item = new TreeNode(i.ToString());
                item.Tag = i;
                Inventory.Nodes[1].Nodes.Add(item);
            }

            Inventory.Nodes[2].Nodes.Clear();
            foreach (Item i in player.Dye)
            {
                TreeNode item = new TreeNode(i.ToString());
                item.Tag = i;
                Inventory.Nodes[2].Nodes.Add(item);
            }

            Inventory.Nodes[3].Nodes.Clear();
            foreach (Item i in player.Bank)
            {
                TreeNode item = new TreeNode(i.ToString());
                item.Tag = i;
                Inventory.Nodes[3].Nodes.Add(item);
            }

            Inventory.Nodes[4].Nodes.Clear();
            foreach (Item i in player.Safe)
            {
                TreeNode item = new TreeNode(i.ToString());
                item.Tag = i;
                Inventory.Nodes[4].Nodes.Add(item);
            }

            Inventory.Nodes[5].Nodes.Clear();
            foreach (Item i in player.MiscEquips)
            {
                TreeNode item = new TreeNode(i.ToString());
                item.Tag = i;
                Inventory.Nodes[5].Nodes.Add(item);
            }

            Inventory.Nodes[6].Nodes.Clear();
            foreach (Item i in player.MiscDye)
            {
                TreeNode item = new TreeNode(i.ToString());
                item.Tag = i;
                Inventory.Nodes[6].Nodes.Add(item);
            }
            #endregion

            ReleaseLabel.Text = "Release: " + player.Release;

            GenderBox.SelectedIndex = GenderBox.FindString(player.Gender.ToString());

            NameBox.Text = player.Name;

            DifficultyBox.SelectedIndex = DifficultyBox.FindString(player.Difficulty == 0 ? "Softcore" : player.Difficulty == 1 ? "Mediumcore" : "Hardcore");
        }

        #region ColorDisplays
        private void HairColorDisplay_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            HairColorDisplay.BackColor = ColorPicker.Color;
            player.HairColor = MakeOwnColor(ColorPicker.Color);
        }

        private void SkinColorDisplay_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            SkinColorDisplay.BackColor = ColorPicker.Color;
            player.SkinColor = MakeOwnColor(ColorPicker.Color);
        }

        private void EyeColorDisplay_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            EyeColorDisplay.BackColor = ColorPicker.Color;
            player.EyeColor = MakeOwnColor(ColorPicker.Color);
        }

        private void ShirtColorDisplay_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            SkinColorDisplay.BackColor = ColorPicker.Color;
            player.ShirtColor = MakeOwnColor(ColorPicker.Color);
        }

        private void UnderShirtColorDisplay_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            SkinColorDisplay.BackColor = ColorPicker.Color;
            player.UnderShirtColor = MakeOwnColor(ColorPicker.Color);
        }

        private void PantsColorDisplay_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            SkinColorDisplay.BackColor = ColorPicker.Color;
            player.PantsColor = MakeOwnColor(ColorPicker.Color);
        }

        private void ShoeColorDisplay_Click(object sender, EventArgs e)
        {
            ColorPicker.ShowDialog();
            SkinColorDisplay.BackColor = ColorPicker.Color;
            player.ShoeColor = MakeOwnColor(ColorPicker.Color);
        }
        #endregion

        private void LoadCharacterButton_Click(object sender, EventArgs e)
        {
            if (FileChooser.ShowDialog() == DialogResult.OK)
            {
                player.FromFile(FileChooser.FileName);
                CurrentPath = FileChooser.FileName;
                PlayerLoaded();
            }
        }

        public TerrariaHack.Color MakeOwnColor(System.Drawing.Color Other)
        {
            return new TerrariaHack.Color { R = Other.R, G = Other.G, B = Other.G };
        }

        public System.Drawing.Color MakeSystemColor(TerrariaHack.Color Other)
        {
            return System.Drawing.Color.FromArgb(Other.R, Other.G, Other.B);
        }

        private void SaveCharacterButton_Click(object sender, EventArgs e)
        {
            if (CurrentPath != null)
            {
                #region Inventory
                for (int i = 0; i < 10; i++)
                {
                    player.Inventory[i] = Inventory.Nodes[0].Nodes[0].Nodes[i].Tag as Item;
                }
                for (int i = 0; i < 40; i++)
                {
                    player.Inventory[i + 10] = Inventory.Nodes[0].Nodes[1].Nodes[i].Tag as Item;
                }
                for (int i = 0; i < 4; i++)
                {
                    player.Inventory[i + 50] = Inventory.Nodes[0].Nodes[2].Nodes[i].Tag as Item;
                }
                for (int i = 0; i < 4; i++)
                {
                    player.Inventory[i + 54] = Inventory.Nodes[0].Nodes[3].Nodes[i].Tag as Item;
                }

                for (int i = 0; i < 20; i++)
                {
                    player.Armor[i] = Inventory.Nodes[1].Nodes[i].Tag as Item;
                }

                for (int i = 0; i < 10; i++)
                {
                    player.Dye[i] = Inventory.Nodes[2].Nodes[i].Tag as Item;
                }

                for (int i = 0; i < 40; i++)
                {
                    player.Bank[i] = Inventory.Nodes[3].Nodes[i].Tag as Item;
                }

                for (int i = 0; i < 40; i++)
                {
                    player.Safe[i] = Inventory.Nodes[4].Nodes[i].Tag as Item;
                }

                for (int i = 0; i < 5; i++)
                {
                    player.MiscEquips[i] = Inventory.Nodes[5].Nodes[i].Tag as Item;
                }

                for (int i = 0; i < 5; i++)
                {
                    player.MiscDye[i] = Inventory.Nodes[6].Nodes[i].Tag as Item;
                }
                #endregion

                player.Name = NameBox.Text;

                player.Gender = (Genders)Enum.Parse(typeof(Genders), GenderBox.Items[GenderBox.SelectedIndex].ToString());

                player.Difficulty = (byte)DifficultyBox.SelectedIndex;

                player.Release = CurrentRelease;

                player.ToFile(CurrentPath);
            }
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (CurrentPath != null)
                if (Inventory.SelectedNode.Text != "Inventory"
                 && Inventory.SelectedNode.Text != "HotBar"
                 && Inventory.SelectedNode.Text != "Main"
                 && Inventory.SelectedNode.Text != "Purse"
                 && Inventory.SelectedNode.Text != "Ammo"
                 && Inventory.SelectedNode.Text != "Armor"
                 && Inventory.SelectedNode.Text != "Dye"
                 && Inventory.SelectedNode.Text != "Bank"
                 && Inventory.SelectedNode.Text != "Safe"
                 && Inventory.SelectedNode.Text != "MiscEquips"
                 && Inventory.SelectedNode.Text != "MiscDye"
                 && Inventory.SelectedNode.Tag != null)
                {
                    Inventory.SelectedNode.Tag =
                        new Item
                        {
                            ID = IDNameDictionary.ItemNames.First(x => x.Value == ItemList.SelectedItem.ToString()).Key,
                            Count = (int)CountChooser.Value,
                            Prefix = (byte)(IDNameDictionary.Prefixes.First(x => x.Value == PrefixList.SelectedItem.ToString()).Key)
                        };
                    Inventory.SelectedNode.Text = Inventory.SelectedNode.Tag.ToString();
                }
        }
    }
}
