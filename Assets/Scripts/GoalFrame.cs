using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFrame : MonoBehaviour {
    float force = 200;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
        {
            obj.GetComponent<Rigidbody>().AddForce(0, force, 0);
        }
    }
}