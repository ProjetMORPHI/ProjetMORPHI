﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class boutonAccueil : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	public void ChargeScene (string nomScene){
		SceneManager.LoadScene (nomScene); 

	}
}
