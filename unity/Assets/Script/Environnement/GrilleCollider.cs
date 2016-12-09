using UnityEngine;
using System.Collections;

public class GrilleCollider : MonoBehaviour {


	private BoxCollider grilleCollider;
	// Use this for initialization
	void Start () {

		grilleCollider = GetComponent<BoxCollider> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject personnage = GameObject.FindGameObjectWithTag("Joueur");
		GestionEtat joueurEtat = personnage.GetComponent<GestionEtat>();

		if (joueurEtat.etatActif != GestionEtat.Etat.Solide) {

			grilleCollider.enabled = false;//si le état de personnage est liquide ou gazeux ont desactive les collider des grilles
		}

		else {

			grilleCollider.enabled = true;//si le état de personnage est solide on active les collider des grilles
		}

	
	}
}
