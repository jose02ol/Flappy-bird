using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Luffy")
        {
            Debug.Log("Cargando Nivel2");
            ScoreBoardManager scoreBoardManager =
                FindAnyObjectByType<ScoreBoardManager>();

            scoreBoardManager.SaveScore();
            SceneManager.LoadScene(1);
            
        }
    }
}
