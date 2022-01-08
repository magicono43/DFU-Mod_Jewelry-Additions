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
    public class ItemAmethyst : DaggerfallUnityItem
    {
        public const int templateIndex = 4708;

        public ItemAmethyst() : base(ItemGroups.Gems, templateIndex)
        {
        }

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal1);
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemAmethyst).ToString();
            return data;
        }

    }
	
	public class ItemApatite : DaggerfallUnityItem
    {
        public const int templateIndex = 4709;

        public ItemApatite() : base(ItemGroups.Gems, templateIndex)
        {
        }

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal1);
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemApatite).ToString();
            return data;
        }

    }
	
	public class ItemAquamarine : DaggerfallUnityItem
    {
        public const int templateIndex = 4710;

        public ItemAquamarine() : base(ItemGroups.Gems, templateIndex)
        {
        }

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal1);
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemAquamarine).ToString();
            return data;
        }

    }
	
	public class ItemGarnet : DaggerfallUnityItem
    {
        public const int templateIndex = 4711;

        public ItemGarnet() : base(ItemGroups.Gems, templateIndex)
        {
        }

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal1);
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemGarnet).ToString();
            return data;
        }

    }
	
	public class ItemTopaz : DaggerfallUnityItem
    {
        public const int templateIndex = 4712;

        public ItemTopaz() : base(ItemGroups.Gems, templateIndex)
        {
        }

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal1);
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemTopaz).ToString();
            return data;
        }

    }
	
	public class ItemZircon : DaggerfallUnityItem
    {
        public const int templateIndex = 4713;

        public ItemZircon() : base(ItemGroups.Gems, templateIndex)
        {
        }

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal1);
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemZircon).ToString();
            return data;
        }

    }
	
	public class ItemSpinel : DaggerfallUnityItem
    {
        public const int templateIndex = 4714;

        public ItemSpinel() : base(ItemGroups.Gems, templateIndex)
        {
        }

        public override EquipSlots GetEquipSlot()
        {
            return GameManager.Instance.PlayerEntity.ItemEquipTable.GetFirstSlot(EquipSlots.Crystal0, EquipSlots.Crystal1);
        }

        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(ItemSpinel).ToString();
            return data;
        }

    }
}

