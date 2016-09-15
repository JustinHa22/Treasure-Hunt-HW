using UnityEngine;
using System.Collections;

public class PlayerMovement: MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		// Move player forward
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(0f, 0f, 10f * Time.deltaTime); 
		}
		// Move player back 
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(0f, 0f, -10f * Time.deltaTime);
		}
		// Turn player to the right 
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.eulerAngles += new Vector3 (0f, 90f, 0f);
		}
		// Turn player left 
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.eulerAngles += new Vector3 (0f, -90f, 0f);
		}
		// Have camera follow the player 
		Camera.main.transform.position = transform.position + new Vector3 (0f,5f,-5f); 
	}
}
