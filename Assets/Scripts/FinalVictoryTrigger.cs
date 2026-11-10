using UnityEngine;
using TMPro;

public class FinalGoalTrigger : MonoBehaviour
{
    [SerializeField] GameObject victoryText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Luffy")
        {
            ScoreBoardManager scoreBoardManager =
                FindAnyObjectByType<ScoreBoardManager>();

            int finalScore = scoreBoardManager.GetScore();

            victoryText.GetComponent<TMP_Text>().text =
                "¡ENHORABUENA!\nPuntuación final: " + finalScore;

            victoryText.SetActive(true);

            Time.timeScale = 0f;
            scoreBoardManager.ResetScore();
        }
    }
}
