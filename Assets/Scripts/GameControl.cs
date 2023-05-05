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
    public string CharacterToLoad;
    
    [Header("Scrolling")]
    public float StartScrollSpeed = -1.5f;
    public float scrollSpeedDivider;
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
        CharacterToLoad = NameStateController.selectedCharacter;
    }

    void Update()
    {
        scrollSpeed = (StartScrollSpeed - (score / scrollSpeedDivider));
        scorehelpthing += Time.deltaTime;

        if (scorehelpthing >= 0.33f)
        {
            scorehelpthing = 0;
            score++;
        }
        
        scoreText.text = "Score: " + score.ToString ();
    }
}
