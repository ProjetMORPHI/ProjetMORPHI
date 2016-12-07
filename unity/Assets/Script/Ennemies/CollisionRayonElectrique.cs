using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollisionRayonElectrique : MonoBehaviour {

	public GameObject HandleVie;// Handle pour le controle de la bar de vie
	public float dommageEnnemie;

	private Vector3 enemieForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision monCollision)
	{

		GestionEtat joueurEtat = monCollision.gameObject.GetComponent<GestionEtat>();
		enemieForce.Set(0,(monCollision.contacts [0].normal.y) * -5,0);
		monCollision.rigidbody.AddForce(enemieForce,ForceMode.Impulse);
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
