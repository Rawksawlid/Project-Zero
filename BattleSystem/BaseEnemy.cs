using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy
{
    // Everyone needs a name
    public string name;

    // String for the types
    public enum Type
    {
        FIRE,
        WATER,
        EARTH,
        AIR,
        LIGHT,
        DARK
    }

    // How often a monster will appear
    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE
    }

    public Type EnemyType;
    public Rarity rarity;

    // Set out stat values for monster
    public float baseHP;
    public float curHP;

    public float baseMP;
    public float curMP;

    public float baseATK;
    public float curATK;

    public float baseDEF;
    public float curDEF;

}
