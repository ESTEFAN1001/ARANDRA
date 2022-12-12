using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    private int score;
    private float timer;
    public Text puntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }
    private void UpdateScore()
    {
        int score_point = 10;
        timer += Time.deltaTime;
        score = (int)(timer * score_point);
        puntaje.text = string.Format("{0:00000}", score);
    }
}
