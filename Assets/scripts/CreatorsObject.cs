using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorsObject {

    CreatorsObjectTemplate template;
    GameObject obj;
    Vector3 worldPos;
    Vector3 basePos;


    public CreatorsObject(CreatorsObjectTemplate template, Vector3 position, PlayerController player)
    {
        this.template = template;
        obj = Object.Instantiate(template.CreatorGameObject);
        obj.transform.position = position;
        obj.tag = "Building";
        obj.layer = 9;
    }

    public void Remove()
    {
        Object.Destroy(obj);
    }
}
