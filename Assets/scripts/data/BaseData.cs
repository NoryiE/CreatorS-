using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseData {
    //CLIENTSIDE + SERVERSIDE

    Dictionary<Vector3, GameObject> objectList;
    public int IdentifactionNumber = 0;
    public bool isClanBase = false;
    public Vector3 WorldPosition;

    public BaseData()
    {
        objectList = new Dictionary<Vector3, GameObject>();
    }

    public void AddCreatorObject(Vector3 position, GameObject obj)
    {
        objectList.Add(position, obj);
    }
}
