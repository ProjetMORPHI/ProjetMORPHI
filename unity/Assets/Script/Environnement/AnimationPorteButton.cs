using UnityEngine;
using System.Collections;

public class AnimationPorteButton : MonoBehaviour {

	public Camera monCamera;//contienne la camera qui montre l'animation de overture de la porte
	public int qBouttons;// quantité des bouttons à apuuyez pour ouvrir la porte qui oeuvre la porte
	public bool animPlayed;// est-ce que l'animation a deja joué?

	private Animation monAnimation; //animation jouer quand la porte est ouverte
	private AudioSource sonPorte;


	// Use this for initialization
	void Start () {

		monAnimation = GetComponent<Animation> ();
		sonPorte = GetComponent<AudioSource> ();
		animPlayed = false;

	}

	// Update is called once per frame
	void Update () {

		//Debug.Log (nombreEnnemies);

		if (qBouttons==0 && !animPlayed) {

			monCamera.depth = 2;//change le depth de la camera pour change la camera
			sonPorte.Play();
			monAnimation.Play ();//joeur l'animation
			animPlayed = true;//L'animation est deja joué
		}
		if (!monAnimation.isPlaying) {

			monCamera.depth = 0;// si l'animation a deja fini, ont retour cache la camera de la porte
		}

	}
}
