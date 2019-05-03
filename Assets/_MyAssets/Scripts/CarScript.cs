using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CarScript : MonoBehaviour {

    //public Text counter;
    public static Vector3 startPos {get; set; } // позиция старта
    public TextMeshProUGUI counter;
    public TextMeshProUGUI FinalScoreText;
    public TextMeshProUGUI RecordScoreText;
    public TextMeshProUGUI RecordStringText;
    public static int passedBarriers { get; set; }
    public static GameObject GameOverMenu { get; set; }
    public static GameObject Car { get; set; }
    public static GameObject SteeringWheel { get; set; }

    public GameObject GameOverUI;


    //public GameObject Car;
    //SpriteRenderer spriteCar;
    //private Camera cam;
    void Start () {
        GameOverMenu = GameOverUI;
        //GameOverMenu = GameObject.Find("GameOverMenu");
        //Instantiate(GameOverMenu, new Vector3(0f, 0f, 0f), Quaternion.identity);
        //GameOverMenu = GameObject.FindGameObjectWithTag("GameOver");
        GameOverMenu.gameObject.SetActive(false);
        Car = GameObject.Find("Car");
        SteeringWheel = GameObject.Find("Steering Wheel");
        startPos = Car.transform.position;
        //spriteCar = gameObject.GetComponent<SpriteRenderer>();
        //cam = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButton(0)) {
			Debug.Log("ЗАЖИМ: " + MainScript.tempForce + "\nMousePos: " + Input.mousePosition);
			transform.Translate(new Vector2(Input.mousePosition.x, 0) * Time.deltaTime);
			
			point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
		*/
		}
    /*if (Input.touchCount > 0) {
        spriteCar.color = Color.red;
    }*/
    /*if (Input.GetMouseButtonDown(0)) {
        spriteCar.color = Color.red;
    } else {
        spriteCar.color = Color.yellow;
    }*/

    /*transform.Translate(new Vector2(MainScript.tempForce, 0) * Time.deltaTime);
    if (MainScript.tempForce > 0) {
        MainScript.tempForce -= Time.deltaTime * 30;
    } 
    Debug.Log(MainScript.tempForce);
    MainScript.tempForce = 0;*/

    
    private void GameOver () {
        Debug.Log("Касание");
        BlocksBehaviour.speed = 0; // скорость блоков
        

        if (PlayerPrefs.GetInt("RecordScore") < passedBarriers) { // рекорд
            RecordStringText.SetText("New Record:");
            PlayerPrefs.SetInt("RecordScore", passedBarriers);
            
        }
        FinalScoreText.SetText(passedBarriers.ToString()); // очки последней игры
        RecordScoreText.SetText(PlayerPrefs.GetInt("RecordScore").ToString());


        SpawnBarriers.isGameOver = true;

        GameOverMenu.gameObject.SetActive(true); // показывает меню конца игры 
        //Car.gameObject.SetActive(false); // скрывает машины
        SteeringWheel.gameObject.SetActive(false);  // скрывает руль
        //Car.transform.position = startPos; // устанавливает машину в стартовую позицию
    }

    // конец игры
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "KillZone") {
            GameOver();
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "CountZone") {
            passedBarriers++;
            counter.SetText(passedBarriers.ToString());
        }
    }
}
