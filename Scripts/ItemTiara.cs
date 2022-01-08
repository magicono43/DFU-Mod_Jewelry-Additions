// Project:         JewelryAdditions mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Kirk.O
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Kirk.O
// Created On: 	    12/25/2021, 6:45 PM
// Last Edit:		1/7/2022, 8:45 PM
// Version:			1.00
// Special Thanks:  Hazelnut, Ralzar, Ninelan, BadLuckBurt, Pango
// Modifier:		

using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Entity;

namespace JewelryAdditions
{
    public class ItemTiara : DaggerfallUnityItem
    {
        public const int templateIndex = 4704;
        public const string baseName = "Tiara";

        public static int tiaraType = -1;

        public ItemTiara() : base(ItemGroups.Armor, templateIndex)
        {
            if (tiaraType >= 0)
                message = tiaraType;
            else
                message = JewelryAdditionsMain.GetRandomVariantType(true, true, 24);
                //message = Random.Range(1, 25);

            tiaraType = -1;

            switch (message)
            {
                case 1:
                    shortName = "Silver Tiara";
                    value = 100;
					maxCondition = 1000;
					enchantmentPoints = 2400;
                    break;
                case 2:
                    shortName = "Gold Tiara";
                    value = 400;
					maxCondition = 4000;
					enchantmentPoints = 1200;
                    break;
                case 3:
                    shortName = "Silver Ruby Tiara";
                    value = 950;
					maxCondition = 4000;
					enchantmentPoints = 8400;
                    break;
                case 4:
                    shortName = "Gold Ruby Tiara";
                    value = 1250;
					maxCondition = 10000;
					enchantmentPoints = 4200;
                    break;
                case 5:
                    shortName = "Silver Emerald Tiara";
                    value = 1300;
					maxCondition = 5260;
					enchantmentPoints = 13200;
                    break;
                case 6:
                    shortName = "Gold Emerald Tiara";
                    value = 1600;
					maxCondition = 12500;
					enchantmentPoints = 6600;
                    break;
                case 7:
                    shortName = "Silver Sapphire Tiara";
                    value = 1100;
					maxCondition = 4540;
					enchantmentPoints = 10200;
                    break;
                case 8:
                    shortName = "Gold Sapphire Tiara";
                    value = 1400;
					maxCondition = 11100;
					enchantmentPoints = 5100;
                    break;
                case 9:
                    shortName = "Silver Diamond Tiara";
                    value = 1700;
					maxCondition = 7000;
					enchantmentPoints = 17200;
                    break;
                case 10:
                    shortName = "Gold Diamond Tiara";
                    value = 2000;
					maxCondition = 16000;
					enchantmentPoints = 8600;
                    break;
                case 11:
                    shortName = "Silver Amethyst Tiara";
                    value = 400;
					maxCondition = 2060;
					enchantmentPoints = 4200;
                    break;
                case 12:
                    shortName = "Gold Amethyst Tiara";
                    value = 700;
					maxCondition = 6100;
					enchantmentPoints = 2100;
                    break;
                case 13:
                    shortName = "Silver Apatite Tiara";
                    value = 200;
					maxCondition = 1360;
					enchantmentPoints = 3000;
                    break;
                case 14:
                    shortName = "Gold Apatite Tiara";
                    value = 500;
					maxCondition = 4700;
					enchantmentPoints = 1500;
                    break;
                case 15:
                    shortName = "Silver Aquamarine Tiara";
                    value = 600;
					maxCondition = 2760;
					enchantmentPoints = 5400;
                    break;
                case 16:
                    shortName = "Gold Aquamarine Tiara";
                    value = 900;
					maxCondition = 7500;
					enchantmentPoints = 2700;
                    break;
                case 17:
                    shortName = "Silver Garnet Tiara";
                    value = 300;
					maxCondition = 1700;
					enchantmentPoints = 3600;
                    break;
                case 18:
                    shortName = "Gold Garnet Tiara";
                    value = 600;
					maxCondition = 5400;
					enchantmentPoints = 1800;
                    break;
                case 19:
                    shortName = "Silver Topaz Tiara";
                    value = 500;
					maxCondition = 2400;
					enchantmentPoints = 4800;
                    break;
                case 20:
                    shortName = "Gold Topaz Tiara";
                    value = 800;
					maxCondition = 6800;
					enchantmentPoints = 2400;
                    break;
                case 21:
                    shortName = "Silver Zircon Tiara";
                    value = 800;
					maxCondition = 3460;
					enchantmentPoints = 6600;
                    break;
                case 22:
                    shortName = "Gold Zircon Tiara";
                    value = 1100;
					maxCondition = 8900;
					enchantmentPoints = 3300;
                    break;
                case 23:
                    shortName = "Silver Spinel Tiara";
                    value = 700;
					maxCondition = 3100;
					enchantmentPoints = 6000;
                    break;
                case 24:
                    shortName = "Gold Spinel Tiara";
                    value = 1000;
					maxCondition = 8200;
					enchantmentPoints = 3000;
                    break;
                default:
                    shortName = "Broken Tiara";
                    value = 1;
					maxCondition = 100;
					enchantmentPoints = 1;
                    break;
            }

            nativeMaterialValue = (int)ArmorMaterialTypes.Silver;
            if (message % 2 == 0)
            {
                weightInKg += 0.1f; // Gold
                nativeMaterialValue = (int)ArmorMaterialTypes.Dwarven;
            }

            if (message > 2)
                weightInKg += 0.05f; // Add 0.01 weight if jewelry item has a gemstone.

            currentCondition = maxCondition;

            CurrentVariant = GetVariant((message - 1) * 8);
        }

        public override int InventoryTextureArchive
        {
            get { return templateIndex; }
        }

        public override string ItemName
        {
            get { return shortName; }
        }

        public override string LongName
        {
            get { return shortName; }
        }

        private int GetVariant(int message)
        {
            PlayerEntity playerEntity = GameManager.Instance.PlayerEntity;
            Races race = playerEntity.Race;
            int gender = 0;
            int bodymorph = (int)ItemBuilder.GetBodyMorphology(race);

            if (playerEntity.Gender == Genders.Male)
                gender = 4;

            int offset = bodymorph + gender;

            return message + offset;
        }

        public override int NativeMaterialValue
        {
            get
            {
                if (message % 2 == 0)
                    return (int)ArmorMaterialTypes.Dwarven; // Gold
                return (int)ArmorMaterialTypes.Silver; // Silver
            }
        }

        public override EquipSlots GetEquipSlot()
        {
            return EquipSlots.Head;
        }

        public override int GetMaterialArmorValue()
        {
            return 0;
        }

        public override int GetEnchantmentPower()
        {
            return enchantmentPoints;
        }

        public override SoundClips GetEquipSound()
        {
            return SoundClips.EquipJewellery;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemTiara).ToString();
            return data;
        }

    }
}

