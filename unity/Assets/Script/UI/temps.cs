using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// http://answers.unity3d.com/questions/45676/making-a-timer-0000-minutes-and-seconds.html
public class temps : MonoBehaviour {

	public Text tempsText;
    private float minuteur = 00f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        minuteur += Time.deltaTime;




        string minutes = Mathf.Floor(minuteur / 60).ToString("00");
        string seconds = (minuteur % 60).ToString("00");
        tempsText.text = minutes + ":" + seconds;

	}
}
