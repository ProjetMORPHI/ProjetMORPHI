using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionRayonElectrique : MonoBehaviour {

	public GameObject HandleVie;// Handle pour le controle de la bar de vie
	public float dommageEnnemie;//la quantité de dommage fait par le rayon

	private Vector3 enemieForce;//force aplique par le rayon electrique s'il touche le personnage

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision monCollision)
	{

		GestionEtat joueurEtat = monCollision.gameObject.GetComponent<GestionEtat>();
		enemieForce.Set(0,(monCollision.contacts [0].normal.y) * -5,0);// on obtienne la force à appliquer selon la normal du point de contact
		monCollision.rigidbody.AddForce(enemieForce,ForceMode.Impulse);//on applique un force de 5 par rapport à la normal du point de contacte de la collision
		if (HandleVie.activeSelf == false) {//si le jouer a tout ce energie au complet

			HandleVie.SetActive (true);//activation de handle pour simuler la premiere touche
			GameObject vie = GameObject.FindGameObjectWithTag("BarVie") as GameObject;
			Scrollbar barVie = vie.GetComponent<Scrollbar> ();
			barVie.size = barVie.size + dommageEnnemie;
		} 
		else 
		{//si le joueur a deja de dommage on va ajouter plus de dommage
			GameObject vie = GameObject.FindGameObjectWithTag("BarVie") as GameObject;
			Scrollbar barVie = vie.GetComponent<Scrollbar> ();
			barVie.size = barVie.size + dommageEnnemie;
		}

	}



}
