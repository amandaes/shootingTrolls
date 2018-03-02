using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour {

	// Use this for initialization
	public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
