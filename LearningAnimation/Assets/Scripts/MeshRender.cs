using UnityEngine;
using System.Collections;

public class MeshRender: MonoBehaviour
{
    public BoxCollider Menu;
    public GameObject Obj;

    // Use this for initialization

    // This turns off the menu and its box colliders at start
    void Start()
    {
        Menu = Menu.GetComponent<BoxCollider>();
        MeshRenderer m = Obj.GetComponent<MeshRenderer>();
        m.enabled = false;
        Menu.enabled = false; //Disable Box Collider
    }

    // Update is called once per frame

        //This says when click of mouse. Turn on Menu and Box Colliders
    public void Update()
    //public void MouseClick()
    {

      
        // we want this be be every mouse button down **(except when clicking other buttons)** Check if Menu Meshrender in turned on, if so.. 
        //don't allow this function to run.. if Menu mesh render is off then this function can run.  
        
        if (Input.GetMouseButtonDown(0))
        {
            MeshRenderer m = Obj.GetComponent<MeshRenderer>();
            m.enabled = true;
            Menu.enabled = true;
            
        }
        
        //Now Menu is back on... need script for when click X button Turn back off. There is a problem with this as it continues to update all that time..

        //Add more clicks??
      
    }
    
}

