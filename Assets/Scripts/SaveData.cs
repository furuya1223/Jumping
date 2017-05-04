using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour {
    const string TIME_RECORD_KEY = "time_record";

    public static void SaveTimeRecord(float time)
    {
        PlayerPrefs.SetFloat(TIME_RECORD_KEY, time);
        PlayerPrefs.Save();
    }

    public static float LoadTimeRecord()
    {
        return PlayerPrefs.GetFloat(TIME_RECORD_KEY, -1);
    }
}
