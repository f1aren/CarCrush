using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHitScript : MonoBehaviour {
    public GameObject car;
    public float carMoveSpeed = 10f;
    private Vector3 newLerpPosition;
    private float horizontal;
 
    void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		//RaycastHit hit;
		//Debug.DrawRay(transform.position, ray.direction * 10);
		//Debug.DrawLine(ray.origin, (ray.direction - Camera.main.transform.position) * 10 );

		Debug.DrawRay(ray.origin, (ray.direction - Camera.main.transform.position), Color.red);
              
        if (Input.GetMouseButton (0) && !SpawnBarriers.isGameOver) {
            newLerpPosition = Vector3.Lerp(car.transform.position, new Vector3(Mathf.Clamp(ray.origin.x, -1.75f, 1.75f), car.transform.position.y, 0), Time.deltaTime * carMoveSpeed);
            car.transform.position = newLerpPosition;
		}


	}


    //public GameObject[] barriers;
    //public float timeNewSpawnColumn;
    


    /* IEnumerator SpawnBlocks() {
         while (!isGameOver) {
             //Instantiate(Blocks, new Vector3(Random.Range(-2f, 2f), 7, 0), Quaternion.identity);
             int num = Random.Range(0, barriers.Length - 1);
             if (num == 0) {
                 Instantiate(barriers[num], new Vector3(Random.Range(-1.5f, 1.5f), 7f, 0), Quaternion.identity);
             } else if (num == 1 || num == 2 || num == 3) {
                 Instantiate(barriers[num], new Vector3(Random.Range(-0.25f, 0.25f), 7f, 0), Quaternion.identity);
             } else if (num == 4 || num == 5) {
                 Instantiate(barriers[num], new Vector3(Random.Range(-0.75f, 0.75f), 7f, 0), Quaternion.identity);
             }
             //Instantiate(barriers[Random.Range(0, barriers.Length - 1)], new Vector3(0, 7f, 0), Quaternion.identity);
             yield return new WaitForSeconds(timeNewSpawnColumn + Random.Range(0f, 1f));
         }
     }*/

    /*
        private void Start() {
            //StartCoroutine(SpawnBlocks());
        }*/



    // [КАК Я ПОНИМАЮ НА ДАННЫЙ МОМЕНТ] 
    // Если коллайдер объекта на котором висит скрипт соприкасается с другим объектом
    // коллайдером, то срабатывает данная функция
    /* private void OnTriggerEnter2D(Collider2D other) {
         if (other.gameObject.tag == "Border") {
             car.transform.position = new Vector3(other.gameObject.transform.position.x, car.transform.position.y, 0);
         }
     }*/




    //Debug.Log("Ray origin:" + ray.origin);
    //Debug.Log("Ray direction:" + ray.direction);
    //Debug.Log("Cam Main transform:" + Camera.main.transform.position);
    /*if (Physics.Raycast(ray, out hit, Mathf.Infinity)) 	{
            position = hit.point;
    } */



    /*if (Input.GetMouseButtonDown(0)) {
        //car.transform.Translate(new Vector2(Mathf.Clamp(ray.origin.x, -1.81f, 1.81f) * Time.deltaTime, 0));
        car.transform.Translate(new Vector2(ray.origin.x, 0) * Time.deltaTime * carSpeed, Camera.main.transform);
        Debug.Log("Ray Origin X: " + ray.origin.x);
        Debug.Log("Camera.main.transform: " + Camera.main.transform);
    } else*/
}//car.transform.position = new Vector2(Mathf.Clamp(ray.origin.x, -1.81f, 1.81f), car.transform.position.y);
 //car.transform.Translate(new Vector2(ray.origin.x * Time.deltaTime, car.transform.position.y));
 /* 
 if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
     position = hit.point;
 }
 Vector3 direction = position - transform.position;
 float targ_pos = Vector3.Distance (transform.position, position);

 if (targ_pos > 1) {
     transform.Translate (direction * speed, Space.World);
 } */
