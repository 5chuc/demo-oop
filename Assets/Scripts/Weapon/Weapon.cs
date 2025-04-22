using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string Name { get; protected set; }

    public float FireRate { get; protected set; } 

    protected float lastFireTime;

    public abstract void Attack();

    public abstract int GetRemainingAmmo();

    public virtual void Reload() 
    { 
        Debug.Log($"{Name} is reloading..."); 
    }

    public bool CanFire()
    {
        return Time.time - lastFireTime >= 1f / FireRate;
    }

    protected void UpdateFireTime()
    {
        lastFireTime = Time.time;
    }
}
