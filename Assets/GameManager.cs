using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public int score = 0;
    public int highScore = 0;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            instance.score = 0;

            Destroy(gameObject); // THERE CAN BE ONLY ONE!
        }

        string fullFilePath = Application.persistentDataPath + Path.DirectorySeparatorChar + "SaveData.txt";
        if (File.Exists(fullFilePath))
        {
            string highScoreString = File.ReadAllText(fullFilePath);
            highScore = int.Parse(highScoreString);
        }
    }

    public void endGame()
    {
        if (score > highScore)
        {
            highScore = score;

            string fullFilePath = Application.dataPath + Path.DirectorySeparatorChar + "SaveData.txt";
            File.WriteAllText(fullFilePath, highScore.ToString());
        }
        SceneManager.LoadScene(2);

        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("PlayScene");
        }
    }
}

 