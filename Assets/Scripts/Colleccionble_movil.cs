using UnityEngine;

public class CollectibleMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float distance = 1f;

    Vector3 startPosition; 

    void Start()
    {
        startPosition = transform.position; // guardamos posicion inicial
    }

    void Update()
    {
        float movement = Mathf.Sin(Time.time * speed) * distance; // cambia el valor para que se mueva entre 0-1

        transform.position = startPosition + Vector3.up * movement;
    }
}
