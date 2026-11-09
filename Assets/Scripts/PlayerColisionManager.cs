using UnityEngine;

public class PlayerCollisionManager : MonoBehaviour
{
    public void ProcessHit()
    {
        LevelController levelController = FindAnyObjectByType<LevelController>();
        levelController.TriggerReloadLevel();
    }

private void OnCollisionEnter(Collision other)
{
    ProcessHit();
}
}
