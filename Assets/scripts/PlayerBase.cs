using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour {

    Dictionary<Vector3, CreatorsObject> objectList;

    public PlayerBase()
    {
        objectList = new Dictionary<Vector3, CreatorsObject>();
    }

    public void AddObject(Vector3 position, CreatorsObject creatorsObject)
    {
        objectList.Add(position, creatorsObject);
    }


}
