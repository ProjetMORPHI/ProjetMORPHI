using UnityEngine;
using System.Collections;

public class tutoriel : MonoBehaviour {
		public GameObject intro;
		public GameObject tutoSolide;
		public GameObject tutoLiquide;
		public GameObject tutoGazeux;
		// Use this for initialization
		void Start () {
			intro.gameObject.SetActive (true);
			tutoSolide.gameObject.SetActive (false);
			tutoLiquide.gameObject.SetActive (false);
			tutoGazeux.gameObject.SetActive (false);
			Time.timeScale = 0;
		}

		void OnTriggerEnter(Collider other ){
			if (other.gameObject.name == "Solide") {
				tutoSolide.gameObject.SetActive (true);
				Time.timeScale = 0;
			}
			else if (other.gameObject.name == "Liquide") {
				tutoLiquide.gameObject.SetActive (true);
				Time.timeScale = 0;
			}
			else if (other.gameObject.name == "Gazeux") {
				tutoGazeux.gameObject.SetActive (true);
				Time.timeScale = 0;
			}
		}

		public void cachePanneau () {
			intro.gameObject.SetActive (false);
			tutoSolide.gameObject.SetActive (false);
			tutoLiquide.gameObject.SetActive (false);
			tutoGazeux.gameObject.SetActive (false);
			Time.timeScale = 1;
		}

}
