using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameControl : MonoBehaviour
{
    [Header("General")]
    public static GameControl instance;
    public bool gameOver = false;

    
    [Header("Scrolling")]
    public float StartScrollSpeed = -1.5f;
    public float scrollSpeedMultiplier;
    public float scrollSpeed;

    [Header("Score Things")]
    public TMP_Text scoreText;
    public int score = 0;
    private float scorehelpthing = 0;
    
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
        scorehelpthing += Time.deltaTime;

        if (scorehelpthing >= 1)
        {
            scorehelpthing = 0;
            score++;
        }
        
        scoreText.text = "Score: " + score.ToString ();
    }
}
