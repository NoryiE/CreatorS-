using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    //CLIENTSIDE + SERVERSIDE

    [HideInInspector] static public Game Controller;

    public Material greenPlacingMaterial;
    public Material redPlacingMaterial;
    public GameObject BaseControllerPrefab;

    public ItemTemplate[] itemTemplates;
    public GameData data;

    [HideInInspector] public List<GameObject> baseController;
    [HideInInspector] public List<PlayerController> playerController;

    void Awake()
    {
        baseController = new List<GameObject>();
        playerController = new List<PlayerController>();
        data = new GameData();
        if(Controller==null)
        {
            Controller = this;
        }
    }

    public int GetIdentificationID()
    {
        return data.GetIdentificationID;
    }

}
