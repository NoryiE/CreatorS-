using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Game/Weapon")]
public class WeaponTemplate : ItemTemplate
{
    //CLIENTSIDE + SERVERSIDE
    public int maxAmmo;

}
