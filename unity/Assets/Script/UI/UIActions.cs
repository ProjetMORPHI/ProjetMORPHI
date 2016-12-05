using UnityEngine;
using System.Collections;

public class UIActions : MonoBehaviour {


	public GameObject canvasActif;
	public GameObject canvasSuivant;

	// Use this for initialization
	void Start () {

		Time.timeScale = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void sortirConnecte(){


		canvasActif.SetActive (false);
		canvasSuivant.SetActive (true);

	}

	public void sortir(GameObject canvasaFermer){

		canvasaFermer.SetActive (false);
		Time.timeScale = 1;
	}
}
