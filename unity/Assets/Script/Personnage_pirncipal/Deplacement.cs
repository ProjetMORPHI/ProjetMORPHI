﻿using UnityEngine;
using System.Collections;

public class Deplacement : MonoBehaviour {

	public float velLiquide;
	public float velSolide;
	public float velGazeux;
	public float velGazeuxUP;
	public AudioClip sonBonus;
	public AudioClip sonBlesse;

	//Les animator pour liquide et solide
	public Animator animLiquide;
	public Animator animSolide;

	private Rigidbody persoRb;
	private GestionEtat joueurEtat;
	private AudioSource sonPerso;

	// Use this for initialization
	void Start () {

		persoRb = GetComponent<Rigidbody>();
		joueurEtat = gameObject.GetComponent<GestionEtat> ();
		sonPerso = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {


		// determiner la direction du personnage
		Vector3 scaAux = transform.localScale;


		if (Input.GetAxis ("Horizontal") > 0) {

			scaAux.x = 1;
			transform.localScale = scaAux;
		}
		if (Input.GetAxis ("Horizontal") < 0) {

			scaAux.x = -1;
			transform.localScale = scaAux;
		}

		//Condition pour démarer les animation de marche et arrêter animation Idle
		if (Input.GetAxis ("Horizontal") > 0.01f || Input.GetAxis ("Horizontal") < -0.01f) {
			animLiquide.SetBool ("Marche", true);
			animSolide.SetBool ("Marche", true);
		} 
		//Condition pour stopper les animation de marche et commencer animation Idle
		else {
			animLiquide.SetBool ("Marche", false);
			animSolide.SetBool ("Marche", false);
		}


		//fin code direction du personnage

		// deplacement du personnage selon l'état

		Vector3 velAux = persoRb.velocity;//vitesse Horizontal du personnage

		switch (joueurEtat.etatActif) {

		case GestionEtat.Etat.Liquide:
				

			//vitesse de deplacement Horizontal en liquide
			velAux.x = Input.GetAxis ("Horizontal") * velLiquide;
			persoRb.velocity = velAux;
			//Habilité de saut seulement dans le état liquide
			/*if (Input.GetKeyDown ("space")) {

				persoRb.AddForce(Vector3.up*5,ForceMode.Impulse);
			}*/
			persoRb.useGravity = true;
			break;

		case GestionEtat.Etat.Solide:


			//vitesse de deplacement Horizontal en solide
			velAux.x = Input.GetAxis ("Horizontal") * velSolide;
			persoRb.velocity = velAux;
			persoRb.useGravity = true;
			break;

		case GestionEtat.Etat.Gazeux:



			velAux.x = Input.GetAxis ("Horizontal") * velGazeux;
			persoRb.velocity = velAux;
			//Vector3 velAuxUp = persoRb.velocity;



			//vitesse de deplacement Vertical en gazeux
			if (Input.GetAxis ("Vertical") >= 0) {

				/**-------------------Pour augmenter la vitesse à laquelle le gazeux monte---------------------------**/
				Vector3 veloActuel = persoRb.velocity; 
				persoRb.velocity = new Vector3 (veloActuel.x , 1 , veloActuel.z);
				/**--------------------------------------------------------------------------------------------------**/

				persoRb.AddForce(Vector3.up*velGazeuxUP*Time.deltaTime,ForceMode.Impulse);//impulser vers l:haut en état gazeux
				persoRb.useGravity = false;

			}

			else {

				velAux.y = 0;
				persoRb.velocity = velAux;//si la touche flèche bas est appuyé le personnage en état gazeux ne monte plus
			}

			break;


		}
			
	}


	void OnTriggerEnter(Collider monCollider){

		if (monCollider.gameObject.tag == "Bonus") {

			sonPerso.clip = sonBonus;
			sonPerso.Play ();
		}
			
	}

	void OnCollisionEnter(Collision monCollision){

		if (monCollision.gameObject.name == "RayonLaser") 
		{
			sonPerso.clip = sonBlesse;
			sonPerso.Play ();
		}
	}

}

