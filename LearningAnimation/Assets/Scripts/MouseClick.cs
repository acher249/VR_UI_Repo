using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour
{

    public BoxCollider Menu;
    public GameObject Obj;


    public void OnMouseDown()
    {
        Menu = Menu.GetComponent<BoxCollider>();
        MeshRenderer m = Obj.GetComponent<MeshRenderer>();
        m.enabled = false;
        Menu.enabled = false;

        Debug.Log("Is Clicked!!");
        
    }
}