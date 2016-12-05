using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class boutonAccueil : MonoBehaviour {
	
	public Slider slider; 


	// Use this for initialization


	void Start(){
		
		Debug.Log ("debut");

		if (slider) { 
			GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat ("volumeCourrant");
			slider.value = 	GetComponent<AudioSource>().volume;

			Debug.Log ("loader"); 

		}

	}


	public void ChargeScene (string nomScene){
		SceneManager.LoadScene (nomScene); 

	}


	 public void volume(){
		controlVolume(slider.value);

	}
	// le code ci-dessous vient de la video suivante : https://www.youtube.com/watch?v=Fwo-YAnQGy8.
	 void controlVolume(float ctrVolume){		
		GetComponent<AudioSource>().volume = ctrVolume;   
		PlayerPrefs.SetFloat("volumeCourrant", 	GetComponent<AudioSource>().volume);
		Debug.Log ("sauvegarde");
	}

}