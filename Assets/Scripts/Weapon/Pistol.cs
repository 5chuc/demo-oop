using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Pistol : Weapon
{
    private int ammo = 10;
    private int maxAmmo = 10;

    public Pistol()
    {
        Name = "Pistol";
        FireRate = 2f;
    }

    public override void Attack()
    {
        if (ammo > 0 && CanFire())
        {
            ammo--;
            UpdateFireTime();
            Debug.Log("Pistol: Bang!");
        }
        else if (ammo == 0)
        {
            Debug.Log("Pistol: Out of ammo!");
        }
    }

    public override void Reload()
    {
        ammo = maxAmmo;
        Debug.Log("Pistol reloaded.");
    }

    public override int GetRemainingAmmo()
    {
        return ammo;
    }
}