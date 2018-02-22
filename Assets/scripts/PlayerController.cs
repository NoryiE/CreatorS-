using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int Health = 100;
    public int PlayerIdentification = 1;
    public bool isInClan = false;
    public int Weight = 75;
    public int ClanIdentification = 0;

    Item[] Inventory;
    Item[] shortcutItemList; //Temporär zum proggen
    short activeSelection = -1;

    Game controller;


    void Start()
    {
        controller = Game.Controller;
        shortcutItemList = new Item[10];
        shortcutItemList[0] = new Placeable(((PlaceableTemplate)controller.itemTemplates[0]));

    }


    void Update()
    {
        switch (Input.inputString)
        {
            case "1":
                ResetItemConfig();
                activeSelection = 0;
                break;
            case "2":
                ResetItemConfig();
                activeSelection = 1;
                break;
            case "3":
                ResetItemConfig();
                activeSelection = 2;
                break;
            case "4":
                ResetItemConfig();
                activeSelection = 3;
                break;
            case "5":
                ResetItemConfig();
                activeSelection = 4;
                break;
            case "6":
                ResetItemConfig();
                activeSelection = 5;
                break;
            case "7":
                ResetItemConfig();
                activeSelection = 6;
                break;
            case "8":
                ResetItemConfig();
                activeSelection = 7;
                break;
            case "9":
                ResetItemConfig();
                activeSelection = 8;
                break;
            case "0":
                ResetItemConfig();
                activeSelection = 9;
                break;
        }
        if (activeSelection >= 0 && activeSelection <= 9 && shortcutItemList[activeSelection] != null)
        {
            if (Input.anyKeyDown)
            {
                shortcutItemList[activeSelection].OnKeyPressed(this);
            }
            shortcutItemList[activeSelection].WhileHoldingItem(this);
        }
    }



    void ResetItemConfig()
    {
        if (activeSelection >= 0 && activeSelection <= 9)
        {
            if (shortcutItemList[activeSelection] != null)
                shortcutItemList[activeSelection].OnStopHoldingItem(this);
        }
    }
}
