using UnityEngine;
using System.Collections;

public class Tourniquet : MonoBehaviour {

	public GameObject pivot;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 positionPivot = pivot.transform.position;

		//transform.RotateAround(positionPivot,positionPivot.z,45*Time.deltaTime); //fait pivoter le game object de 45 degrés par seconde
	}
}
