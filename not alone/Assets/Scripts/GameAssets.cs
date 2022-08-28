using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets i {
        get
        {
            if (_i == null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return _i; 
        }
    }
    
    public Sprite Weapon_Upgrade;
    public Sprite Weapon_Speed;
    public Sprite Flashlight_Upgrade;
    public Sprite Flashlight_Plus;
    public Sprite Healing_Potion;
}
