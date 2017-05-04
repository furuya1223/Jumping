using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float startTime;
    public bool isRunning;
    public bool isFinished;
    private int _death;
    public float time { get; private set; }
    public int death { get { return _death; } }

    DeathText deathText;

    // Use this for initialization
    void Start () {
        isRunning = true;
        isFinished = false;
        _death = 0;
        startTime = Time.time;

        deathText = GameObject.Find("DeathText").GetComponent<DeathText>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isFinished)
        {
            time = Time.time - startTime;
        }
	}

    public void Death()
    {
        if (!isFinished)
        {
            _death++;
            deathText.textChange();
        }
    }
}
