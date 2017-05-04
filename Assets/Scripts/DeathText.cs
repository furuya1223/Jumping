using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathText : MonoBehaviour
{
    GameManager gameManager;
    TextMeshProUGUI textMesh;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {

    }

    public void textChange()
    {
        textMesh.text = "Fall: " + gameManager.death;
    }
}
