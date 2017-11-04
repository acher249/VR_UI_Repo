using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This script is when clicking X button moves the menu/canvas from in front of the camera to the spawn point outside of the sphere...

public class ToggleObjects : MonoBehaviour {

    //public GameObject Enable_Disable;

    public GameObject menu;
    public GameObject OrigSpawnLoc;

    public void HitXButton()
    {
        Vector3 newPos = new Vector3(OrigSpawnLoc.transform.position.x, OrigSpawnLoc.transform.position.y, OrigSpawnLoc.transform.position.z);
        menu.transform.position = newPos;
        Debug.Log("X is being clicked!!");
    }

}
    
    
        
    


