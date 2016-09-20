using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameLogic : MonoBehaviour {

	bool didPlayerwin = false; 
	public Text playerInteraction; 
	public Transform player; 
	public Transform tornado; 

	public Transform cloud1; 
	bool cloud1get = false;

	int count = 0; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Code that sees if you can win or not 
		if (didPlayerwin == true && count == 3) {
			playerInteraction.text = "Let's Go!";
		} else if ((tornado.position - player.position).magnitude < 4f) {
			playerInteraction.text = "Go Up?"; 
		}
		if (Input.GetKey(KeyCode.Space) && count == 3) {
			didPlayerwin = true;
		} else if (Input.GetKey(KeyCode.Space) && count != 3 && ((tornado.position - player.position).magnitude) < 4f){
			playerInteraction.text = "You don't have everyone";
		}
		// Pick up cloud 1 
		if ((cloud1.position - player.position).magnitude < 30f && cloud1get == false){ 
			playerInteraction.text = "Help Me!";
		}
		if ((cloud1.position - player.position).magnitude < 20f && cloud1get == false) {
			playerInteraction.text = "I'm right here!";
		}
		if ((cloud1.position - player.position).magnitude < 10f && cloud1get == false) {
			playerInteraction.text = "Over here!";
		}
		if ((cloud1.position - player.position).magnitude < 3f && cloud1get == false) {
			playerInteraction.text = "Can I come with you?";
		}
		if (((cloud1.position - player.position).magnitude < 3f) && (Input.GetKey(KeyCode.Space))){
			cloud1get = true;
		}
		if (cloud1get == true) {
			cloud1.position = new Vector3((player.position.x - 1f), player.position.y, (player.position.z - 1f));
		}
	}
}
