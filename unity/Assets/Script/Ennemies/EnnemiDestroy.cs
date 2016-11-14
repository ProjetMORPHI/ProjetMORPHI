using UnityEngine;
using System.Collections;

public class EnnemiDestroy : MonoBehaviour {

	//public Animation_Porte_Ennemies scriptAnimPorte;


	private int ennemiesRestant;
	// Use this for initialization
	void Start () {
	
		//ennemiesRestant = scriptAnimPorte.nombreEnnemies;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void destroyEnnemi(){

       
		GameObject porte = GameObject.FindGameObjectWithTag("Porte1");
		AnimationPorteEnnemies scriptAnimPorte = porte.GetComponent<AnimationPorteEnnemies>();
		ennemiesRestant = scriptAnimPorte.nombreEnnemies;
		ennemiesRestant--;
		scriptAnimPorte.nombreEnnemies = ennemiesRestant;
		Destroy(this.transform.parent.gameObject);//une fois que l'animation est fini on detruit l'ennemi*/
	}

}
