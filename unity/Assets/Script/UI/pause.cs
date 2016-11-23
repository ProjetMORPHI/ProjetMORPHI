using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	public GameObject panneauPause;
	private bool controlPause = false;
	// Use this for initialization
	void Start () {
		panneauPause.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (controlPause == false) {
				controlPause = true;
				Debug.Log ("pause");
				panneauPause.gameObject.SetActive (true);
				Time.timeScale = 0;
			} 
			else if (controlPause == true) {
				controlPause = false;
				Debug.Log ("jouer");
				panneauPause.gameObject.SetActive (false);
				Time.timeScale = 1;
			} 

		}

	}
}
