using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    
    public enum ItemType
    {
        Weapon_Upgrade,
        Weapon_Speed,
        Flashlight_Upgrade,
        Flashlight_Plus,
        Healing_Potion
    }

    public static int GetCost(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.Weapon_Upgrade:     return 50;
            case ItemType.Weapon_Speed:       return 50;
            case ItemType.Flashlight_Upgrade: return 70;
            case ItemType.Flashlight_Plus:    return 200;
            case ItemType.Healing_Potion:     return 20;
        }
    }

    public static Sprite GetSprite(ItemType itemType)
    {
        Debug.Log(itemType);
        switch (itemType)
        {
            default:
            case ItemType.Weapon_Upgrade:     return GameAssets.i.Weapon_Upgrade;
            case ItemType.Weapon_Speed:       return GameAssets.i.Weapon_Speed;
            case ItemType.Flashlight_Upgrade: return GameAssets.i.Flashlight_Upgrade;
            case ItemType.Flashlight_Plus:    return GameAssets.i.Flashlight_Plus;
            case ItemType.Healing_Potion:     return GameAssets.i.Healing_Potion;
        }
    }
}
