using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour {


	public GameObject canvasActif;
	public GameObject canvasSuivant;

	// Use this for initialization
	void Start () {

		Scene scene = SceneManager.GetActiveScene ();
		if (scene.name == "Tutoriel" || scene.name == "Niveau2"){
			Time.timeScale = 0;
			Debug.Log ("pause");
		} 

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void sortirConnecte(){


		canvasActif.SetActive (false);
		canvasSuivant.SetActive (true);
		Time.timeScale = 1;

	}

	public void sortir(GameObject canvasaFermer){

		canvasaFermer.SetActive (false);
		Time.timeScale = 1;
	}
}
