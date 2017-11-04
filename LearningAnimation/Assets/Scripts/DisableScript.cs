using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScript : MonoBehaviour {

	// Use this for initialization


	public void Disable () {

        GameObject scriptOff = GameObject.FindWithTag("Menu");
        scriptOff.GetComponent<MeshRender>().enabled = false;

       

    }
}
