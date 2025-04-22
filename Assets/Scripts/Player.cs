using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private List<Weapon> weapons;

    private WeaponManager weaponManager;
    private Action<WeaponManager> callbackUpdateUI;

    void Start()
    {
        weaponManager = new WeaponManager();
        if(weapons != null)
        {
            for(int i = 0; i< weapons.Count; i++)
            {
                Weapon weapon = weapons[i];
                weaponManager.AddWeapon(weapon);
            }
        }
        callbackUpdateUI?.Invoke(weaponManager);
    }

    public void SetCallbackUpdateUI(Action<WeaponManager> callback)
    {
        callbackUpdateUI = callback;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            weaponManager.Attack();
            callbackUpdateUI?.Invoke(weaponManager);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            weaponManager.Reload();
            callbackUpdateUI?.Invoke(weaponManager);
        }    

        if (Input.GetKeyDown(KeyCode.Q))
        {
            weaponManager.NextWeapon();
            callbackUpdateUI?.Invoke(weaponManager);
        }
    }
}

