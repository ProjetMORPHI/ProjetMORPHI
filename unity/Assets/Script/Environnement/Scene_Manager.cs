using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour {


	// Use this for initialization
	void Start () {

		//Ce script est sur un game object nommé Scene_Manager dans chaque niveau
		//Il détermine quel niveau sera repris si le joueur meurt

		Scene sceneCourrante = SceneManager.GetActiveScene();
		Debug.Log ("Scène courrante est : " + sceneCourrante.name);
		Debug.Log ("Sauvegarde de la scene courrante");
		PlayerPrefs.SetString("niveauCourrant",sceneCourrante.name);
		Debug.Log ("Le niveau à reprendre sera : " + PlayerPrefs.GetString("niveauCourrant"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
