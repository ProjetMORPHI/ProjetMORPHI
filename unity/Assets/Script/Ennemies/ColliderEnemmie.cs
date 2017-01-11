using UnityEngine;
using System.Collections;

public class ColliderEnemmie : MonoBehaviour {


	public Animation animEnnemie;

	//public GestionEtat joueurEtat;
   
	private AudioSource sonTuer;
	// Use this for initialization
	void Start () {
		
		sonTuer = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter(Collider monCollider){

        GestionEtat joueurEtat = monCollider.GetComponent<GestionEtat>();
		if (monCollider.gameObject.tag == "Joueur" && joueurEtat.etatActif == GestionEtat.Etat.Solide) {

			sonTuer.Play ();
			animEnnemie.Play ();//on joue l'animnation pour applatir l'ennemie si lecollider est touché en état solide

		}

			
	}

}
