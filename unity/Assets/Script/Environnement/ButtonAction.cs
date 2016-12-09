using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour {


	public Material buttonBasOk;//texture quand le button est appuyé
	public MeshRenderer buttonBas;//Mesh renderer component du game object button bas

	public string tagButton;//Le tag de button lui meme
	public string tagPorte;//a quelle porte est ce que mon button est lié

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void destroyCollider(){

		GameObject button = GameObject.FindGameObjectWithTag(tagButton);//aller chcerche le objet button au complete
		GameObject objetSmash = button.transform.GetChild(2).gameObject;//obtienne le collider du button pour les desactiver

		Collider smashColl = objetSmash.GetComponent<Collider> ();
		smashColl.enabled = false;//desactiver le collider de boutton pour eviter des bugs


		GameObject porte = GameObject.FindGameObjectWithTag(tagPorte);//obtienne la porte qui est lié à ce button
		AnimationPorteButton scriptAnimPorte = porte.GetComponent<AnimationPorteButton>();
		int buttonApp = scriptAnimPorte.qBouttons;
		buttonApp--;//indique que il a un button moins à appuyer
		scriptAnimPorte.qBouttons = buttonApp; // envoi le nouveau valeur au scriptd de animation de la porte
		buttonBas.material = buttonBasOk;//change la texture dus bas du button

		AnimationPorteButtonFerme scriptAnimPorteFerme = porte.GetComponent<AnimationPorteButtonFerme> ();
		if (scriptAnimPorteFerme != null) {

			scriptAnimPorteFerme.porteOuverte = true;// On verifie si la porte liée doit se fermer

		}


	}
}
