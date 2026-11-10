using UnityEngine;

public class TriggerMovimiento : MonoBehaviour
{
    [SerializeField] MovingObstacle target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Luffy")
        {
            if (target)
            {
                target.Activate();
            }
        }
    }
}
