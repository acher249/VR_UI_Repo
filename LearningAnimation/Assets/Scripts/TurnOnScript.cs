using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnScript : MonoBehaviour {

	
	// Update is called once per frame
	public void MouseClick () {

        GameObject script = GameObject.FindWithTag("Canvas");
        script.GetComponent<SpawnMenu>().enabled = true;//turning on SpawnMenu script so that it starts updating
        Debug.Log("SHOULD TURN ON SPAWN MENU SCRIPT");

    }
}
