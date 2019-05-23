using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StatusEffect
{
    public int strength;

    public StatusEffect(int str)
    {
        strength = str;
        Apply();
    }

    public void Apply() { }
    public void OnTurn() { }
    public void OnHit() { }
    public void OnDeath() { }
    public void Remove() { }
}
