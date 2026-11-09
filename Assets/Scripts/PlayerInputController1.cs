using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController1 : MonoBehaviour
{   
    [SerializeField] [Range(0f,5f)] float speed;
    [SerializeField] float directionZ;
    [SerializeField] float directionX;
    [SerializeField] Vector2 move;

    Rigidbody rb;
    public bool jump;
    public float ThrustForce = 10000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 2.5f;
        rb = GetComponentInChildren<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(jump){
            Jump();
        }
    }

    public void OnMove(InputValue value)        //este metodo esta aqui solo para guardar el valor pulsado pero el movimiento lo programo aparte
    {
        move = value.Get<Vector2>();      //guardo el valor de entrada cuando se detecta el input 
    }

    public void OnJump(InputValue value){
        jump = value.isPressed;
    }

    private void Move(){
        directionX = move.x;
        directionZ = move.y; // si quisiese moverme en vertical si seria en el eje Y porque en unity es asi

        transform.Translate(directionX * speed * Time.deltaTime,0,0);
    }

    private void Jump(){
       // Debug.log("Jumping");
        rb.AddRelativeForce(Vector3.up * ThrustForce * Time.fixedDeltaTime);        
        jump = false;
    }

    
    }
