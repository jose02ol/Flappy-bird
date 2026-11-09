using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] Transform targetPosition;
    [SerializeField] float speed = 2f;

    bool activated = false;

    void Update()
    {
        if (activated) // cuando se activa el trigger transforma la posicion del obstaculo a la de target.psition
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition.position,
                speed * Time.deltaTime
            );
        }
    }

    public void Activate()
    {
        activated = true;
    }
}
