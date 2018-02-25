using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorsObject : MonoBehaviour {
    //CLIENTSIDE

    [HideInInspector]public CreatorsObjectTemplate template;
    Vector3 basePos;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Remove()
    {
        Destroy(this);
    }

    public void UpdateInformation(Vector3 basePos)
    {
        this.basePos = basePos;
    }
}
