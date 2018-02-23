using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour {

    public float moveSpeed = 1f;

    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode fireKey = KeyCode.Space;

    public GameObject bulletToRight;

    public float deadPos = -6f;

    


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        if (Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }

        if (Input.GetKeyDown(fireKey))
        {
            GameObject bulletObj = Instantiate(bulletToRight);
            bulletObj.transform.position = transform.position;
        }
        
        if (transform.position.y < deadPos)
        {
            SceneManager.LoadScene(2);
        }
        
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }


}
