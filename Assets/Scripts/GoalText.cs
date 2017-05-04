using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GoalText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Fall()
    {
        gameObject.SetActive(true);
        transform.DOLocalMoveY(0f, 2f).SetEase(Ease.OutBounce);
    }
}
