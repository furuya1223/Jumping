using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgePlane : MonoBehaviour {
    GameManager gameManager;
    
	void Start ()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.tag == "Player")
        {
            // プレーヤー落下
            gameManager.Death();
            StartCoroutine(Respawn(obj));
        }
        else if(obj.tag == "FallBlock")
        {
            obj.GetComponent<FallFloor>().Reborn();
        }
    }

    IEnumerator Respawn(GameObject obj)
    {
        gameManager.isRunning = false;
        yield return new WaitForSeconds(0.5f);
        gameManager.isRunning = true;
        obj.transform.position = new Vector3(0, 1.7f, 0);
        obj.transform.forward = new Vector3(0, 0, 1);
        obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
