using UnityEngine;
using System.Collections;

public class DeclencheurCanvas : MonoBehaviour {


	public GameObject canvasaActiver;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider monCollider){

		canvasaActiver.SetActive (true);
		Time.timeScale = 0;
	}
}
