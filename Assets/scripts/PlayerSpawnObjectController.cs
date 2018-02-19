using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnObjectController : MonoBehaviour {

    Item[] shortcutItemList;
    short activeSelection = -1;

    Configuration config;



    // Use this for initialization
    void Start () {
        shortcutItemList = new Item[10];
        config = GameObject.Find("Configuration").GetComponent<Configuration>();
        shortcutItemList[0] = new Placeable(((PlaceableTemplate)config.itemTemplates[0]));

    }
	
	// Update is called once per frame
	void Update () {
        switch(Input.inputString)
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
        if (activeSelection>=0 && activeSelection<=9 && shortcutItemList[activeSelection] != null)
        {
            if(Input.anyKeyDown)
            {
                shortcutItemList[activeSelection].InputKeyPressed();
            }
            shortcutItemList[activeSelection].ActiveEvent();
        }
	}



    void ResetItemConfig()
    {
        if (activeSelection >= 0 && activeSelection <= 9)
        {
            if(shortcutItemList[activeSelection]!=null)
                shortcutItemList[activeSelection].InactiveEvent();
        }
    }

}
