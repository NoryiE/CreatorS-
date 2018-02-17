using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlaceableItem", menuName = "Game/PlaceableItem")]
public class PlaceableItem : Item
{

    public GameObject GOPrefab;


    public void SpawnObject(Vector3 position)
    {
        GameObject obj = Instantiate(GOPrefab);
        obj.transform.position = position;

    }

}
