using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFloor : MonoBehaviour {
    Rigidbody rigidbody;
    Vector3 startPos;
    float force = 450;

    // Use this for initialization
    void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        startPos = transform.position;
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
            StartCoroutine(FallStart());
        }
    }

    IEnumerator FallStart()
    {
        yield return new WaitForSeconds(0.1f);
        rigidbody.constraints = RigidbodyConstraints.FreezeAll ^ RigidbodyConstraints.FreezePositionY;
        rigidbody.useGravity = true;
    }

    public void Reborn()
    {
        StartCoroutine(RebornCoroutine());
    }

    IEnumerator RebornCoroutine()
    {
        yield return new WaitForSeconds(5.0f);
        rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        rigidbody.useGravity = false;
        transform.position = startPos;
    }
}