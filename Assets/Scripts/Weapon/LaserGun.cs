using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : Weapon
{
    private float energy = 100f;
    private float energyCostPerShot = 10f;

    public LaserGun()
    {
        Name = "Laser Gun";
        FireRate = 3f;
    }

    public override void Attack()
    {
        if (energy >= energyCostPerShot && CanFire())
        {
            energy -= energyCostPerShot;
            UpdateFireTime();
            Debug.Log("Laser: Pewww!");
        }
        else
        {
            Debug.Log("Laser: Not enough energy!");
        }
    }

    public override void Reload()
    {
        energy = 100f;
        Debug.Log("Laser gun recharged.");
    }

    public override int GetRemainingAmmo()
    {
        return (int)(energy / energyCostPerShot);
    }
}