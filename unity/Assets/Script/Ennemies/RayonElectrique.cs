using UnityEngine;
using System.Collections;

public class RayonElectrique : MonoBehaviour {
	
	public float durationLaser;
	public GameObject rayonLaser;

	private float tempReference;
	// Use this for initialization
	void Start () {

		tempReference = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (tempReference > durationLaser) {

			if (rayonLaser.activeSelf == true) {

				rayonLaser.SetActive (false);
			} 
			else {

				rayonLaser.SetActive (true);
			}
			tempReference = 0;
		}
		tempReference = tempReference + Time.deltaTime;

	}
}
