using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : Item {

    [HideInInspector] public PlayerBase playerBase;
    CreatorsObject CreatorObject;
    PlaceableTemplate itemTemplate;

    GameObject placingObject;

    public Placeable(PlaceableTemplate itemTemplate)
    {
        this.itemTemplate = itemTemplate;
    }

    void SpawnObject(Vector3 position)
    {
        GameObject obj = MonoBehaviour.Instantiate(itemTemplate.CreatorObject.CreatorGameObject);
        obj.transform.position = position;
        obj.tag = "Building";
        obj.layer = 9;

    }

    public override void ActiveEvent()
    {
        base.ActiveEvent();
        Vector3 rayOrigin = new Vector3(0.5f, 0.5f); // center of the screen
        float rayLength = 150f;

        // actual Ray
        Ray ray = Camera.main.ViewportPointToRay(rayOrigin);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLength, 1 << 9))
        {
            if (hit.collider.tag == "Terrain")
            {
                if (placingObject == null) // NEW BASE
                {
                    placingObject = MonoBehaviour.Instantiate(itemTemplate.CreatorObject.CreatorGameObject);
                    placingObject.GetComponent<MeshRenderer>().material = GameObject.Find("Configuration").GetComponent<Configuration>().greenPlacingMaterial;
                    placingObject.GetComponent<Collider>().enabled = false;
                }
                placingObject.transform.position = hit.point;
            }
            else if (hit.collider.tag == "Building") // ZU VORHANDENEN BASE HINZUFÜGEN
            {
                
            }
        }
    }

    public override void InactiveEvent()
    {
        base.InactiveEvent();
        MonoBehaviour.Destroy(placingObject);
    }

    public override void InputKeyPressed()
    {
        base.InputKeyPressed();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnObject(placingObject.transform.position);
        }
    }
}
