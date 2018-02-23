using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreScript2 : MonoBehaviour
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
        theText.text = " High Score: " + GameManager.instance.highScore;
    }
}
