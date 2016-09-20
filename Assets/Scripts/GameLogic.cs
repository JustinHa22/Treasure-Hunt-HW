﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameLogic : MonoBehaviour {

	bool didPlayerwin = false; 
	public Text playerInteraction; 
	public Transform player; 
	public Transform tornado; 

	public Transform cloud1; 
	bool cloud1get = false;

	public Transform cloud2; 
	bool cloud2get = false; 

	public Transform cloud3;
	bool cloud3get = false; 

	public Transform cloud4; 
	bool cloud4get = false; 

	public Transform cloud5; 
	bool cloud5get = false; 

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
		if ((cloud1.position - player.position).magnitude < 70f && cloud1get == false){ 
			playerInteraction.text = "Help Me!";
		}
		if ((cloud1.position - player.position).magnitude < 50f && cloud1get == false) {
			playerInteraction.text = "I'm right here!";
		}
		if ((cloud1.position - player.position).magnitude < 20f && cloud1get == false) {
			playerInteraction.text = "Over here!";
		}
		if ((cloud1.position - player.position).magnitude < 3f && cloud1get == false) {
			playerInteraction.text = "Can I come with you?";
		}
		if (((cloud1.position - player.position).magnitude < 3f) && (Input.GetKey(KeyCode.Space))){
			cloud1get = true;
			count += 1; 
		}
		if (cloud1get == true) {
			cloud1.position = new Vector3((player.position.x - 1f), player.position.y, (player.position.z - 1f));
		}

		// Pick up cloud 2 
		if ((cloud2.position - player.position).magnitude < 70f && cloud2get == false){ 
			playerInteraction.text = "Help Us!";
		}
		if ((cloud2.position - player.position).magnitude < 50f && cloud2get == false) {
			playerInteraction.text = "We're right here!";
		}
		if ((cloud2.position - player.position).magnitude <20f && cloud2get == false) {
			playerInteraction.text = "Over here!";
		}
		if ((cloud2.position - player.position).magnitude < 3f && cloud2get == false) {
			playerInteraction.text = "Can we come with you?";
		}
		if (((cloud2.position - player.position).magnitude < 3f) && (Input.GetKey(KeyCode.Space))){
			cloud2get = true;
		}
		if (cloud2get == true) {
			cloud2.position = new Vector3((player.position.x + 1.5f), player.position.y, (player.position.z - 1.5f));
			count += 1; 
		}

		// Pick up cloud 3
		if ((cloud3.position - player.position).magnitude < 70f && cloud3get == false){ 
			playerInteraction.text = "Help Me!";
		}
		if ((cloud3.position - player.position).magnitude < 50f && cloud3get == false) {
			playerInteraction.text = "I'm right here!";
		}
		if ((cloud3.position - player.position).magnitude < 30f && cloud3get == false) {
			playerInteraction.text = "Over here!";
		}
		if ((cloud3.position - player.position).magnitude < 3f && cloud3get == false) {
			playerInteraction.text = "Can I come with you?";
		}
		if (((cloud3.position - player.position).magnitude < 3f) && (Input.GetKey(KeyCode.Space))){
			cloud3get = true;
		}
		if (cloud3get == true) {
			cloud3.position = new Vector3((player.position.x + 1f), player.position.y, (player.position.z + 1f));
			count += 1; 
		}

		//Pick up cloud 4
		if ((cloud4.position - player.position).magnitude < 70f && cloud4get == false){ 
			playerInteraction.text = "Help Us!";
		}
		if ((cloud4.position - player.position).magnitude < 50f && cloud4get == false) {
			playerInteraction.text = "We're right here!";
		}
		if ((cloud4.position - player.position).magnitude <20f && cloud4get == false) {
			playerInteraction.text = "Over here!";
		}
		if ((cloud4.position - player.position).magnitude < 3f && cloud4get == false) {
			playerInteraction.text = "Can we come with you?";
		}
		if (((cloud4.position - player.position).magnitude < 3f) && (Input.GetKey(KeyCode.Space))){
			cloud4get = true;
		}
		if (cloud4get == true) {
			cloud4.position = new Vector3((player.position.x + 2f), player.position.y, (player.position.z - 2f));
			count += 1;
		}

		//Pick up cloud 5
		if ((cloud5.position - player.position).magnitude < 70f && cloud5get == false){ 
			playerInteraction.text = "Help Us!";
		}
		if ((cloud5.position - player.position).magnitude < 50f && cloud5get == false) {
			playerInteraction.text = "We're right here!";
		}
		if ((cloud5.position - player.position).magnitude <20f && cloud5get == false) {
			playerInteraction.text = "Over here!";
		}
		if ((cloud5.position - player.position).magnitude < 3f && cloud5get == false) {
			playerInteraction.text = "Can we come with you?";
		}
		if (((cloud5.position - player.position).magnitude < 3f) && (Input.GetKey(KeyCode.Space))){
			cloud5get = true;
		}
		if (cloud5get == true) {
			cloud5.position = new Vector3((player.position.x + -1.75f), player.position.y, (player.position.z - 1.75f));
			count += 1;
		}
	}
}
