using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;
    public TMP_Text livesText;
    public TMP_Text endText;
    public static int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
        if (lives == 0)
        {
            //endText.SetA
        }
    }
}
