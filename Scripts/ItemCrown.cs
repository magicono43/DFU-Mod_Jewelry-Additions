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
    public class ItemCrown : DaggerfallUnityItem
    {
        public const int templateIndex = 4705;
        public const string baseName = "Crown";

        public static int crownType = -1;

        public ItemCrown() : base(ItemGroups.Armor, templateIndex)
        {
            if (crownType >= 0)
                message = crownType;
            else
                message = JewelryAdditionsMain.GetRandomVariantType(true, true, 4);
                //message = Random.Range(1, 5);

            crownType = -1;

            switch (message)
            {
                case 1:
                    shortName = "Silver Crown";
                    value = 600;
					maxCondition = 2000;
					enchantmentPoints = 3600;
                    break;
                case 2:
                    shortName = "Gold Crown";
                    value = 2000;
					maxCondition = 8000;
					enchantmentPoints = 2400;
                    break;
                case 3:
                    shortName = "Gem Encrusted Silver Crown";
                    value = 5600;
					maxCondition = 6000;
					enchantmentPoints = 10800;
                    break;
                case 4:
                    shortName = "Gem Encrusted Gold Crown";
                    value = 8000;
					maxCondition = 24000;
					enchantmentPoints = 7200;
                    break;
                default:
                    shortName = "Broken Crown";
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
                weightInKg += 0.15f; // Add 0.01 weight if jewelry item has a gemstone.

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
            data.className = typeof(ItemCrown).ToString();
            return data;
        }

    }
}

