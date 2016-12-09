using UnityEngine;
using System.Collections;

public class AnimationPorteButtonFerme : MonoBehaviour {

	public float tempOverture; //combien du temp la porte restera ouverte (temp en secondes)
	public bool porteOuverte;
	public string tagButton;
	public Animation animButton;//component animation du button liée cette porte
	public Material buttonBasini;//texture quand le button revien dans l'état initiale
	public MeshRenderer buttonBas;//Mesh renderer component du game object button bas



	private float tempReference;
	private AnimationState animActuelle;
	private Animation monAnimation; //animation jouer quand la porte est ouverte (component Animation de la porte)
	private AnimationPorteButton porte;

	// Use this for initialization
	void Start () {

		monAnimation = GetComponent<Animation> ();
		porte = GetComponent<AnimationPorteButton> ();
		porteOuverte = false;
		tempReference = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (monAnimation.clip);
		//Debug.Log(monAnimation["Porte_Ferme"]);

		if (porteOuverte) {

			if (tempReference > tempOverture) {

				animActuelle = monAnimation ["Porte_Ferme"];
				monAnimation.clip = animActuelle.clip;
				monAnimation.Play ();
				porteOuverte = false;
				tempReference = 0;
			}
			tempReference = tempReference + Time.deltaTime; // ajoute un seconde au temp de référence

		}
	
	}

	public void reinitaliseButton()
	{

		animActuelle = monAnimation ["Porte_Ouverte"];//recupere le AnimationState de la porte
		monAnimation.clip = animActuelle.clip;//mettre le clip de ouverture de porte pour la prochaine fois que le button est appuyé
		int buttonApp = porte.qBouttons;//actualise la quantité des boutton a appuyer pour re-ouvrir la porte temporisé
		buttonApp ++;//indique que il a un button moins à appuyer
		porte.qBouttons = buttonApp; // envoi le nouveau valeur au scriptd de animation de la porte
		porte.animPlayed = false;//l'état de animation d'overture doit se reinitialiser



		GameObject button = GameObject.FindGameObjectWithTag(tagButton);//aller chcerche le objet button au complete
		GameObject objetSmash = button.transform.GetChild(2).gameObject;//obtienne le collider du button pour les desactiver
		Collider smashColl = objetSmash.GetComponent<Collider> ();
		smashColl.enabled = true;//activer le collider du boutton pour être capable de le re-appuyer

		animActuelle = animButton ["Button_up"];//Gerer les animations et les textures pour re initialiser le boutton
		animButton.clip = animActuelle.clip;
		animButton.Play ();
		animActuelle = animButton ["Button"];
		animButton.clip = animActuelle.clip;//mettre le clip de appuyer le boutton la prochaine fois que il est appuyé

		buttonBas.material = buttonBasini;//change la texture du bas du button

	}
}
