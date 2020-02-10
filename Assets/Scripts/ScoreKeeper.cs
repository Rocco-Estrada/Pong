using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private Text leftTextScore;
    [SerializeField] private Text rightTextScore;

    [SerializeField] private Goal leftGoal;
    [SerializeField] private Goal rightGoal;

    private GameObject ball;

    [SerializeField] private GameManager gameManager;


    private int leftScore;

    private int rightScore;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        StartScore();
    }

    private void StartScore()
    {
        leftTextScore.text = leftScore.ToString();
        rightTextScore.text = rightScore.ToString();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball" && this.gameObject.name == "RightGoal")
        {
            leftScore++;
            leftTextScore.text = leftScore.ToString();
        }

        if (other.gameObject.name == "Ball" && this.gameObject.name == "LeftGoal")
        {
            rightScore++;
            rightTextScore.text = rightScore.ToString();
        }
        //RefreshScore();
    }
    /*public void AddScore(Goal scoringSide)
    {
        if (scoringSide == leftGoal)
        {
            rightScore += 1;
        }

        else
        {
            leftScore += 1;
        }
        RefreshScore();
    }*/

}
