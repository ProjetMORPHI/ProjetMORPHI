using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinTuto : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider monCollider){

		SceneManager.LoadScene ("Scenes/ecran_fin");


	}
}
