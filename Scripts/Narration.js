#pragma strict

var Narrative : AudioClip;


function OnTriggerEnter2D () {
GetComponent.<AudioSource>().Stop();
GetComponent.<AudioSource>().PlayOneShot(Narrative);
yield WaitForSeconds (GetComponent.<AudioSource>().clip.length);
Destroy(this.gameObject);

}