using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnnemiDestroy : MonoBehaviour {

	//public Animation_Porte_Ennemies scriptAnimPorte;


	private int ennemiesRestant;
	private Vector3 enemieForce;

	public GameObject HandleVie;
	public float dommageEnnemie;
	public string tagPorte;
	// Use this for initialization
	void Start () {

		//ennemiesRestant = scriptAnimPorte.nombreEnnemies;
	}

	// Update is called once per frame
	void Update () {

	}

	public void destroyEnnemi(){

		if (tagPorte!="Aucune")
		{
			GameObject porte = GameObject.FindGameObjectWithTag(tagPorte);
			AnimationPorteEnnemies scriptAnimPorte = porte.GetComponent<AnimationPorteEnnemies>();
			ennemiesRestant = scriptAnimPorte.nombreEnnemies;// on se communique avec le script de la porte pour savoir combien des ennemis il manque à tuer
			ennemiesRestant--; // on dimunue les ennemies en 1
			scriptAnimPorte.nombreEnnemies = ennemiesRestant;//on actualise l'information des ennemies restant dans le script de la porte
		}
		Destroy(this.transform.parent.gameObject);//une fois que l'animation est fini on detruit l'ennemi*/
	}

	void OnCollisionEnter(Collision monCollision){


		// Code pour la coliision avec un enemmie noir
		GestionEtat joueurEtat = monCollision.gameObject.GetComponent<GestionEtat>();

		if(monCollision.gameObject.tag == "Joueur"){//si la collision est avec le personnage principal

			enemieForce.Set((monCollision.contacts [0].normal.x) * -80, (monCollision.contacts [0].normal.y) * -10,0);
			monCollision.rigidbody.AddForce(enemieForce,ForceMode.Impulse);//ajout un force en direction contraire à ce de point de contact

			if (joueurEtat.etatActif != GestionEtat.Etat.Solide) {


				// la bar de vie est fait à partir de un élément de scrollbar
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

	}
}
