using UnityEngine;
using System.Collections;

public class AnimationPorteButton : MonoBehaviour {

	public Camera monCamera;
	public bool buttonOK;


	private Animation monAnimation;
	private bool animPlayed;

	// Use this for initialization
	void Start () {

		//ouvrePort = false;
		monAnimation = GetComponent<Animation> ();
		animPlayed = false;
		buttonOK = false;

	}

	// Update is called once per frame
	void Update () {

		//Debug.Log (nombreEnnemies);

		if (buttonOK && !animPlayed) {

			monCamera.depth = 2;
			monAnimation.Play ();
			animPlayed = true;
		}
		if (!monAnimation.isPlaying) {

			monCamera.depth = 0;
		}

	}
}
