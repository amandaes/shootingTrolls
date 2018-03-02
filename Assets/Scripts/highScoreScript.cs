using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreScript : MonoBehaviour
{

    Text theText;

    // Use this for initialization
    void Start()
    {
        theText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        theText.text = "Score: " + GameManager.instance.score + " \n High Score: " + GameManager.instance.highScore;
    }
}
