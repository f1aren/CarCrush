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

}