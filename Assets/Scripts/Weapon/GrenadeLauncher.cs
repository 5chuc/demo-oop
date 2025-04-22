using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class GrenadeLauncher : Weapon
{
    private int grenades = 3;
    private int maxGrenades = 3;

    public GrenadeLauncher()
    {
        Name = "Grenade Launcher";
        FireRate = 0.5f;
    }

    public override void Attack()
    {
        if (grenades > 0 && CanFire())
        {
            grenades--;
            UpdateFireTime();
            Debug.Log("Grenade Launcher: Thunk! (Arc shot)");
        }
        else
        {
            Debug.Log("Grenade Launcher: No grenades left!");
        }
    }

    public override void Reload()
    {
        grenades = maxGrenades;
        Debug.Log("Grenade launcher reloaded.");
    }

    public override int GetRemainingAmmo()
    {
        return grenades;
    }
}