using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Runtime.ConstrainedExecution;
using System.Reflection.Emit;

public class BalleLourd : MonoBehaviour {

	// Use this for initialization
	public float velBalle; // velocité de la balle
	public Transform init_Pos;
	public GameObject[] lesPoints;
	public GameObject trappe;
	public Sprite point;//sprite quand tout les points sont touchés avec succes
	public SpriteRenderer pointImage; //Le component SpriteRenderer du Pointer 10


	private bool rouler; //Est-ce que la balle doir commencer à rouler?
	private Rigidbody balleRbd;
	private Vector3 velAux;

	void Start () {

		rouler = false;
		balleRbd = GetComponent<Rigidbody> ();
		velAux.Set (0,0,0);
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.right * Time.deltaTime*5);//faire rotate la balle
	}

	void FixedUpdate (){

		if(rouler){

			balleRbd.AddForce(Vector3.right*velBalle*Time.deltaTime,ForceMode.Impulse);//impulser vers l:haut en état gazeux
		}

	}

	void OnTriggerEnter (Collider monCollider){

		if (monCollider.gameObject.name == "DebutBalle") {
			rouler = true;
		}
		if (monCollider.gameObject.name == "FinBalle") {

			rouler = false;
			transform.position = init_Pos.position;
			balleRbd.useGravity = false;
			balleRbd.velocity = velAux;

			lesPoints [0].SetActive (true);
			for (int i = 1; i < lesPoints.Length; i++) {

				lesPoints [i].SetActive (false);
			}
			trappe.SetActive (true);
			pointImage.sprite = point;
		}

	}

}
