using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : Item {

    [HideInInspector] public BaseController playerBase;
    CreatorsObjectTemplate objectTemplate;
    PlaceableTemplate itemTemplate;

    GameObject placingObject;

    public Placeable(PlaceableTemplate itemTemplate)
    {
        this.itemTemplate = itemTemplate;
    }

    public override void WhileHoldingItem(PlayerController player)
    {
        base.WhileHoldingItem(player);
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
                    placingObject = Object.Instantiate(itemTemplate.CreatorObjectTemplate.CreatorGameObject);
                    placingObject.GetComponent<MeshRenderer>().material = Game.Controller.greenPlacingMaterial;
                    placingObject.GetComponent<Collider>().enabled = false;
                }
                placingObject.transform.position = hit.point;
            }
            else if (hit.collider.tag == "Building") // ZU VORHANDENEN BASE HINZUFÜGEN
            {
                
            }
        }
    }

    public override void OnStopHoldingItem(PlayerController player)
    {
        base.OnStopHoldingItem(player);
        MonoBehaviour.Destroy(placingObject);
    }

    public override void OnKeyPressed(PlayerController player)
    {
        base.OnKeyPressed(player);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreatorsObject creatorsObject = new CreatorsObject(itemTemplate.CreatorObjectTemplate, placingObject.transform.position, player);
        }
    }
}
