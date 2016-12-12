using UnityEngine;
using System.Collections;

public class Point_Normal : MonoBehaviour {


	public GameObject prochainePoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider monCollider){

		this.gameObject.SetActive (false);
		prochainePoint.SetActive (true);
	}


}
