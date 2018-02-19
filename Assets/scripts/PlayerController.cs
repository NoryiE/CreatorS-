using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int Health = 100;
    public List<PlayerBase> bases;


	void Start () {
        bases = new List<PlayerBase>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
