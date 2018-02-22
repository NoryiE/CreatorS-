using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {

    Dictionary<Vector3, CreatorsObject> objectList;
    public int IdentifactionNumber;
    public bool isClanBase = false;

    public BaseController(Vector3 position, CreatorsObject creatorsObject)
    {
        objectList = new Dictionary<Vector3, CreatorsObject>();
        Game.Controller.bases.Add(this);
        AddObject(position, creatorsObject);
    }

    public void AddObject(Vector3 position, CreatorsObject creatorsObject)
    {
        objectList.Add(position, creatorsObject);
    }


}
