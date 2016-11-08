using UnityEngine;
using System.Collections;

public class EnnemiDestroy : MonoBehaviour {

	public Animation_Porte_Ennemies scriptAnimPorte;


	private int ennemiesRestant;
	// Use this for initialization
	void Start () {
	
		//ennemiesRestant = scriptAnimPorte.nombreEnnemies;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void destroyEnnemi(){


		//Debug.Log (scriptAnimPorte.nombreEnnemies);
		//scriptAnimPorte.nombreEnnemies = scriptAnimPorte.nombreEnnemies--;
		ennemiesRestant = scriptAnimPorte.nombreEnnemies;
		ennemiesRestant--;
		scriptAnimPorte.nombreEnnemies = ennemiesRestant;
		//Debug.Log (scriptAnimPorte.nombreEnnemies);
		Destroy(this.transform.parent.gameObject);//une fois que l'animation est fini on detruit l'ennemi
	}

}
