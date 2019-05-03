using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Buttons : MonoBehaviour {

	public TextMeshProUGUI ScoreTextForPause;
	private float defaultSpeedOfBlocks;
	public GameObject PauseMenu;
	// Use this for initialization
	void Start () {
		//PauseMenu = GameObject.FindGameObjectWithTag("PauseMenu");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKeyDown(KeyCode.Escape)) {
				Application.Quit(); 
			}
		}
	}

	public void PauseLevel () {
		if (!SpawnBarriers.isGameOver) {
			ScoreTextForPause.SetText(CarScript.passedBarriers.ToString()); // очки последней игры
			Time.timeScale = 0;
			defaultSpeedOfBlocks = BlocksBehaviour.speed; // сохранение скорости блоков
			BlocksBehaviour.speed = 0; // скорость блоков
			SpawnBarriers.isGameOver = true;
			PauseMenu.gameObject.SetActive(true); // показывает меню паузы игры 
			CarScript.SteeringWheel.gameObject.SetActive(false);  // скрывает руль
		}
	}

	public void ResumeLevel () {
		Time.timeScale = 1;
		BlocksBehaviour.speed = defaultSpeedOfBlocks;
		SpawnBarriers.isGameOver = false;
		PauseMenu.gameObject.SetActive(false); // показывает меню паузы игры 
		CarScript.SteeringWheel.gameObject.SetActive(true);  // показывает руль
		//StartCoroutine(SpawnBlocks());
	}

	public void RestartLevel () {
        Debug.Log("Restart");
        CarScript.passedBarriers = 0;
        Time.timeScale = 1;
        //Application.LoadLevel("Main");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SpawnBarriers.isGameOver = false;
        CarScript.GameOverMenu.gameObject.SetActive(false);
        //CarScript.Car.gameObject.SetActive(true);
        CarScript.SteeringWheel.gameObject.SetActive(true);
        CarScript.Car.transform.position = CarScript.startPos; // устанавливает машину в стартовую позицию
    }

	public void Exit () {
		Application.Quit();
	}
}
