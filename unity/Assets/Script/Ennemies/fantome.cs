using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fantome : MonoBehaviour {

	private float posX; // la position initial sur l'axe x de fantome

	private float posMax=2.0f; //la limite maximum que fantôme peut se déplacer 
	private float posMin=-2.0f;//la limite minimum que fantôme peut se déplacer 

	private float unitMax=0.0f; // La variable pour calculer la position maximum de fantôme 
	private float unitMin=0.0f; // La variable pour calculer la position minimum de fantôme 

	private Vector3 enemieForce;// La variable pour reculer le personnage quand il touche le fantôme

	private bool positionPositiveX = true; 


	public GameObject HandleVie;// Handle pour le controle de la bar de vie
	public float dommageEnnemie;

	// Use this for initialization
	void Start () {

		posX = this.transform.position.x; // prendre la position initial sur l'axe x de fantome

	}

	// Update is called once per frame
	void Update () {


		if (positionPositiveX == true) // la condition pour ajouter à la position x de fantôme 
		{
			posX += Time.deltaTime;
			unitMax+= Time.deltaTime;

			if (unitMax >= posMax)
			{
				positionPositiveX = false;
				unitMax = 0;
			}

		}
		if (positionPositiveX == false) //la condition pour diminuer de la position x de fantôme
		{
			posX -= Time.deltaTime;
			unitMin-= Time.deltaTime;

			if (unitMin <= posMin)
			{
				positionPositiveX = true;
				unitMin = 0;
			}

		}

		this.transform.position = new Vector3(posX, this.transform.position.y, this.transform.position.z);

	}
	void OnCollisionEnter(Collision monCollision)
	{

		GestionEtat joueurEtat = monCollision.gameObject.GetComponent<GestionEtat>();
		enemieForce.Set((monCollision.contacts [0].normal.x) * -80, (monCollision.contacts [0].normal.y) * -5,0);
		monCollision.rigidbody.AddForce(enemieForce,ForceMode.Impulse);
		if (HandleVie.activeSelf == false) {//si le jouer a tout ce energie au complet

			HandleVie.SetActive (true);//activation de handle pour simuler la premiere touche
			GameObject vie = GameObject.FindGameObjectWithTag("BarVie") as GameObject;
			Scrollbar barVie = vie.GetComponent<Scrollbar> ();
			barVie.size = barVie.size + dommageEnnemie;
		} 
		else 
		{//si le joueur a deja de dommage on va ajouter plus de dommage
			GameObject vie = GameObject.FindGameObjectWithTag("BarVie") as GameObject;
			Scrollbar barVie = vie.GetComponent<Scrollbar> ();
			barVie.size = barVie.size + dommageEnnemie;
		}

	}
}
