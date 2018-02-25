using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : Item {
    //CLIENTSIDE

    [HideInInspector] public BaseController playerBase;
    CreatorsObjectTemplate objectTemplate;
    PlaceableTemplate itemTemplate;

    GameObject placingObject;
    Collider collider;
    BaseController bController;

    public Placeable(PlaceableTemplate itemTemplate)
    {
        this.itemTemplate = itemTemplate;
    }

    public override void WhileHoldingItem(PlayerController player)
    {
        base.WhileHoldingItem(player);
        Vector3 rayOrigin = new Vector3(0.5f, 0.5f); //Screen Mitte
        float rayLength = 150f;


        Ray ray = Camera.main.ViewportPointToRay(rayOrigin);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayLength, 1 << 9))
        {
            if (placingObject == null)
            {
                placingObject = Object.Instantiate(itemTemplate.CreatorObjectTemplate.CreatorGameObject);
                placingObject.name = "PlacingObject";
                placingObject.GetComponent<MeshRenderer>().material = Game.Controller.greenPlacingMaterial;
                placingObject.GetComponent<Collider>().enabled = false;
            }
            collider = hit.collider;
            if (hit.collider.tag == "Terrain") // NEW BASE
            {
                placingObject.transform.position = hit.point;
                bController = null;
            }
            else if (hit.collider.tag == "Building") // ZU VORHANDENEN BASE HINZUFÜGEN
            {
                placingObject.transform.position = hit.point;
                if(bController==null)
                    bController = collider.GetComponentInParent<BaseController>();
                else
                {
                    if(bController.IdentificationNumber == player.GetPlayerIdentification)
                    {
                        float scale = 2.5f;
                        float x = 0, y = 0, z = 0;

                        Vector3 MyNormal = hit.normal;
                        MyNormal = hit.transform.TransformDirection(MyNormal);
                        if (MyNormal == hit.transform.up) y += scale;
                        if (MyNormal == -hit.transform.up) y -= scale;
                        if (MyNormal == hit.transform.right) x += scale;
                        if (MyNormal == -hit.transform.right) x -= scale;
                        if (MyNormal == hit.transform.forward) z += scale;
                        if (MyNormal == -hit.transform.forward) z -= scale;

                        placingObject.transform.position = new Vector3(x, y, z) + collider.transform.position;
                    }
                }

                

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
            player.CreateNewCreatorsObject(placingObject.transform.position, itemTemplate.CreatorObjectTemplate, collider);
        }
    }
}
