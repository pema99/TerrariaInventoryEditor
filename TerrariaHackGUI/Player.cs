using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TerrariaHack
{
    public class Player
    {
        public int Release { get; set; }
        public string Name { get; set; }
        public byte Difficulty { get; set; }
        public int Hair { get; set; }
        public byte HairDye { get; set; }
        public Genders Gender
        {
            get { return this.SkinVariant < 4 ? Genders.Male : Genders.Female; }
            set
            {
                if (value == Genders.Male)
                {
                    if (this.SkinVariant >= 4)
                    {
                        this.SkinVariant -= 4;
                        return;
                    }
                }
                else if (this.SkinVariant < 4)
                {
                    this.SkinVariant += 4;
                }
            }
        }
        public int SkinVariant { get; set; }
        public int Life { get; set; }
        public int MaxLife { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public Color HairColor { get; set; }
        public Color SkinColor { get; set; }
        public Color EyeColor { get; set; }
        public Color ShirtColor { get; set; }
        public Color UnderShirtColor { get; set; }
        public Color PantsColor { get; set; }
        public Color ShoeColor { get; set; }
        public Item[] Armor { get; set; }
        public Item[] Dye { get; set; }
        public Item[] Inventory { get; set; }
        public Item[] Bank { get; set; }
        public Item[] Safe { get; set; }
        public Buff[] Buffs { get; set; }
        public int AnglerQuestsFinished { get; set; }
        public bool ExtraAccessory { get; set; }
        public int TaxMoney { get; set; }
        public Item[] MiscEquips { get; set; }
        public Item[] MiscDye { get; set; }
        public TimeSpan PlayTime { get; set; }
        public bool[] HideInfo { get; set; }
        public bool IsFavorite { get; set; }
        public UInt32 Revision { get; set; }
        public bool[] HideVisual { get; set; }
        public byte HideMisc { get; set; }

        public int[] SpX { get; set; }
        public int[] SpY { get; set; }
        public int[] SpI { get; set; }
        public string[] SpN { get; set; }
        public bool HotBarLocked { get; set; }

        public Player()
        {
            Armor = new Item[20];
            for (int i = 0; i < 20; i++)
                Armor[i] = new Item { ID = 0, Count = 0, Prefix = 0 };

            Dye = new Item[10];
            for (int i = 0; i < 10; i++)
                Dye[i] = new Item { ID = 0, Count = 0, Prefix = 0 };

            Inventory = new Item[58];
            for (int i = 0; i < 58; i++)
                Inventory[i] = new Item { ID = 0, Count = 0, Prefix = 0 };

            Bank = new Item[40];
            for (int i = 0; i < 40; i++)
                Bank[i] = new Item { ID = 0, Count = 0, Prefix = 0 };

            Safe = new Item[40];
            for (int i = 0; i < 40; i++)
                Safe[i] = new Item { ID = 0, Count = 0, Prefix = 0 };

            MiscEquips = new Item[5];
            for (int i = 0; i < 5; i++)
                MiscEquips[i] = new Item { ID = 0, Count = 0, Prefix = 0 };

            MiscDye = new Item[5];
            for (int i = 0; i < 5; i++)
                MiscDye[i] = new Item { ID = 0, Count = 0, Prefix = 0 };

            Buffs = new Buff[22];
            for (int i = 0; i < 22; i++)
                Buffs[i] = new Buff { BuffTime = 0, BuffType = 0 };

            Gender = Genders.Male;

            HairColor = new Color { R = 0, G = 0, B = 0 };
            SkinColor = new Color { R = 0, G = 0, B = 0 };
            EyeColor = new Color { R = 0, G = 0, B = 0 };
            ShirtColor = new Color { R = 0, G = 0, B = 0 };
            UnderShirtColor = new Color { R = 0, G = 0, B = 0 };
            PantsColor = new Color { R = 0, G = 0, B = 0 };
            ShoeColor = new Color { R = 0, G = 0, B = 0 };

            SpX = new int[200];
            SpY = new int[200];
            SpI = new int[200];
            SpN = new string[200];

            PlayTime = new TimeSpan();

            HideInfo = new bool[13];
            HideVisual = new bool[10];
        }

        public void FromFileAlt(string PlayerPath)
        {
            RijndaelManaged Rijndael = new RijndaelManaged();
            Rijndael.Padding = PaddingMode.None;
            byte[] DataBuffer = File.ReadAllBytes(PlayerPath);

            using (MemoryStream MemStream = new MemoryStream(DataBuffer))
            {
                using (CryptoStream DecryptStream = new CryptoStream(MemStream, Rijndael.CreateDecryptor(new UnicodeEncoding().GetBytes("h3y_gUyZ"), new UnicodeEncoding().GetBytes("h3y_gUyZ")), CryptoStreamMode.Read))
                {
                    using (BinaryReader Reader = new BinaryReader(DecryptStream))
                    {
                        Release = Reader.ReadInt32();

                        //Validity check
                        Reader.ReadUInt64();

                        Revision = Reader.ReadUInt32();

                        IsFavorite = ((Reader.ReadUInt64() & 1uL) == 1uL);

                        Name = Reader.ReadString();

                        Difficulty = Reader.ReadByte();

                        PlayTime = new TimeSpan(Reader.ReadInt64());

                        Hair = Reader.ReadInt32();
                        HairDye = Reader.ReadByte();

                        //HideVisual
                        byte BitsByte = Reader.ReadByte();
                        for (int i = 0; i < 8; i++)
                            HideVisual[i] = BitsByte.GetBit(i);
                        BitsByte = Reader.ReadByte();
                        for (int j = 0; j < 2; j++)
                            HideVisual[j + 8] = BitsByte.GetBit(j);

                        //HideMisc
                        HideMisc = Reader.ReadByte();

                        SkinVariant = Reader.ReadByte();

                        Life = Reader.ReadInt32();
                        MaxLife = Reader.ReadInt32();

                        Mana = Reader.ReadInt32();
                        MaxMana = Reader.ReadInt32();

                        ExtraAccessory = Reader.ReadBoolean();

                        TaxMoney = Reader.ReadInt32();

                        HairColor.R = Reader.ReadByte();
                        HairColor.G = Reader.ReadByte();
                        HairColor.B = Reader.ReadByte();

                        SkinColor.R = Reader.ReadByte();
                        SkinColor.G = Reader.ReadByte();
                        SkinColor.B = Reader.ReadByte();

                        EyeColor.R = Reader.ReadByte();
                        EyeColor.G = Reader.ReadByte();
                        EyeColor.B = Reader.ReadByte();

                        ShirtColor.R = Reader.ReadByte();
                        ShirtColor.G = Reader.ReadByte();
                        ShirtColor.B = Reader.ReadByte();

                        UnderShirtColor.R = Reader.ReadByte();
                        UnderShirtColor.G = Reader.ReadByte();
                        UnderShirtColor.B = Reader.ReadByte();

                        PantsColor.R = Reader.ReadByte();
                        PantsColor.G = Reader.ReadByte();
                        PantsColor.B = Reader.ReadByte();

                        ShoeColor.R = Reader.ReadByte();
                        ShoeColor.G = Reader.ReadByte();
                        ShoeColor.B = Reader.ReadByte();

                        for (int k = 0; k < Armor.Length; k++)
                        {
                            Armor[k].ID = Reader.ReadInt32();
                            Armor[k].Count = 1;
                            Armor[k].Prefix = Reader.ReadByte();
                        }

                        for (int l = 0; l < Dye.Length; l++)
                        {
                            Dye[l].ID = Reader.ReadInt32();
                            Dye[l].Count = 1;
                            Dye[l].Prefix = Reader.ReadByte();
                        }

                        for (int m = 0; m < 58; m++)
                        {
                            Inventory[m].ID = Reader.ReadInt32();
                            Inventory[m].Count = Reader.ReadInt32();
                            Inventory[m].Prefix = Reader.ReadByte();

                            //Favorited
                            Reader.ReadBoolean();
                        }

                        for (int n = 0; n < MiscEquips.Length; n++)
                        {
                            MiscEquips[n].ID = Reader.ReadInt32();
                            MiscEquips[n].Prefix = Reader.ReadByte();
                            MiscEquips[n].Count = 1;
                            MiscDye[n].ID = Reader.ReadInt32();
                            MiscDye[n].Prefix = Reader.ReadByte();
                            MiscDye[n].Count = 1;
                        }

                        for (int num = 0; num < 40; num++)
                        {
                            Bank[num].ID = Reader.ReadInt32();
                            Bank[num].Count = Reader.ReadInt32();
                            Bank[num].Prefix = Reader.ReadByte();
                        }

                        for (int num2 = 0; num2 < 40; num2++)
                        {
                            Safe[num2].ID = Reader.ReadInt32();
                            Safe[num2].Count = Reader.ReadInt32();
                            Safe[num2].Prefix = Reader.ReadByte();
                        }

                        for (int num3 = 0; num3 < 22; num3++)
                        {
                            Buffs[num3].BuffType = Reader.ReadInt32();
                            Buffs[num3].BuffTime = Reader.ReadInt32();
                        }

                        for (int num4 = 0; num4 < 200; num4++)
                        {
                            int num29 = Reader.ReadInt32();
                            if (num29 == -1)
                            {
                                break;
                            }
                            SpX[num4] = num29;
                            SpY[num4] = Reader.ReadInt32();
                            SpI[num4] = Reader.ReadInt32();
                            SpN[num4] = Reader.ReadString();
                        }

                        HotBarLocked = Reader.ReadBoolean();

                        for (int num5 = 0; num5 < 13; num5++)
                        {
                            HideInfo[num5] = Reader.ReadBoolean();
                        }

                        AnglerQuestsFinished = Reader.ReadInt32();
                    }
                }
            }
        }

        public void FromFile(string Path)
        {
            RijndaelManaged Rijndael = new RijndaelManaged();
            Rijndael.Padding = PaddingMode.None;
            byte[] buffer = File.ReadAllBytes(Path);
            using (MemoryStream MemStream = new MemoryStream(buffer))
            {
                using (CryptoStream DecryptStream = new CryptoStream(MemStream, Rijndael.CreateDecryptor(new UnicodeEncoding().GetBytes("h3y_gUyZ"), new UnicodeEncoding().GetBytes("h3y_gUyZ")), CryptoStreamMode.Read))
                {
                    using (BinaryReader Reader = new BinaryReader(DecryptStream))
                    {
                        Release = Reader.ReadInt32();
                        if (Release >= 135)
                        {
                            //Validity check
                            Reader.ReadUInt64();

                            Revision = Reader.ReadUInt32();

                            IsFavorite = ((Reader.ReadUInt64() & 1uL) == 1uL);
                        }
                        Name = Reader.ReadString();
                        if (Release >= 10)
                        {
                            if (Release >= 17)
                            {
                                Difficulty = Reader.ReadByte();
                            }
                            else
                            {
                                bool flag = Reader.ReadBoolean();
                                if (flag)
                                {
                                    Difficulty = 2;
                                }
                            }
                        }
                        if (Release >= 138)
                        {
                            PlayTime = new TimeSpan(Reader.ReadInt64());
                        }
                        else
                        {
                            PlayTime = new TimeSpan(0L);
                        }
                        Hair = Reader.ReadInt32();
                        if (Release >= 82)
                        {
                            HairDye = Reader.ReadByte();
                        }
                        if (Release >= 124)
                        {
                            byte bitsByte = Reader.ReadByte();
                            for (int i = 0; i < 8; i++)
                            {
                                HideVisual[i] = bitsByte.GetBit(i);
                            }
                            bitsByte = Reader.ReadByte();
                            for (int j = 0; j < 2; j++)
                            {
                                HideVisual[j + 8] = bitsByte.GetBit(j);
                            }
                        }
                        else if (Release >= 83)
                        {
                            byte bitsByte2 = Reader.ReadByte();
                            for (int k = 0; k < 8; k++)
                            {
                                HideVisual[k] = bitsByte2.GetBit(k);
                            }
                        }
                        if (Release >= 119)
                        {
                            HideMisc = Reader.ReadByte();
                        }
                        if (Release <= 17)
                        {
                            if (Hair == 5 || Hair == 6 || Hair == 9 || Hair == 11)
                            {
                                Gender = Genders.Female;
                            }
                            else
                            {
                                Gender = Genders.Male;
                            }
                        }
                        else if (Release < 107)
                        {
                            Gender = Reader.ReadBoolean() ? Genders.Male : Genders.Female;
                        }
                        else
                        {
                            SkinVariant = (int)Reader.ReadByte();
                        }
                        Life = Reader.ReadInt32();
                        MaxLife = Reader.ReadInt32();
                        if (MaxLife > 500)
                        {
                            MaxLife = 500;
                        }
                        Mana = Reader.ReadInt32();
                        MaxMana = Reader.ReadInt32();
                        if (MaxMana > 200)
                        {
                            MaxMana = 200;
                        }
                        if (Mana > 400)
                        {
                            Mana = 400;
                        }
                        if (Release >= 125)
                        {
                            ExtraAccessory = Reader.ReadBoolean();
                        }
                        if (Release >= 128)
                        {
                            TaxMoney = Reader.ReadInt32();
                        }

                        HairColor.R = Reader.ReadByte();
                        HairColor.G = Reader.ReadByte();
                        HairColor.B = Reader.ReadByte();

                        SkinColor.R = Reader.ReadByte();
                        SkinColor.G = Reader.ReadByte();
                        SkinColor.B = Reader.ReadByte();

                        EyeColor.R = Reader.ReadByte();
                        EyeColor.G = Reader.ReadByte();
                        EyeColor.B = Reader.ReadByte();

                        ShirtColor.R = Reader.ReadByte();
                        ShirtColor.G = Reader.ReadByte();
                        ShirtColor.B = Reader.ReadByte();

                        UnderShirtColor.R = Reader.ReadByte();
                        UnderShirtColor.G = Reader.ReadByte();
                        UnderShirtColor.B = Reader.ReadByte();

                        PantsColor.R = Reader.ReadByte();
                        PantsColor.G = Reader.ReadByte();
                        PantsColor.B = Reader.ReadByte();

                        ShoeColor.R = Reader.ReadByte();
                        ShoeColor.G = Reader.ReadByte();
                        ShoeColor.B = Reader.ReadByte();

                        if (Release >= 38)
                        {
                            if (Release < 124)
                            {
                                int num2 = 11;
                                if (Release >= 81)
                                {
                                    num2 = 16;
                                }
                                for (int l = 0; l < num2; l++)
                                {
                                    int num3 = l;
                                    if (num3 >= 8)
                                    {
                                        num3 += 2;
                                    }
                                    Armor[num3].ID = Reader.ReadInt32();
                                    Armor[num3].Prefix = Reader.ReadByte();
                                    Armor[num3].Count = 1;
                                }
                            }
                            else
                            {
                                int num4 = 20;
                                for (int m = 0; m < num4; m++)
                                {
                                    Armor[m].ID = Reader.ReadInt32();
                                    Armor[m].Prefix = Reader.ReadByte();
                                    Armor[m].Count = 1;
                                }
                            }
                            if (Release >= 47)
                            {
                                int num5 = 3;
                                if (Release >= 81)
                                {
                                    num5 = 8;
                                }
                                if (Release >= 124)
                                {
                                    num5 = 10;
                                }
                                for (int n = 0; n < num5; n++)
                                {
                                    int num6 = n;
                                    Dye[num6].ID = Reader.ReadInt32();
                                    Dye[num6].Prefix = Reader.ReadByte();
                                    Dye[num6].Count = 1;
                                }
                            }
                            if (Release >= 58)
                            {
                                for (int num7 = 0; num7 < 58; num7++)
                                {
                                    int num8 = Reader.ReadInt32();
                                    if (num8 >= 3602)
                                    {
                                        Inventory[num7].ID = 0;
                                    }
                                    else
                                    {
                                        Inventory[num7].ID = num8;
                                        Inventory[num7].Count = Reader.ReadInt32();
                                        Inventory[num7].Prefix = Reader.ReadByte();
                                        if (Release >= 114)
                                        {
                                            //Favorited
                                            Reader.ReadBoolean();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int num9 = 0; num9 < 48; num9++)
                                {
                                    int num10 = Reader.ReadInt32();
                                    if (num10 >= 3602)
                                    {
                                        Inventory[num9].ID = 0;
                                    }
                                    else
                                    {
                                        Inventory[num9].ID = num10;
                                        Inventory[num9].Count = Reader.ReadInt32();
                                        Inventory[num9].Prefix = Reader.ReadByte();
                                    }
                                }
                            }
                            if (Release >= 117)
                            {
                                if (Release < 136)
                                {
                                    for (int num11 = 0; num11 < 5; num11++)
                                    {
                                        if (num11 != 1)
                                        {
                                            int num12 = Reader.ReadInt32();
                                            if (num12 >= 3602)
                                            {
                                                MiscEquips[num11].ID = 0;
                                            }
                                            else
                                            {
                                                MiscEquips[num11].ID = num12;
                                                MiscEquips[num11].Prefix = Reader.ReadByte();
                                                MiscEquips[num11].Count = 1;
                                            }
                                            num12 = Reader.ReadInt32();
                                            if (num12 >= 3602)
                                            {
                                                MiscDye[num11].ID = 0;
                                            }
                                            else
                                            {
                                                MiscDye[num11].ID = num12;
                                                MiscDye[num11].Prefix = Reader.ReadByte();
                                                MiscDye[num11].Count = 1;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int num13 = 0; num13 < 5; num13++)
                                    {
                                        int num14 = Reader.ReadInt32();
                                        if (num14 >= 3602)
                                        {
                                            MiscEquips[num13].ID = 0;
                                        }
                                        else
                                        {
                                            MiscEquips[num13].ID = num14;
                                            MiscEquips[num13].Prefix = Reader.ReadByte();
                                            MiscEquips[num13].Count = 1;
                                        }
                                        num14 = Reader.ReadInt32();
                                        if (num14 >= 3602)
                                        {
                                            MiscDye[num13].ID = 0;
                                        }
                                        else
                                        {
                                            MiscDye[num13].ID = num14;
                                            MiscDye[num13].Prefix = Reader.ReadByte();
                                            MiscDye[num13].Count = 1;
                                        }
                                    }
                                }
                            }
                            if (Release >= 58)
                            {
                                for (int num15 = 0; num15 < 40; num15++)
                                {
                                    Bank[num15].ID = Reader.ReadInt32();
                                    Bank[num15].Count = Reader.ReadInt32();
                                    Bank[num15].Prefix = Reader.ReadByte();
                                }
                                for (int num16 = 0; num16 < 40; num16++)
                                {
                                    Safe[num16].ID = Reader.ReadInt32();
                                    Safe[num16].Count = Reader.ReadInt32();
                                    Safe[num16].Prefix = Reader.ReadByte();
                                }
                            }
                            else
                            {
                                for (int num17 = 0; num17 < 20; num17++)
                                {
                                    Bank[num17].ID = Reader.ReadInt32();
                                    Bank[num17].Count = Reader.ReadInt32();
                                    Bank[num17].Prefix = Reader.ReadByte();
                                }
                                for (int num18 = 0; num18 < 20; num18++)
                                {
                                    Safe[num18].ID = Reader.ReadInt32();
                                    Safe[num18].Count = Reader.ReadInt32();
                                    Safe[num18].Prefix = Reader.ReadByte();
                                }
                            }
                        }
                        if (Release < 58)
                        {
                            for (int num25 = 40; num25 < 48; num25++)
                            {
                                Inventory[num25 + 10] = Inventory[num25];
                                Inventory[num25].ID = 0;
                                Inventory[num25].Count = 0;
                                Inventory[num25].Prefix = 0;
                            }
                        }
                        if (Release >= 11)
                        {
                            int num26 = 22;
                            if (Release < 74)
                            {
                                num26 = 10;
                            }
                            for (int num27 = 0; num27 < num26; num27++)
                            {
                                Buffs[num27].BuffType = Reader.ReadInt32();
                                Buffs[num27].BuffTime = Reader.ReadInt32();
                                if (Buffs[num27].BuffType == 0)
                                {
                                    num27--;
                                    num26--;
                                }
                            }
                        }
                        for (int num28 = 0; num28 < 200; num28++)
                        {
                            int num29 = Reader.ReadInt32();
                            if (num29 == -1)
                            {
                                break;
                            }
                            SpX[num28] = num29;
                            SpY[num28] = Reader.ReadInt32();
                            SpI[num28] = Reader.ReadInt32();
                            SpN[num28] = Reader.ReadString();
                        }
                        if (Release >= 16)
                        {
                            HotBarLocked = Reader.ReadBoolean();
                        }
                        if (Release >= 115)
                        {
                            int num30 = 13;
                            for (int num31 = 0; num31 < num30; num31++)
                            {
                                HideInfo[num31] = Reader.ReadBoolean();
                            }
                        }
                        if (Release >= 98)
                        {
                            AnglerQuestsFinished = Reader.ReadInt32();
                        }
                        SkinVariant = (int)(((float)SkinVariant).Clamp<float>(0f, 7f));
                    }
                }
            }
        }

        public void ToFile(string Path)
        {
            RijndaelManaged Rijndael = new RijndaelManaged();
            Stream stream = new FileStream(Path, FileMode.Create);

            using (stream)
            {
                using (CryptoStream cryptoStream = new CryptoStream(stream, Rijndael.CreateEncryptor(new UnicodeEncoding().GetBytes("h3y_gUyZ"), new UnicodeEncoding().GetBytes("h3y_gUyZ")), CryptoStreamMode.Write))
                {
                    using (BinaryWriter Writer = new BinaryWriter(cryptoStream))
                    {
                        Writer.Write(Release);

                        Writer.Write(27981915666277746uL | (ulong)((byte)3) << 56);
                        Writer.Write(Revision);
                        Writer.Write((ulong)((long)(IsFavorite ? 1 : 0 & 1)));

                        Writer.Write(Name);
                        Writer.Write(Difficulty);
                        Writer.Write(PlayTime.Ticks);
                        Writer.Write(Hair);
                        Writer.Write(HairDye);

                        BitArray bb = new BitArray(new bool[] { false, false, false, false, false, false, false, false });
                        for (int i = 0; i < 8; i++)
                        {
                            bb[i] = HideVisual[i];
                        }
                        Writer.Write(bb.ToByte());
                        bb = new BitArray(new bool[] { false, false, false, false, false, false, false, false });
                        for (int j = 0; j < 2; j++)
                        {
                            bb[j] = HideVisual[j + 8];
                        }
                        Writer.Write(bb.ToByte());

                        Writer.Write(HideMisc);
                        Writer.Write((byte)SkinVariant);
                        Writer.Write(Life);
                        Writer.Write(MaxLife);
                        Writer.Write(Mana);
                        Writer.Write(MaxMana);
                        Writer.Write(ExtraAccessory);
                        Writer.Write(TaxMoney);
                        Writer.Write(HairColor.R);
                        Writer.Write(HairColor.G);
                        Writer.Write(HairColor.B);
                        Writer.Write(SkinColor.R);
                        Writer.Write(SkinColor.G);
                        Writer.Write(SkinColor.B);
                        Writer.Write(EyeColor.R);
                        Writer.Write(EyeColor.G);
                        Writer.Write(EyeColor.B);
                        Writer.Write(ShirtColor.R);
                        Writer.Write(ShirtColor.G);
                        Writer.Write(ShirtColor.B);
                        Writer.Write(UnderShirtColor.R);
                        Writer.Write(UnderShirtColor.G);
                        Writer.Write(UnderShirtColor.B);
                        Writer.Write(PantsColor.R);
                        Writer.Write(PantsColor.G);
                        Writer.Write(PantsColor.B);
                        Writer.Write(ShoeColor.R);
                        Writer.Write(ShoeColor.G);
                        Writer.Write(ShoeColor.B);

                        //Might have to write count = 1 for empty slots

                        for (int k = 0; k < Armor.Length; k++)
                        {
                            Writer.Write(Armor[k].ID);
                            Writer.Write(Armor[k].Prefix);
                        }
                        for (int l = 0; l < Dye.Length; l++)
                        {
                            Writer.Write(Dye[l].ID);
                            Writer.Write(Dye[l].Prefix);
                        }
                        for (int m = 0; m < 58; m++)
                        {
                            Writer.Write(Inventory[m].ID);
                            Writer.Write(Inventory[m].Count);
                            Writer.Write(Inventory[m].Prefix);

                            //Favorited
                            Writer.Write(false);
                        }
                        for (int n = 0; n < MiscEquips.Length; n++)
                        {
                            Writer.Write(MiscEquips[n].ID);
                            Writer.Write(MiscEquips[n].Prefix);
                            Writer.Write(MiscDye[n].ID);
                            Writer.Write(MiscDye[n].Prefix);
                        }
                        for (int num = 0; num < 40; num++)
                        {
                            Writer.Write(Bank[num].ID);
                            Writer.Write(Bank[num].Count);
                            Writer.Write(Bank[num].Prefix);
                        }
                        for (int num2 = 0; num2 < 40; num2++)
                        {
                            Writer.Write(Safe[num2].ID);
                            Writer.Write(Safe[num2].Count);
                            Writer.Write(Safe[num2].Prefix);
                        }
                        for (int num3 = 0; num3 < 22; num3++)
                        {
                            Writer.Write(Buffs[num3].BuffType);
                            Writer.Write(Buffs[num3].BuffTime);
                        }
                        for (int num4 = 0; num4 < 200; num4++)
                        {
                            if (SpN[num4] == null)
                            {
                                Writer.Write(-1);
                                break;
                            }
                            Writer.Write(SpX[num4]);
                            Writer.Write(SpY[num4]);
                            Writer.Write(SpI[num4]);
                            Writer.Write(SpN[num4]);
                        }
                        Writer.Write(HotBarLocked);
                        for (int num5 = 0; num5 < HideInfo.Length; num5++)
                        {
                            Writer.Write(HideInfo[num5]);
                        }
                        Writer.Write(AnglerQuestsFinished);
                        Writer.Flush();
                        cryptoStream.FlushFinalBlock();
                        stream.Flush();
                    }
                }
            }
        }
    }
}

