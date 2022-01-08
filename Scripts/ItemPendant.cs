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

namespace JewelryAdditions
{
    public class ItemPendant : DaggerfallUnityItem
    {
        public const int templateIndex = 4702;
        public const string baseName = "Pendant";

        public static int pendantType = -1;

        public ItemPendant() : base(ItemGroups.Jewellery, templateIndex)
        {
            if (pendantType >= 0)
                message = pendantType;
            else
                message = JewelryAdditionsMain.GetRandomVariantType(false, true, 12) + 1;
                //message = Random.Range(1, 13);

            pendantType = -1;

            switch (message)
            {
                case 1:
                    shortName = "Gold Pendant";
                    value = 140;
					maxCondition = 1750;
					enchantmentPoints = 525;
                    break;
                case 2:
                    shortName = "Ruby Pendant";
                    value = 655;
					maxCondition = 4375;
					enchantmentPoints = 1835;
                    break;
                case 3:
                    shortName = "Emerald Pendant";
                    value = 870;
					maxCondition = 5475;
					enchantmentPoints = 2885;
                    break;
                case 4:
                    shortName = "Sapphire Pendant";
                    value = 745;
					maxCondition = 4855;
					enchantmentPoints = 2230;
                    break;
                case 5:
                    shortName = "Diamond Pendant";
                    value = 1110;
					maxCondition = 7000;
					enchantmentPoints = 3750;
                    break;
                case 6:
                    shortName = "Amethyst Pendant";
                    value = 320;
					maxCondition = 2665;
					enchantmentPoints = 915;
                    break;
                case 7:
                    shortName = "Apatite Pendant";
                    value = 200;
					maxCondition = 2050;
					enchantmentPoints = 655;
                    break;
                case 8:
                    shortName = "Aquamarine Pendant";
                    value = 440;
					maxCondition = 3275;
					enchantmentPoints = 1180;
                    break;
                case 9:
                    shortName = "Garnet Pendant";
                    value = 260;
					maxCondition = 2355;
					enchantmentPoints = 785;
                    break;
                case 10:
                    shortName = "Topaz Pendant";
                    value = 380;
					maxCondition = 2975;
					enchantmentPoints = 1030;
                    break;
                case 11:
                    shortName = "Zircon Pendant";
                    value = 560;
					maxCondition = 3890;
					enchantmentPoints = 1440;
                    break;
                case 12:
                    shortName = "Spinel Pendant";
                    value = 500;
					maxCondition = 3585;
					enchantmentPoints = 1310;
                    break;
                default:
                    shortName = "Broken Pendant";
                    value = 1;
					maxCondition = 100;
					enchantmentPoints = 1;
                    break;
            }

            if (message > 1)
                weightInKg += 0.03f; // Add 0.01 weight if jewelry item has a gemstone.

            currentCondition = maxCondition;

            CurrentVariant = message - 1;
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

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Amulet0, EquipSlots.Amulet1);
        }

        public override int GetEnchantmentPower()
        {
            return enchantmentPoints;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemPendant).ToString();
            return data;
        }

    }
}

