using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VerificationVie : MonoBehaviour {

	private Scrollbar barVie;

	// Use this for initialization
	void Start () {

		barVie =  GetComponent<Scrollbar> ();
	}

	// Update is called once per frame
	void Update () {

		if (barVie.size >= 1)
		{

			SceneManager.LoadScene ("Scenes/GameOver");
		}
	}
}
