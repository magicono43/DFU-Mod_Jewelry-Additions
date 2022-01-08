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
    public class ItemArmletPetal : DaggerfallUnityItem
    {
        public const int templateIndex = 4706;
        public const string baseName = "Armlet Petal";

        public static int armletPetalType = -1;

        public ItemArmletPetal() : base(ItemGroups.Jewellery, templateIndex)
        {
            if (armletPetalType >= 0)
                message = armletPetalType;
            else
                message = JewelryAdditionsMain.GetRandomVariantType(false, false, 11) + 1;
                //message = Random.Range(1, 12);

            armletPetalType = -1;

            switch (message)
            {
                case 1:
                    shortName = "Ruby Petal Armlet";
                    value = 420;
					maxCondition = 3375;
					enchantmentPoints = 1415;
                    break;
                case 2:
                    shortName = "Emerald Petal Armlet";
                    value = 560;
					maxCondition = 4215;
					enchantmentPoints = 2225;
                    break;
                case 3:
                    shortName = "Sapphire Petal Armlet";
                    value = 480;
					maxCondition = 3745;
					enchantmentPoints = 1720;
                    break;
                case 4:
                    shortName = "Diamond Petal Armlet";
                    value = 720;
					maxCondition = 5400;
					enchantmentPoints = 2900;
                    break;
                case 5:
                    shortName = "Amethyst Petal Armlet";
                    value = 200;
					maxCondition = 2055;
					enchantmentPoints = 705;
                    break;
                case 6:
                    shortName = "Apatite Petal Armlet";
                    value = 120;
					maxCondition = 1585;
					enchantmentPoints = 505;
                    break;
                case 7:
                    shortName = "Aquamarine Petal Armlet";
                    value = 280;
					maxCondition = 2530;
					enchantmentPoints = 910;
                    break;
                case 8:
                    shortName = "Garnet Petal Armlet";
                    value = 160;
					maxCondition = 1820;
					enchantmentPoints = 605;
                    break;
                case 9:
                    shortName = "Topaz Petal Armlet";
                    value = 240;
					maxCondition = 2295;
					enchantmentPoints = 810;
                    break;
                case 10:
                    shortName = "Zircon Petal Armlet";
                    value = 360;
					maxCondition = 3000;
					enchantmentPoints = 1110;
                    break;
                case 11:
                    shortName = "Spinel Petal Armlet";
                    value = 320;
					maxCondition = 2765;
					enchantmentPoints = 1010;
                    break;
                default:
                    shortName = "Broken Petal Armlet";
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
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Bracer0, EquipSlots.Bracer1);
        }

        public override int GetEnchantmentPower()
        {
            return enchantmentPoints;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemArmletPetal).ToString();
            return data;
        }

    }
	
	public class ItemArmletSnake : DaggerfallUnityItem
    {
        public const int templateIndex = 4707;
        public const string baseName = "Armlet Snake";

        public static int armletSnakeType = -1;

        public ItemArmletSnake() : base(ItemGroups.Jewellery, templateIndex)
        {
            if (armletSnakeType >= 0)
                message = armletSnakeType;
            else
                message = JewelryAdditionsMain.GetRandomVariantType(false, false, 11) + 1;
                //message = Random.Range(1, 12);

            armletSnakeType = -1;

            switch (message)
            {
                case 1:
                    shortName = "Ruby Snake Armlet";
                    value = 420;
					maxCondition = 3375;
					enchantmentPoints = 1415;
                    break;
                case 2:
                    shortName = "Emerald Snake Armlet";
                    value = 560;
					maxCondition = 4215;
					enchantmentPoints = 2225;
                    break;
                case 3:
                    shortName = "Sapphire Snake Armlet";
                    value = 480;
					maxCondition = 3745;
					enchantmentPoints = 1720;
                    break;
                case 4:
                    shortName = "Diamond Snake Armlet";
                    value = 720;
					maxCondition = 5400;
					enchantmentPoints = 2900;
                    break;
                case 5:
                    shortName = "Amethyst Snake Armlet";
                    value = 200;
					maxCondition = 2055;
					enchantmentPoints = 705;
                    break;
                case 6:
                    shortName = "Apatite Snake Armlet";
                    value = 120;
					maxCondition = 1585;
					enchantmentPoints = 505;
                    break;
                case 7:
                    shortName = "Aquamarine Snake Armlet";
                    value = 280;
					maxCondition = 2530;
					enchantmentPoints = 910;
                    break;
                case 8:
                    shortName = "Garnet Snake Armlet";
                    value = 160;
					maxCondition = 1820;
					enchantmentPoints = 605;
                    break;
                case 9:
                    shortName = "Topaz Snake Armlet";
                    value = 240;
					maxCondition = 2295;
					enchantmentPoints = 810;
                    break;
                case 10:
                    shortName = "Zircon Snake Armlet";
                    value = 360;
					maxCondition = 3000;
					enchantmentPoints = 1110;
                    break;
                case 11:
                    shortName = "Spinel Snake Armlet";
                    value = 320;
					maxCondition = 2765;
					enchantmentPoints = 1010;
                    break;
                default:
                    shortName = "Broken Snake Armlet";
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
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Bracer0, EquipSlots.Bracer1);
        }

        public override int GetEnchantmentPower()
        {
            return enchantmentPoints;
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemArmletSnake).ToString();
            return data;
        }

    }
}

