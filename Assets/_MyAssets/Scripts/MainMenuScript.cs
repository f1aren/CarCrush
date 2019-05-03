using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKeyDown(KeyCode.Escape)) {
				Application.Quit(); 
			}
		}
	}

    public void PlayGame () {
        SceneManager.LoadScene("main");
    }

    public void ExitGame () {
        Application.Quit();
    }
}
