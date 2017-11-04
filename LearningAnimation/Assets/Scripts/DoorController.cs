using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    Animator anim;


    void OnTriggerEnter(Collider obj)
    {
        anim.SetBool("isOpening", true);
    }

    void OnTriggerExit(Collider obj)
    {
        anim.SetBool("isOpening", false);
    }

    // Use this for initialization
    void Start () {

        anim = this.transform.parent.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		


	}
}
