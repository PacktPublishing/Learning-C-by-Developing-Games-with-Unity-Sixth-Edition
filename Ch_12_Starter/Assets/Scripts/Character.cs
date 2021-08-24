using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Time for action - creating a character class
public class Character
{
    // Time for action - fleshing out character details
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not assigned";
    }

    // Time for action - specifying starting properties
    public Character(string name)
    {
        this.name = name;
    }

    // Time for action - printing out character data
    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }

    // Time for action - adding a reset
    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}

// Time for action - calling a base constructor
public class Paladin : Character
{
    public Weapon weapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    // Time for action - functional variations
    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", name, weapon.name);
    }
}


