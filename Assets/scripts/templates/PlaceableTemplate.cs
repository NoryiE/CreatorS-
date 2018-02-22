﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Placeable", menuName = "Game/Placeable")]
public class PlaceableTemplate : ItemTemplate
{

    public CreatorsObjectTemplate CreatorObjectTemplate;
    public int blockWidth;
    public int blockLength;
    public int blockHeight;
    public bool isFoundationType;

}
