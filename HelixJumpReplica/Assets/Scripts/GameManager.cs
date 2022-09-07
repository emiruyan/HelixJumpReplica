using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    [SerializeField] private Text scoreText;
    private int score;


    public void LevelSuccesful()
    {
        SceneManager.LoadScene(1);//1 indexli sahneyi yükler
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Aynı sahneyi tekrar yükle
    }

    public void GameScore(int ringScore)
    {
        score += ringScore;
        scoreText.text = score.ToString();
    }

    

}
