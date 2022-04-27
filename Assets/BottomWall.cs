using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        string wallName = transform.tag; 
        Lives.LivesCount(wallName);
        coll.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);

        if (Lives.LivesNumber == -1)
        {
            Lives.LivesNumber = 3;
            Score.PlayerScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
