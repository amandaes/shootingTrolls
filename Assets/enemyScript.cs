﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("bullet"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            GameManager.instance.score++;
        }
    }
}
