using UnityEngine;
using System.Collections;

public class Point_debut : MonoBehaviour {


	public Rigidbody balle;
	public GameObject prochainePoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider monCollider){
		
		balle.useGravity = true;
		this.gameObject.SetActive (false);
		prochainePoint.SetActive (true);
	}

}
