using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CreatorsObject", menuName = "Game/CreatorsObject")]
public class CreatorsObject : ScriptableObject {

    [HideInInspector] public int OwnerID;
    [HideInInspector] public int ClanID;

    public GameObject CreatorGameObject;
    public bool isFoundation = false;

}
