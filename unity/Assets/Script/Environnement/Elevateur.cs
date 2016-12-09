using UnityEngine;
using System.Collections;

public class Elevateur : MonoBehaviour {


	public Animation animElev;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider monCollider){
	
		if (monCollider.gameObject.tag == "Joueur") {

			animElev.Play ();//si le collider est touché par le personnage, l'ascenseur monte
		}


	}
}
