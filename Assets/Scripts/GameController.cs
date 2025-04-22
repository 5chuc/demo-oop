using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TMP_Text remainAmmo;
    [SerializeField] private TMP_Text currentWeapon;

    private void Awake()
    {
        if(player != null)
        {
            player.SetCallbackUpdateUI(UpdateUI);
        }
    }
    private void UpdateUI(WeaponManager weaponManager)
    {
        currentWeapon.SetText(weaponManager.GetCurrentWeapon());
        remainAmmo.SetText(weaponManager.GetRemainAmmo().ToString());
    }
}
