using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class RetryGame : MonoBehaviour
{
    public int points=0;
    public TMP_Text scoreText;
   
    void Setup(){
        points = PointManager.score;
        scoreText.text = points + " POINTS";
    }
    void LoadGame(){
        SceneManager.LoadScene("Game");
        PointManager.score=0;
    }

}
