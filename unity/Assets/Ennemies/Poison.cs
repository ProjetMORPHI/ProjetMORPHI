using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Poison : MonoBehaviour {

	public GameObject HandleVie;// Handle pour le controle de la bar de vie


	private float dommagePoison;
	// Use this for initialization
	void Start () {

		dommagePoison = 1.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider monCollider) {

		if (HandleVie.activeSelf == false) {//si le jouer a tout ce energie au complet

			HandleVie.SetActive (true);//activation de handle pour simuler la premiere touche
			GameObject vie = GameObject.FindGameObjectWithTag("BarVie") as GameObject;
			Scrollbar barVie = vie.GetComponent<Scrollbar> ();
			barVie.size = barVie.size + dommagePoison;
		} 
		else 
		{//si le joueur a deja de dommage on va ajouter plus de dommage
			GameObject vie = GameObject.FindGameObjectWithTag("BarVie") as GameObject;
			Scrollbar barVie = vie.GetComponent<Scrollbar> ();
			barVie.size = barVie.size + dommagePoison;
		}

	}
}
