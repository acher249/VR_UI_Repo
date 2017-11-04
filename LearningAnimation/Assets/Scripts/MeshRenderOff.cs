using UnityEngine;
using System.Collections;

public class MeshRenderOff: MonoBehaviour
{
    //Grab all components of Menu
    public BoxCollider MenuBC;
    public GameObject MenuGO;

    public BoxCollider ButtonBC;
    public GameObject ButtonGO;

    public BoxCollider Button2BC;
    public GameObject Button2GO;

    public BoxCollider Button3BC;
    public GameObject Button3GO;

    public BoxCollider ButtonXBC;
    public GameObject ButtonXGO;


    //I want to grab all of the components of the Menu. The background the X... 
    //button and the 3 buttons and get their Box Colliders and theirMeshrenderers and turn them all of when I click the X button.

    // Do I need empty Game object to assign the script to similare to "ToggleObjects" script?.. But dont want to actually disable the gameobject.. just want to 
    //turn off the meshrenderer abnd the boxcollider..


    // Turn all componenets of Menu off
    

    public void Disable()
    {
        MeshRenderer m = MenuGO.GetComponent<MeshRenderer>();
        MeshRenderer b = ButtonGO.GetComponent<MeshRenderer>();
        MeshRenderer b2 = Button2GO.GetComponent<MeshRenderer>();
        MeshRenderer b3 = Button3GO.GetComponent<MeshRenderer>();
        MeshRenderer x = ButtonXGO.GetComponent<MeshRenderer>();
        m.enabled = false;
        b.enabled = false;
        b2.enabled = false;
        b3.enabled = false;
        x.enabled = false;
        MenuBC.enabled = false;
        ButtonBC.enabled = false;
        Button2BC.enabled = false;
        Button3BC.enabled = false;
        ButtonXBC.enabled = false;
    }



}

