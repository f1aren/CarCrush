using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerDownHandler {
	
	public GameObject car;
	public static float tempForce {get; set;}

	// указывает координаты где произошел тач x и y
	public void OnPointerDown(PointerEventData eventData) {
		//Debug.Log(eventData.position);
	}
	public void OnBeginDrag (PointerEventData eventData) {
		if (Mathf.Abs(eventData.delta.x) > 0) {
			if (eventData.delta.x > 0) {
				car.GetComponent<SpriteRenderer>().color = Color.red;
				//car.transform.Translate(new Vector2(eventData.delta.x, 0) * Time.deltaTime);
				
			} else {
				car.GetComponent<SpriteRenderer>().color = Color.blue;
			}
			tempForce = eventData.delta.x;
			//Debug.Log(eventData.delta.x);
		} 
			
	}

	public void OnDrag(PointerEventData eventData) {
		//throw new NotImplementedException();
	}

}
