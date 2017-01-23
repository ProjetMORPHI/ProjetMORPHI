using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RechargeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.timeSinceLevelLoad > 3) {

			string nomScene;

			//on vérifie si un nom de niveau a été enmagaziné. Si il n'y en a pas on recharge le tutoriel
			if (PlayerPrefs.HasKey ("niveauCourrant")) {

				Debug.Log ("On recharge " + PlayerPrefs.GetString ("niveauCourrant"));
				nomScene = PlayerPrefs.GetString ("niveauCourrant");

			} 

			else 
			{
				Debug.Log ("On recharge la scène par défaut");
				nomScene = "Tutoriel";
			}

			SceneManager.LoadScene (nomScene); 

		}
	}
}
