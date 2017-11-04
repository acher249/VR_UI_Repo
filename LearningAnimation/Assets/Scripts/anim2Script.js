
var animator : Animator;
var anim1 : boolean;
var anim2 : boolean;
var anim3 : boolean;
var anim4 : boolean;


function Start () {
    animator.enabled = false;
    anim1 = false;
    anim2 = false;
    anim3 = false;
	anim4 = false;
}


function OnTriggerEnter (col : Collider) {
//function Update () {

	if(col.gameObject.tag == "Player")
    //if (Input.GetKeyDown(KeyCode.R)){   //ANIM2  
	{
        animator.enabled = true;
        anim2 = true;
        anim1 = false;
        anim3 = false;
		anim4 = false;
    }

    if(anim2 == true) {
        animator.SetBool("anim2", true);
        animator.SetBool("anim1", false);
        animator.SetBool("anim3", false);
		animator.SetBool("anim4", false);
    }
}




