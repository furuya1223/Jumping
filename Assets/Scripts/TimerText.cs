using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour {
    GameManager gameManager;
    TextMeshProUGUI textMesh;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {
        textMesh.text = timeToString(gameManager.time);
    }

    string timeToString(float t)
    {
        int minute = (int)Math.Truncate(t) / 60;
        return "" + minute.ToString("00") + ":" + (t - minute * 60).ToString("00.00");
    }
}
