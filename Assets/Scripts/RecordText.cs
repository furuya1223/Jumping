using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordText : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    // Use this for initialization
    void Start ()
    {
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
        if(SaveData.LoadTimeRecord() < 0)
        {
            textMesh.text = "Record: --:--.--";
        }
        else
        {
            textMesh.text = "Record: " + timeToString(SaveData.LoadTimeRecord());
        }
    }
	
	// Update is called once per frame
	void Update () {

    }

    string timeToString(float t)
    {
        int minute = (int)Math.Truncate(t) / 60;
        return "" + minute.ToString("00") + ":" + (t - minute * 60).ToString("00.00");
    }
}
