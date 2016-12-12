using UnityEngine;
using System.Collections;

public class EnnemiFeu : MonoBehaviour {

    private float posX; // la position initial sur l'axe x de fantome

    private float posMax;  //la limite maximum que il peut se déplacer 
    private float posMin; //la limite minimum que il peut se déplacer 

    private float unitMax = 0.0f; // La variable pour calculer la position maximum 
    private float unitMin = 0.0f; // La variable pour calculer la position minimum 
                                                                                   
    private bool positionPositiveX = true;

    // Use this for initialization
    void Start()
    {

        posX = this.transform.position.x; // prendre la position initial sur l'axe x 
        posMax = Random.Range(1.0f, 12.0f); //la limite maximum que il peut se déplacer 
        posMin = posMax * -1;//la limite minimum que il peut se déplacer 


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 scaAux = transform.localScale;
        if (positionPositiveX == true) // la condition pour ajouter à la position x
        {
            posX += Time.deltaTime / 4;
            unitMax += Time.deltaTime;

            scaAux.x = 0.2977584f;
            transform.localScale = scaAux;

            if (unitMax >= posMax)
            {
                positionPositiveX = false;
                unitMax = 0;
            }

        }
        if (positionPositiveX == false) //la condition pour diminuer de la position x
        {
            posX -= Time.deltaTime / 4;
            unitMin -= Time.deltaTime;

            scaAux.x = -0.2977584f;
            transform.localScale = scaAux;

            if (unitMin <= posMin)
            {
                positionPositiveX = true;
                unitMin = 0;
            }

        }

        this.transform.position = new Vector3(posX, this.transform.position.y, this.transform.position.z);

    }
}
