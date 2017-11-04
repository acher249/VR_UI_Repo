using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSliderController : MonoBehaviour
{

    Animator anim;

    public GameObject slidePanel;


    public void OnTriggerEnter()
    {
        anim.SetBool("isOpening", true);
    }

    public void OnTriggerExit()
    {
        anim.SetBool("isOpening", false);
    }

    // Use this for initialization
    void Start()
    {

        anim = slidePanel.transform.GetComponent<Animator>();
        //anim = slidePanel.transform.GetComponent<>(); //try to turn off raycast target with script or find someway to make it not raycast hit whenanimates back...

    }

    // Update is called once per frame
    void Update()
    {



    }
}