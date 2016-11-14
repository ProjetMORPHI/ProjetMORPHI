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

			grilleCollider.enabled = false;
		}

		else {

			grilleCollider.enabled = true;
		}

	
	}
}
