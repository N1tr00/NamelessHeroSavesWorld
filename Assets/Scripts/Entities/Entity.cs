using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    [SerializeField]
    private int level;

    [SerializeField]
    private int name;

    [SerializeField]
    private int healthPoints;

    [SerializeField]
    private int attackDamage;

    [SerializeField]
    private int armour;

    [SerializeField]
    private double evasionChance;

    [SerializeField]
    private double critChance;

    [SerializeField]
    private List<Item> inventory;

    [SerializeField]
    private List<StatusEffect> statusEffects;

    public void Attack (Entity target)
    {

    }

    public void Flee(Entity enemy)
    {

    }

    public bool isAlive()
    {
        return healthPoints > 0;
    }

}
