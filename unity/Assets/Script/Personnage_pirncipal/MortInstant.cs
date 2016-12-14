using UnityEngine;
using System.Collections;

public class MortInstant : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision collision){

		//quand on toucher une collision 
		if(collision.gameObject.tag == "Mort Instant"){}
			
	}
}
