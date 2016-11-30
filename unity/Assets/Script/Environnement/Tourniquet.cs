using UnityEngine;
using System.Collections;

public class Tourniquet : MonoBehaviour {

	//le point autour du quel la plateforme tourne
	public GameObject pivot;

	//varialble pour stocker la rotation initiale de la platforme
	private Quaternion rotInitiale;


	// Use this for initialization
	void Start () {
		
		// on stock la rotation initiale de la platforme
		rotInitiale = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {

		// on stock la position du point de piveau sous la forme d'un vector3
		Vector3 positionPivot = pivot.transform.position;

		//on s'assure que la rotation de la platforme reste toujours la même quand elle tourne autour du pivot
		transform.rotation = rotInitiale;

		//fait pivoter la plateforme de 45 degrés par seconde 
		//autour du point de pivot 
		//sur l'axe des Z représenté par Vector3.forward
		transform.RotateAround(positionPivot,Vector3.forward,45*Time.deltaTime);
	}
}
