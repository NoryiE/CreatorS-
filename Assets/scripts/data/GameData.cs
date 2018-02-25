using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData {
    //CLIENTSIDE + SERVERSIDE
    int IdentificationID = 1;

    public int GetIdentificationID { get { return IdentificationID++; } }

    public GameData()
    {

    }
}
