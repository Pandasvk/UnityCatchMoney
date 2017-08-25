using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	// X range -2.1 - 2.1
	// Y 3 
	// gravity custom asi ...
	public GameObject [] spawnable;
	public float spawnRate=10;
	private float nextSpawnTime;
	float Score = 0;
	float HP = 3;
	public Text skore;
	public Text health;
	// Use this for initialization
	void Start () {
		nextSpawnTime = Time.time + spawnRate;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= nextSpawnTime) {
			spawn ();
			//Debug.Log ("spawn");
			nextSpawnTime = Time.time + spawnRate;
		}


	}

	void spawn(){
		Vector3 spawnPosition;
		spawnPosition.x = Random.Range (-2.1f, 2.1f);
		spawnPosition.y = 3f;
		spawnPosition.z = -7.5f;

		int objectToSpawn = Random.Range (0, spawnable.Length);
		GameObject spawnObject = Instantiate (spawnable [objectToSpawn], spawnPosition, transform.rotation) as GameObject;

	}

	public void IncreaseScore(){
		Score++;
		skore.text = "Score :"+Score;

	}

	public void DecreaseHp(){
		HP--;
		if (HP <= 0) {
			SceneManager.LoadScene ("Level1");
		}
		health.text = "Health :"+HP;

	}
}
