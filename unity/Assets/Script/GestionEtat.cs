using UnityEngine;
using System.Collections;

//Ce script gère l'état du personnage pour tous les autre script

public class GestionEtat : MonoBehaviour {

	//une variable de type énumération contient tous les états
	public enum Etat {Liquide,Solide,Gazeux};

	//Cette variable contient l'état actif
	public Etat etatActif = Etat.Liquide;

	//Variable qui règle la durée de transformation
	public float tempsTransfo = 5.0f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			//Debug.Log("appui 1");
			StartCoroutine(transfoSolide ());
		}

		if(Input.GetKeyDown(KeyCode.Alpha2)){
			//Debug.Log("appui 2");
			StartCoroutine(transfoGazeux ());
		}
	}

	//fonction pour la Transformation temporaire vers l'état solide
	IEnumerator transfoSolide(){
		//Debug.Log ("Transfo solide");
		if (etatActif != Etat.Solide) {
			//on passe à l'état solide
			etatActif = Etat.Solide;

			//après une durée prédéfini on revient à liquide
			yield return new WaitForSeconds(tempsTransfo);

			etatActif = Etat.Liquide;
		}
	}

	//fonction pour la Transformation temporaire vers l'état gazeux
	IEnumerator transfoGazeux(){
		//Debug.Log ("Transfo gazeux");
		//on passe à l'état gazeux
		etatActif = Etat.Gazeux;

		//après une durée prédéfini on revient à liquide
		yield return new WaitForSeconds(tempsTransfo);
		etatActif = Etat.Liquide;
		//}
	}
}