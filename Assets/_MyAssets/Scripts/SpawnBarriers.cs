using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarriers : MonoBehaviour {
    public float timeNewSpawnColumn;
    public GameObject[] barriers = new GameObject[6];
    
    public static bool isGameOver { get; set; }
    public float speedBlocks = 2;

    private int num;

    IEnumerator SpawnBlocks() {
        while (!isGameOver) {
            //Instantiate(Blocks, new Vector3(Random.Range(-2f, 2f), 7, 0), Quaternion.identity);
            if (CarScript.passedBarriers < 5) {
                num = Random.Range(0, barriers.Length - 5);
            } else if (CarScript.passedBarriers > 5 && CarScript.passedBarriers <= 10) {
                num = Random.Range(0, barriers.Length - 3);
            } else if (CarScript.passedBarriers > 10) {
                num = Random.Range(0, barriers.Length - 1);
            }
            if (num == 0) {
                Instantiate(barriers[num], new Vector3(Random.Range(-1.5f, 1.5f), 8f, 0), Quaternion.identity);
            } else if (num == 1 || num == 2 || num == 3) {
                Instantiate(barriers[num], new Vector3(Random.Range(-0.25f, 0.25f), 8f, 0), Quaternion.identity);
            } else if (num == 4 || num == 5) {
                Instantiate(barriers[num], new Vector3(Random.Range(-0.75f, 0.75f), 8f, 0), Quaternion.identity);
            }

            
            //Instantiate(barriers[Random.Range(0, barriers.Length - 1)], new Vector3(0, 7f, 0), Quaternion.identity);
            yield return new WaitForSeconds(timeNewSpawnColumn + Random.Range(0f, 1f));
        }        
    }

    private void Start() {
        BlocksBehaviour.speed = -speedBlocks;
        StartCoroutine(SpawnBlocks());
    }

    void Update () {
		
	}
/* 
    public void GlobalStopCoroutine() {
        StopCoroutine(SpawnBlocks());
    }

    public void GlobalStartCoroutine() {
        StartCoroutine(SpawnBlocks());
    }*/
}
