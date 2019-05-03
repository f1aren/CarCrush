using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningLight : MonoBehaviour {

	// Use this for initialization
	//public float timeSecForWarningLight = 1;
	public float TimerForLightOff;
	public float TimerForLightOn;
	bool isLightOn;
	private Light lightComponent;
	private float generalTimer;
	/* IEnumerator WarningLightOn() {
		while (!SpawnBarriers.isGameOver) {
			//lightComponent.enabled = false;
			//gameObject.SetActive(false);
		}
		yield return new WaitForSeconds(1f);
	}*/
	void Start () {
		lightComponent = GetComponent<Light>();
		lightComponent.enabled = isLightOn = true;
		//InvokeRepeating("LightManagment", 0, isLightOn ? TimerForLightOff : TimerForLightOn);
		//StartCoroutine(WarningLightOn());
	}
	
	// Update is called once per frame
	void Update () {
		if (generalTimer != 0) 
			generalTimer -= Time.deltaTime;

		if (generalTimer < 0) 
			generalTimer = 0;

		if (generalTimer == 0 && isLightOn) {
			LightIsOff();
			generalTimer = TimerForLightOff;
		} else if (generalTimer == 0 && !isLightOn) { 
			LightIsOn();
			generalTimer = TimerForLightOn;
		}
		//lightComponent.enabled = true;
		//gameObject.SetActive(true);
		/*if (isLightOn) {
			Invoke("LightIsOff", TimerForLightOff);
		} else {
			Invoke("LightIsOn", TimerForLightOn);
		}*/
		//Invoke("LightManagment", isLightOn ? TimerForLightOff : TimerForLightOn);
	}

	void LightIsOn () {
		lightComponent.enabled = isLightOn = true;
	}

	void LightIsOff () {
		lightComponent.enabled = isLightOn = false;
	}

	void LightManagment () {
		if (isLightOn)
			lightComponent.enabled = isLightOn = false;
		else 
			lightComponent.enabled = isLightOn = true;
	}
}
