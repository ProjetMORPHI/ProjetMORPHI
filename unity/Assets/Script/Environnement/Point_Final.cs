using UnityEngine;
using System.Collections;
using System.Reflection;

public class Point_Final : MonoBehaviour {

	public GameObject trappe;
	public Sprite pointOk;//sprite quand tout les points sont touchés avec succes
	public SpriteRenderer pointImage; //Le component SpriteRenderer du Pointer 10


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnTriggerEnter(Collider monCollider){

		this.gameObject.SetActive (false);
		trappe.SetActive (false);
		pointImage.sprite = pointOk;

	}


}
