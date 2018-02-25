using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour {
    //CLIENTSIDE

    BaseData data;
    GameObject baseControllerObject;

    public int IdentificationNumber { get { return data.IdentifactionNumber; } set { data.IdentifactionNumber = value; } }
    public Vector3 WorldPosition { get { return data.WorldPosition; } set { data.WorldPosition = value; } }
    
    void Awake()
    {
        data = new BaseData();
    }

    public void AddObject(Vector3 position, GameObject creatorsObject)
    {
        creatorsObject.transform.parent = transform;
        CreatorsObject cGo = creatorsObject.GetComponent<CreatorsObject>();

        cGo.UpdateInformation(position);
        data.AddCreatorObject(position, creatorsObject);
    }

}
