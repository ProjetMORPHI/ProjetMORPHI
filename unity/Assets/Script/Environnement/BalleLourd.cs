using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Runtime.ConstrainedExecution;
using System.Reflection.Emit;

public class BalleLourd : MonoBehaviour {

	// Use this for initialization
	public float velBalle; // velocité de la balle

	private bool rouler; //Est-ce que la balle doir commencer à rouler?
	private Rigidbody balleRbd;

	void Start () {

		rouler = false;
		balleRbd = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.right * Time.deltaTime*5);//faire rotate la balle

		if(rouler){

			balleRbd.AddForce(Vector3.right*velBalle*Time.deltaTime,ForceMode.Impulse);//impulser vers l:haut en état gazeux
		}


	}

	void OnTriggerEnter (Collider monCollider){

		rouler = true;
	}

}
