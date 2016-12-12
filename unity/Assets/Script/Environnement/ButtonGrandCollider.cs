using UnityEngine;
using System.Collections;

public class ButtonGrandCollider : MonoBehaviour {

	public Animation animButton;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider monCollider){

		if (monCollider.gameObject.name == "BalleLourde") {

			animButton.Play ();//la animation de appuyer le button fonctionne seulement si le personnage est en état solide
		}


	}
}
