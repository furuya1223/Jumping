using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalArea : MonoBehaviour {
    public GameObject goalText;
    GameManager gameManager;
    
	void Start ()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.isFinished = true;
            if(SaveData.LoadTimeRecord() < 0 || gameManager.time < SaveData.LoadTimeRecord())
            {
                SaveData.SaveTimeRecord(gameManager.time);
            }
            goalText.GetComponent<GoalText>().Fall();
            StartCoroutine(ReturnToStart());
        }
    }

    IEnumerator ReturnToStart()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Start");
    }
}
