using UnityEngine;
using System.Collections;

public class SonTemporisateur : MonoBehaviour {

	private MeshRenderer meshRenBas;
	private AudioSource tictocSon;

	// Use this for initialization
	void Start () {

		meshRenBas = GetComponent<MeshRenderer> ();
		tictocSon = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (meshRenBas.material.name);
		if (meshRenBas.material.name == "Button_bas_ok (Instance)") {

			tictocSon.enabled = true;
		}
		else {

			tictocSon.enabled = false;
		}

	}
}
