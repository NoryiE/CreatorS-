using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData {
    //CLIENTSIDE + SERVERSIDE

    public int Health = 100;
    public int PlayerIdentification = Game.Controller.GetIdentificationID();
    public bool isOnline = false;
    public bool isInClan = false;
    public int Weight = 75;
    public int ClanIdentification = 0;

    Item[] Inventory;
    public List<BaseController> bases;

    public PlayerData()
    {

    }
}
