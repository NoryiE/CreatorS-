using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    [HideInInspector] static public Game Controller;

    public Material greenPlacingMaterial;
    public Material redPlacingMaterial;

    public ItemTemplate[] itemTemplates;
    public List<BaseController> bases;

    void Awake()
    {
        bases = new List<BaseController>();
        if(Controller==null)
        {
            Controller = this;
        }
    }

}
