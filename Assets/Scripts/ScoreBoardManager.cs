using UnityEngine;
using TMPro;

public class ScoreBoardManager : MonoBehaviour
{
    private int score = 0;
    private static int savedScore = 0;

    [SerializeField] TMP_Text scoreBoardText;

    void Start()
    {
        score += savedScore;
        scoreBoardText.text = score.ToString();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreBoardText.text = score.ToString();
    }

    public void SaveScore()
    {
        savedScore = score;
    }

    public int GetScore()
    {
    return score;
    }

    public void ResetScore()
    {
    score = 0;
    savedScore = 0;
    }
}
