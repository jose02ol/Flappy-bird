using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    public void Activate()
    {
        myRigidBody.useGravity = true;
    }
}
