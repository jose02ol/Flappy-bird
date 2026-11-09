using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody myRigidBody;
    MeshRenderer myMeshRenderer;
    float tiempo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tiempo = Time.time;

        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time - tiempo > 3)
        {
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}
