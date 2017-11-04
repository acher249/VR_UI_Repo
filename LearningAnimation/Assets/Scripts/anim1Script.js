
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
    //if (Input.GetKeyDown(KeyCode.E))    //ANIM1
    {
        animator.enabled = true;
        anim1 = true;
        anim2 = false;
        anim3 = false;
		anim4 = false;
    }

    if(anim1 == true) {
        animator.SetBool("anim1", true);
        animator.SetBool("anim2", false);
        animator.SetBool("anim3", false);
		animator.SetBool("anim4", false);
    }

}
