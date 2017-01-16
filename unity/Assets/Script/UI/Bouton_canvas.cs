using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class Bouton_canvas : MonoBehaviour {



    public GameObject panelReglage;
    private GameObject pausePlayBouton;
    public GameObject panelAid;
    
    public Sprite pauseImage;
    public Sprite playImage;
    private bool paused;
    private bool ReglageIsOn;
    private bool aidIsOn;


    // Use this for initialization
    void Start () {
        pausePlayBouton = GameObject.Find("ButtonPausePlay");
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void buttonPlayPause()
    {

        if (ReglageIsOn != true && aidIsOn != true)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pausePlayBouton.GetComponent<Image>().sprite = playImage;
                paused = true;


            }
            else
            {
                Time.timeScale = 1;
                pausePlayBouton.GetComponent<Image>().sprite = pauseImage;
                paused = false;
            }
        }
    }
    //***************************** Ouvrir et Fermer le paneau reglage*************************************
    public void buttonReglage()
    {
        if(paused != true && aidIsOn != true)
        {
            Time.timeScale = 0;
            panelReglage.SetActive(true);
            ReglageIsOn = true;

        }
        

    }
    public void buttonReglageFermer()
    {
        Time.timeScale = 1;
        panelReglage.SetActive(false);
        ReglageIsOn = false;

    }

    //***************************** Ouvrir et Fermer le paneau aid*************************************
    public void buttonAid()
    {
        if (paused != true && ReglageIsOn != true)
        {
            Time.timeScale = 0;
            panelAid.SetActive(true);
            aidIsOn = true;

        }


    }
    public void buttonAidFermer()
    {
        Time.timeScale = 1;
        panelAid.SetActive(false);
        aidIsOn = false;

    }
}

internal class Button
{
    internal object image;
}