using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changerNiveau : MonoBehaviour {

	public string nomNiveau;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider monCollider){

		if (monCollider.gameObject.tag == "Joueur") {

			SceneManager.LoadScene ("Scenes/" + nomNiveau);

		}
	}

}