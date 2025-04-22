using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    private int ammo = 5;
    private int maxAmmo = 5;

    public Shotgun()
    {
        Name = "Shotgun";
        FireRate = 1f;
    }

    public override void Attack()
    {
        if (ammo > 0 && CanFire())
        {
            ammo--;
            UpdateFireTime();
            Debug.Log("Shotgun: Boom! (Spread shot)");
        }
        else
        {
            Debug.Log("Shotgun: can't attack!");
        }
    }

    public override void Reload()
    {
        ammo = maxAmmo;
        Debug.Log("Shotgun reloaded.");
    }

    public override int GetRemainingAmmo()
    {
        return ammo;
    }
}