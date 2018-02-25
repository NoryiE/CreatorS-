﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTemplate : ScriptableObject
{
    //CLIENTSIDE + SERVERSIDE

    public string itemName;
    public int weight;
    public bool weightAutoCalculator = false;
    public int maxStackSize;

}
