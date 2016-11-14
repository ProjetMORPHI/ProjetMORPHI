using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class fantome : MonoBehaviour {

	private float posX; // la position initial sur l'axe x de fantome

	private float posMax=2.0f; //la limite maximum que fantôme peut se déplacer 
	private float posMin=-2.0f;//la limite minimum que fantôme peut se déplacer 

	private float unitMax=0.0f; // La variable pour calculer la position maximum de fantôme 
	private float unitMin=0.0f; // La variable pour calculer la position minimum de fantôme 

	private bool positionPositiveX = true; 

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
    void OnTriggerEnter(Collider col)
    {
        SceneManager.LoadScene("Tutoriel", LoadSceneMode.Single);
       // SceneManager.LoadScene(SceneManager.GetActiveScene());
    }
}
