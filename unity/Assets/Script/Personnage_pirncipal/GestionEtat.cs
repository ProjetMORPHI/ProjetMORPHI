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

	//Variable qui contienne le clip de son de transformation
	public AudioClip clipTransf;


	private AudioSource sonPerso;
	// Use this for initialization
	void Start () {

		sonPerso = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			/*StopCoroutine("transfoSolide");
			//Debug.Log("appui 1");
			//StartCoroutine(transfoSolide ());
			StartCoroutine("transfoSolide");*/
			if(etatActif != Etat.Liquide){

				sonPerso.clip = clipTransf;
				sonPerso.Play ();
			}
			transfoLiquide ();
		}

		if(Input.GetKeyDown(KeyCode.Alpha2)){
			/*StopCoroutine("transfoGazeux");
			//Debug.Log("appui 2");
			//StartCoroutine(transfoGazeux ());
			//StartCoroutine("transfoGazeux");*/
			if(etatActif != Etat.Solide){

				sonPerso.clip = clipTransf;
				sonPerso.Play ();
			}
			transfoSolide();

		}

		if(Input.GetKeyDown(KeyCode.Alpha3)){
			/*StopCoroutine("transfoGazeux");
			//Debug.Log("appui 2");
			//StartCoroutine(transfoGazeux ());
			StartCoroutine("transfoGazeux");*/
			if(etatActif != Etat.Gazeux){

				sonPerso.clip = clipTransf;
				sonPerso.Play ();
			}
			transfoGazeux();

		}
	}

	//fonction pour la Transformation temporaire vers l'état solide
	void transfoSolide(){

		//Debug.Log ("Transfo solide");

		if (etatActif != Etat.Solide) {
			
			//on passe à l'état solide
			etatActif = Etat.Solide;
		}
	}



	//fonction pour la Transformation temporaire vers l'état gazeux
	void transfoGazeux(){
		
		if (etatActif != Etat.Gazeux) {

			//on passe à l'état gazeux
			etatActif = Etat.Gazeux;
		}
	}

	//fonction pour la Transformation temporaire vers l'état liquide
	void transfoLiquide(){

		if (etatActif != Etat.Liquide) {

			//on passe à l'état liquide
			etatActif = Etat.Liquide;
		}
	}

	//fonction avec temps
	//IEnumerator transfoSolide(){


		/*if (etatActif != Etat.Solide) {
			//on passe à l'état solide
			etatActif = Etat.Solide;

			//après une durée prédéfini on revient à liquide
			yield return new WaitForSeconds(tempsTransfo);

			etatActif = Etat.Liquide;
		}
	}*/



	//fonction pour la Transformation temporaire vers l'état gazeux
	/*IEnumerator transfoGazeux(){
		//Debug.Log ("Transfo gazeux");
		//on passe à l'état gazeux
		etatActif = Etat.Gazeux;

		//après une durée prédéfini on revient à liquide
		yield return new WaitForSeconds(tempsTransfo);
		etatActif = Etat.Liquide;
		//}
	}*/
}
