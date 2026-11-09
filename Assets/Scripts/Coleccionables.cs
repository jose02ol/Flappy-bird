using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] int points = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Calico")
        {
            ScoreBoardManager ScoreBoardManager =
                FindAnyObjectByType<ScoreBoardManager>();

            ScoreBoardManager.IncreaseScore(points);

            Destroy(gameObject);
        }
    }
}
