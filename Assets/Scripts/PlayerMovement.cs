using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public GameObject klb ;
	private Vector3 oldKlb;
	private Vector3 zmena;
	public GameManager gm;
	// Use this for initialization
	void Start () {
		oldKlb = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		if (klb) {
			zmena = new Vector3 (klb.transform.position.x - oldKlb.x, 0, 0);
			if (oldKlb.x + zmena.x * 10 <= 3 && oldKlb.x + zmena.x * 10 >= -3) {
				transform.position = oldKlb + zmena * 10;
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Money") {
			Destroy (other.gameObject);
			//score ++
			gm.IncreaseScore();
		}
		if (other.gameObject.tag == "Fine") {
			Destroy (other.gameObject);
			//score --
			gm.DecreaseHp();
		}

	}
}
