using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenu : MonoBehaviour {

    public Transform[] spawnLocation;
    public GameObject[] menuObject;
    public GameObject[] menuClone;

    public GameObject menu;
    public GameObject spawnLoc;


    //figure out how to make menu not keep appearing...
    public void Update()

        
    {
      if (Input.GetMouseButtonDown(0))
        {

            GameObject script1 = GameObject.FindWithTag("Canvas");
            script1.GetComponent<SpawnMenu>().enabled = true;//turning on SpawnMenu script so that it starts updating
            Debug.Log("SHOULD TURN ON SPAWN MENU SCRIPT");


            //menu.SetActive(true);
            Vector3 newPos = new Vector3(spawnLoc.transform.position.x, spawnLoc.transform.position.y, spawnLoc.transform.position.z);
            menu.transform.position = newPos;

            GameObject script2 = GameObject.FindWithTag("Canvas");
            script2.GetComponent<SpawnMenu>().enabled = false;//turning off SpawnMenu script so that it stops updating
            Debug.Log("SHOULD TURN OFF SPAWN MENU SCRIPT");
       
        }  
    }

    public void MouseExitXButton()//not letting you drop another menu on top of itself if you are over the original Menu..
    {
        GameObject script3 = GameObject.FindWithTag("Canvas");
        script3.GetComponent<SpawnMenu>().enabled = true;//turning on SpawnMenu script so that it starts updating
        Debug.Log("SHOULD TURN ON SPAWN MENU SCRIPT");
    }

    public void MouseEnterXButton()
    {
        GameObject script3 = GameObject.FindWithTag("Canvas");
        script3.GetComponent<SpawnMenu>().enabled = false;//turning off SpawnMenu script so that it starts updating
        Debug.Log("SHOULD TURN ON SPAWN MENU SCRIPT");
    }

}
