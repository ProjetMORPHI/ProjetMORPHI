using UnityEngine;
using System.Collections;
using System;

public class Animation_Porte : MonoBehaviour {


	public Camera monCamera;
	public Animation monAnimation;
	public int nombreEnnemies;

	// Use this for initialization
	void Start () {
	
		//ouvrePort = false;
		//animPorte = GetComponent<Animation> ();
		nombreEnnemies = 1;


	}
	
	// Update is called once per frame
	void Update () {


		if (nombreEnnemies == 0) {
			
			if (!monAnimation.isPlaying) {

				monCamera.depth = 0;
				//Debug.Log ("hola");
			}

		}


	}

	void OnTriggerEnter(Collider monCollider){

		if (monCollider.gameObject.tag == "Joueur") {

			monCamera.depth = 2;
			monAnimation.Play ();
		}
			
	}

	public void ennemiTue(){

		nombreEnnemies--;

	}
		
}
