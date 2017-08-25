using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDestroyer : MonoBehaviour {
	float y;
	// Use this for initialization
	void Start () {
		y = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		y = transform.position.y;
		if ( y < -1){
			Destroy(gameObject);
		}
	}
}
