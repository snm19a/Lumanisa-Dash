using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public bool gameOver = false;
    public float StartScrollSpeed = -1.5f;
    public float scrollSpeedMultiplier;
    public float scrollSpeed;

    public int score = 0;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }
        scrollSpeed = StartScrollSpeed;
    }

    void Update()
    {
        scrollSpeed = (StartScrollSpeed - (score / scrollSpeedMultiplier));
    }
}
