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
    public class ItemBracelet : DaggerfallUnityItem
    {
        public const int templateIndex = 4703;
        public const string baseName = "Bracelet";

        public static int braceletType = -1;

        public ItemBracelet() : base(ItemGroups.Jewellery, templateIndex)
        {
            if (braceletType >= 0)
                message = braceletType;
            else
                message = JewelryAdditionsMain.GetRandomVariantType(false, false, 11) + 1;
                //message = Random.Range(1, 12);

            braceletType = -1;

            switch (message)
            {
                case 1:
                    shortName = "Ruby Encrusted Bracelet";
                    value = 755;
					maxCondition = 6565;
					enchantmentPoints = 2295;
                    break;
                case 2:
                    shortName = "Emerald Encrusted Bracelet";
                    value = 970;
					maxCondition = 8215;
					enchantmentPoints = 3605;
                    break;
                case 3:
                    shortName = "Sapphire Encrusted Bracelet";
                    value = 845;
					maxCondition = 7280;
					enchantmentPoints = 2785;
                    break;
                case 4:
                    shortName = "Diamond Encrusted Bracelet";
                    value = 1210;
					maxCondition = 10500;
					enchantmentPoints = 4685;
                    break;
                case 5:
                    shortName = "Amethyst Encrusted Bracelet";
                    value = 420;
					maxCondition = 3995;
					enchantmentPoints = 1140;
                    break;
                case 6:
                    shortName = "Apatite Encrusted Bracelet";
                    value = 300;
					maxCondition = 3075;
					enchantmentPoints = 815;
                    break;
                case 7:
                    shortName = "Aquamarine Encrusted Bracelet";
                    value = 540;
					maxCondition = 4915;
					enchantmentPoints = 1475;
                    break;
                case 8:
                    shortName = "Garnet Encrusted Bracelet";
                    value = 360;
					maxCondition = 3530;
					enchantmentPoints = 980;
                    break;
                case 9:
                    shortName = "Topaz Encrusted Bracelet";
                    value = 480;
					maxCondition = 4460;
					enchantmentPoints = 1285;
                    break;
                case 10:
                    shortName = "Zircon Encrusted Bracelet";
                    value = 660;
					maxCondition = 5835;
					enchantmentPoints = 1800;
                    break;
                case 11:
                    shortName = "Spinel Encrusted Bracelet";
                    value = 600;
					maxCondition = 5375;
					enchantmentPoints = 1635;
                    break;
                default:
                    shortName = "Broken Bracelet";
                    value = 1;
					maxCondition = 100;
					enchantmentPoints = 1;
                    break;
            }

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
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Bracelet0, EquipSlots.Bracelet1);
        }

        public override int GetEnchantmentPower()
        {
            return enchantmentPoints;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemBracelet).ToString();
            return data;
        }

    }
}

