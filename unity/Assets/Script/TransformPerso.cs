using UnityEngine;
using System.Collections;

public class TransformPerso : MonoBehaviour {

	//Chaque sprite d'état contenue dans le game objec du personnage
	public GameObject spriteLiquide;
	public GameObject spriteSolide;
	public GameObject spriteGazeux;
	private GestionEtat joueurEtat;

	// Use this for initialization
	void Start () {
		joueurEtat = gameObject.GetComponent<GestionEtat> ();
	}
	
	// Update is called once per frame
	void Update () {


		switch (joueurEtat.etatActif) {
			case GestionEtat.Etat.Liquide:
					spriteLiquide.SetActive(true);
					spriteSolide.SetActive(false);
					spriteGazeux.SetActive(false);
					break;

			case GestionEtat.Etat.Solide:
					spriteLiquide.SetActive(false);
					spriteSolide.SetActive(true);
					spriteGazeux.SetActive(false);
					break;

			case GestionEtat.Etat.Gazeux:
					spriteLiquide.SetActive(false);
					spriteSolide.SetActive(false);
					spriteGazeux.SetActive(true);
					break;
		}


	}
		
}