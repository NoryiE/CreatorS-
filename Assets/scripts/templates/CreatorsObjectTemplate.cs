using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CreatorsObjectTemplate", menuName = "Game/CreatorsObjectTemplate")]
public class CreatorsObjectTemplate : ScriptableObject {
    //CLIENTSIDE + SERVERSIDE

    public GameObject CreatorGameObject;
    public bool isFoundation = false;



}
