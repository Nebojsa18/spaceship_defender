using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class RetryGame : MonoBehaviour
{
    public int points=0;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Setup(){
        points = PointManager.score;
        scoreText.text = points + " POINTS";
    }
    void LoadGame(){
        SceneManager.LoadScene("Game");
        PointManager.score=0;
    }

}
