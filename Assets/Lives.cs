using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public static int LivesNumber = 3;
    public GUISkin layout;
    GameObject theBall;
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("Ball");
    }
    public static void LivesCount(string wallID)
    {
        if (wallID == "BottomWall")
        {
            LivesNumber--;
        }
    }
    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + LivesNumber);
    }

    void Update()
    {

    }
}
