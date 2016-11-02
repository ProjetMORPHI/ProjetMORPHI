using UnityEngine;
using System.Collections;

public class CollisionGrille : MonoBehaviour {

	//Contiene l'état actuelle de joueur
	private GestionEtat joueurEtat;
	//Contienne les box colliders des grilles dedans la scene
	public BoxCollider[] grilles;

	// Use this for initialization
	void Start () {

		joueurEtat = gameObject.GetComponent<GestionEtat> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (joueurEtat.etatActif != GestionEtat.Etat.Solide) {

			grilles [0].enabled = false;
			grilles [0].enabled = false;
		}

		else {

			grilles [0].enabled = true;
			grilles [0].enabled = true;
		}
		//Debug.Log (joueurEtat.etatActif);
			
	}
}
