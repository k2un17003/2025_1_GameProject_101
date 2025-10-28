using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
     public static UIController Instance;
    public Slider healthBar;
    public TMP_Text scoreText;

    void Awake()
    {
        Instance = this;
    }

    public void UpdateHealth(int hp, int max)
    {
        if (healthBar != null)
        {
            healthBar.maxValue = max;
            healthBar.value = hp;
        }
    }

    public void UpdateScore(int score)
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
