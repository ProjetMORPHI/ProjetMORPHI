using UnityEngine;
using System.Collections;

public class AnimationPorteButton : MonoBehaviour {

	public Camera monCamera;//contienne la camera qui montre l'animation de overture de la porte
	public int qBouttons;// quantité des bouttons à apuuyez pour ouvrir la porte qui oeuvre la porte

	private Animation monAnimation; //animation jouer quand la porte est ouverte
	private bool animPlayed;// est-ce que l'animation a deja joué?

	// Use this for initialization
	void Start () {

		monAnimation = GetComponent<Animation> ();
		animPlayed = false;

	}

	// Update is called once per frame
	void Update () {

		//Debug.Log (nombreEnnemies);

		if (qBouttons==0 && !animPlayed) {

			monCamera.depth = 2;//change le depth de la camera pour change la camera
			monAnimation.Play ();//joeur l'animation
			animPlayed = true;//L'animation est deja joué
		}
		if (!monAnimation.isPlaying) {

			monCamera.depth = 0;// si l'animation a deja fini, ont retour cache la camera de la porte
		}

	}
}
