﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    //CLIENTSIDE + SERVERSIDE

    public virtual void WhileHoldingItem(PlayerController player)
    {

    }

    public virtual void OnStopHoldingItem(PlayerController player)
    {

    }

    public virtual void OnKeyPressed(PlayerController player) 
    {
        
    }
}
