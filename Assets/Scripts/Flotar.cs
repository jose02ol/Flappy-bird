using UnityEngine;

public class Flotar : MonoBehaviour
{
    [SerializeField] [Range(-5f,5f)]// gracias a poner esto encima de la variable me permite cambiarla en el editor de unity
        //usando Range puede poner limites y ademas añadiendo la f hago que pueda elegir con un slider el valor de la amplitud en unity
    float amplitude;

    [SerializeField]

    float final_frequency;
    Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * final_frequency) * amplitude;
        transform.localPosition = new Vector3(startPos.x, newY, startPos.z); //cambia la posicion en la transformada del objeto
    }
}

//vector3 sirve para crear un vector

