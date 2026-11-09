using UnityEngine;

public class TriggerActivator : MonoBehaviour
{
    [SerializeField] Dropper target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Calico")
        {
            if (target)
            {
                target.Activate();
            }
        }
    }
}
