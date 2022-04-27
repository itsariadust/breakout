using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBlock : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        string wallName = transform.tag;
        Score.PlayerScoreCount(wallName);
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}
