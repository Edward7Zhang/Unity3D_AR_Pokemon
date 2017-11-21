using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelorometerController : MonoBehaviour {

    float speed = 200;
    static bool isTouched = false;

	// Use this for initialization
	void Start () {
        isTouched = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.touchCount >= 1)
        {
            isTouched = true;
        }
        if (isTouched)
        {
            Vector3 mMovement = new Vector3(
                Input.acceleration.x * speed * Time.deltaTime,
                Input.acceleration.y * speed * Time.deltaTime);
            transform.Translate(mMovement);
        }
        
	}
}
