using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    Rigidbody rigidbody;
    float speed = 5.0f;
    float power = 30f;
    Camera camera;
    GameObject mapCamera;
    float Height;
    GameManager gameManager;

	// Use this for initialization
	void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        camera = Camera.main;
        mapCamera = GameObject.Find("MapCamera");
        Height = transform.position.y;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameManager.isRunning)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            rigidbody.velocity = new Vector3(h * speed, rigidbody.velocity.y, v * speed);
            //rigidbody.AddForce(h * power, 0, v * power);
            if (!Mathf.Approximately(h, 0) || !Mathf.Approximately(v, 0)) transform.forward = new Vector3(h, 0, v).normalized;
            Height = Mathf.Min(Height, transform.position.y);
            Height = Mathf.Max(Height + 2.0f, transform.position.y) - 2.0f;
            camera.transform.position = new Vector3(
                transform.position.x,
                Height + 3,
                transform.position.z - 3
            );
            mapCamera.transform.position = new Vector3(transform.position.x, Height + 5, transform.position.z);
        }
    }
}
