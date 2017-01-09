using UnityEngine;
using System.Collections;

public class ennemiNoire : MonoBehaviour {

    private float posX; // la position initial sur l'axe x de fantome

    private float posMax;  //la limite maximum que fantôme peut se déplacer 
    private float posMin; //la limite minimum que fantôme peut se déplacer 

    private float unitMax = 0.0f; // La variable pour calculer la position maximum de fantôme 
    private float unitMin = 0.0f; // La variable pour calculer la position minimum de fantôme 

    private bool positionPositiveX = true;

    // Use this for initialization
    void Start()
    {

        posX = this.transform.position.x; // prendre la position initial sur l'axe x de fantome
        posMax = Random.Range(1.0f, 2.0f); //la limite maximum que fantôme peut se déplacer 
        posMin = posMax* -1;//la limite minimum que fantôme peut se déplacer 


    }

    // Update is called once per frame
    void Update()
    {

        Vector3 scaAux = transform.localScale;
        if (positionPositiveX == true) // la condition pour ajouter à la position x de fantôme 
        {
            posX += Time.deltaTime/4;
            unitMax += Time.deltaTime;

            scaAux.x = 0.2977584f;
            transform.localScale = scaAux;

            if (unitMax >= posMax)
            {
                positionPositiveX = false;
                unitMax = 0;
            }

        }
        if (positionPositiveX == false) //la condition pour diminuer de la position x de fantôme
        {
            posX -= Time.deltaTime/4;
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
