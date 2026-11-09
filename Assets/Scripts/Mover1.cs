using UnityEngine;

public class Mover1 : MonoBehaviour
{
    [SerializeField] Vector3 directionVector;

    [SerializeField] [Range(-5f,5f)] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
        directionVector.x * speed * Time.deltaTime,
        directionVector.y * speed * Time.deltaTime,
        directionVector.z * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision){
    Vector3 direction = collision.GetContact(0).normal; //esto me devuelve la direccion contraria en la que colisiona
    Debug.Log(direction); // esto es para imprimir por la consola de unity

    if (collision.gameObject.tag == "Wall")
    {
    this.ChangeDirection(direction);
    }
}

void ChangeDirection(Vector3 direction){
//aqui lo que hay que hacer es cambiar el vector directionVector por la normal que nos devuelve la colision
directionVector = direction;
}
}

//con deltatime conseguimos que el movimiento vaya siemple fluido
