using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI MyScoreUI;
    public int ScoreAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //MyScoreUI.text = "hello";
    }

    // Update is called once per frame
    void Update()
    {
        //AddToScore();
    }

    public void AddToScore()
    {
        ScoreAmount = ScoreAmount + 1;
        MyScoreUI.text = "Score: " + ScoreAmount;
    }
}
