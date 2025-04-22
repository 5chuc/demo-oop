using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager
{
    private List<Weapon> weapons = new List<Weapon>();
    private int currentWeaponIndex = 0;

    public void AddWeapon(Weapon weapon)
    {
        weapons.Add(weapon);
        Debug.Log($"Weapon added: {weapon.Name}");
    }

    public void SwitchWeapon(int index)
    {
        if (index >= 0 && index < weapons.Count)
        {
            currentWeaponIndex = index;
            Debug.Log($"Switched to: {weapons[currentWeaponIndex].Name}");
        }
    }

    public void Attack()
    {
        weapons[currentWeaponIndex].Attack();
    }

    public void Reload()
    {
        weapons[currentWeaponIndex].Reload();
    }

    public void NextWeapon()
    {
        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Count;
        Debug.Log($"Switched to: {weapons[currentWeaponIndex].Name}");
    }

    public int GetRemainAmmo()
    {
        return weapons[currentWeaponIndex].GetRemainingAmmo();
    }

    public string GetCurrentWeapon()
    {
        return weapons[currentWeaponIndex].Name;
    }
}
