using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bouton_Simple : MonoBehaviour {

	//Ce script et pour une navigation simple dans le menu

	// Use this for initialization
	void Start () {
	
	}
		
	
	// Update is called once per frame
	void Update () {
	
	}


	//envoie à la scène dont le nom est spécifié
	public void ChargeSceneParNom(string nomScene)
	{

		SceneManager.LoadScene (nomScene); 

	}


}
