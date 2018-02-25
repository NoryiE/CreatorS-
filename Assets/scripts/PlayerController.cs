using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //CLIENTSIDE


    Item[] shortcutItemList; //Temporär zum proggen
    short activeSelection = -1;


    PlayerData data;

    public int GetPlayerIdentification { get { return data.PlayerIdentification; } }


    void Start()
    {
        data = new PlayerData();
        shortcutItemList = new Item[10];
        shortcutItemList[0] = new Placeable(((PlaceableTemplate)Game.Controller.itemTemplates[0]));

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


    public BaseController CreateNewBase(Vector3 worldPos, GameObject obj)
    {
        GameObject baseControllerGO = Instantiate(Game.Controller.BaseControllerPrefab);
        baseControllerGO.transform.position = worldPos;
        BaseController baseC = baseControllerGO.GetComponent<BaseController>();
        baseC.IdentificationNumber = GetPlayerIdentification;
        baseC.WorldPosition = worldPos;
        baseC.AddObject(new Vector3(0, 0, 0), obj);
        Game.Controller.baseController.Add(baseControllerGO);

        return baseC;
    }

    public void CreateNewCreatorsObject(Vector3 worldPos, CreatorsObjectTemplate template, Collider collider)
    {
        GameObject go = Instantiate(template.CreatorGameObject);
        go.tag = "Building";
        go.layer = 9;
        go.AddComponent<CreatorsObject>();
        CreatorsObject cGo = go.GetComponent<CreatorsObject>();
        cGo.template = template;
        go.transform.position = worldPos;
        if (collider.tag == "Terrain")
        {
            CreateNewBase(worldPos, go);
        }
        else if (collider.tag == "Building")
        {
            BaseController bController = collider.GetComponentInParent<BaseController>();
            bController.AddObject(worldPos, go);
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
