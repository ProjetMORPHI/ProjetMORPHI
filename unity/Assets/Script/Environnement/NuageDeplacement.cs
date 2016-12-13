using UnityEngine;
using System.Collections;

public class NuageDeplacement : MonoBehaviour {

	private Vector3 posCible; 	//position où on veut aller
	private Vector3 posInit; 	//position où on est
	private bool deplacable; 	//détermine si le nuage est capable de se déplacer

	public GameObject objCible; //objet qui est à la position où on veut que le nuage aille
	public float tempsMinutes; //Le temps que doit prendre le nuage pour passer à travers le niveau


	// Use this for initialization
	void Start () {
		deplacable = true;
		posInit = transform.position;
		posCible = objCible.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		//Vérifie si la position initiale et la position cible sont pareil et que le nuage est déplaçable. Si c'est le cas le nuage se déplace vers la position cible dans un temps donné
		if(posInit != posCible && deplacable == true)
		{
			this.transform.position = Vector3.MoveTowards (this.transform.position , posCible , Time.deltaTime * tempsMinutes);
		}
	}
}
