using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class avertissementGaz : MonoBehaviour {

	// Use this for initialization
	public GameObject canvasAvertissement;

	void Start () {

		Scene scene = SceneManager.GetActiveScene ();

		if (scene.name == "Niveau2"){
			Time.timeScale = 0;
			Debug.Log ("pause");
		} 

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void cacheAvertissement(){


		canvasAvertissement.SetActive (false);
		Time.timeScale = 1;

	}
}
