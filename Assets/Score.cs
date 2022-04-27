using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int PlayerScore = 0;
    public GUISkin layout;
    GameObject theBall;
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }
    public static void PlayerScoreCount(string wallID)
    {
        if (wallID == "Block")
        {
            PlayerScore++;
        }
    }
    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + "0" + PlayerScore);
    }
    void Update()
    {
        
    }
}
