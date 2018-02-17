using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnObjectController : MonoBehaviour {

    [SerializeField] Item[] shortcutItemList;
    [SerializeField] Material placingMaterial;
    short activeSelection = -1;
    GameObject placingObject;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        switch(Input.inputString)
        {
            case "1":
                activeSelection = 0;
                ResetItemConfig();
                break;
            case "2":
                activeSelection = 1;
                ResetItemConfig();
                break;
            case "3":
                activeSelection = 2;
                ResetItemConfig();
                break;
            case "4":
                activeSelection = 3;
                ResetItemConfig();
                break;
            case "5":
                activeSelection = 4;
                ResetItemConfig();
                break;
            case "6":
                activeSelection = 5;
                ResetItemConfig();
                break;
            case "7":
                activeSelection = 6;
                ResetItemConfig();
                break;
            case "8":
                activeSelection = 7;
                ResetItemConfig();
                break;
            case "9":
                activeSelection = 8;
                ResetItemConfig();
                break;
            case "0":
                activeSelection = 9;
                ResetItemConfig();
                break;
        }
        if (activeSelection>=0 && activeSelection<=9 && shortcutItemList[activeSelection] != null)
        {
            if (shortcutItemList[activeSelection].GetType() == typeof(PlaceableItem))
            {
                Vector3 rayOrigin = new Vector3(0.5f, 0.5f); // center of the screen
                float rayLength = 150f;

                // actual Ray
                Ray ray = Camera.main.ViewportPointToRay(rayOrigin);

                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, rayLength, 1 << 9))
                {
                    if (placingObject == null)
                    {
                        placingObject = Instantiate(((PlaceableItem)shortcutItemList[activeSelection]).GOPrefab);
                        placingObject.GetComponent<MeshRenderer>().material = placingMaterial;
                        placingObject.GetComponent<Collider>().enabled = false;
                    }
                    placingObject.transform.position = hit.point;

                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        ((PlaceableItem)shortcutItemList[activeSelection]).SpawnObject(hit.point);
                    }
                }
            }
        }
	}

    void ResetItemConfig()
    {
        if (activeSelection >= 0 && activeSelection <= 9)
        {
            Destroy(placingObject);
        }
    }

}
