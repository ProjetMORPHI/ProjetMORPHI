using UnityEngine;
using System.Collections;

public class RayonElectrique : MonoBehaviour {
	
	public float durationLaser;
	public GameObject rayonLaser;

	private float tempReference;//combien de secondes de duration de rayon electrique (actif et desactivé)
	// Use this for initialization
	void Start () {

		tempReference = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (tempReference > durationLaser) {

			if (rayonLaser.activeSelf == true) {

				rayonLaser.SetActive (false);// desactivé le rayon electrique si c'est actif
			} 
			else {

				rayonLaser.SetActive (true); // activé le rayon electrique si c'est desactivé
			}
			tempReference = 0;
		}
		tempReference = tempReference + Time.deltaTime; // ajoute un seconde au temp de référence

	}
}
