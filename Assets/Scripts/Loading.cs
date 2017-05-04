using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
    Slider slider;
    AsyncOperation async;

    private void Awake()
    {
        slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    // Use this for initialization
    void Start ()
    {
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Load()
    {
        gameObject.SetActive(true);
        StartCoroutine(LoadCoroutine());
    }

    IEnumerator LoadCoroutine()
    {
        async = SceneManager.LoadSceneAsync("Stage1");
        async.allowSceneActivation = false;

        while (async.progress < 0.9f)
        {
            slider.value = async.progress;
            yield return 0;
        }
        
        slider.value = 1.0f;

        async.allowSceneActivation = true;
    }
}