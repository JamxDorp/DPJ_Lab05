using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] Material unlocked;
    private bool alreadyTriggered;

    private void Update()
    {
        if (HitDetect.TotalPoints >= 30)
        {
            gameObject.GetComponent<MeshCollider>().isTrigger = true;
            gameObject.GetComponent<Renderer>().material = unlocked;
        }
    }
    private void OnTriggerEnter(Collider collide)
    {
        if (alreadyTriggered || !collide.CompareTag("Player")) return;

        alreadyTriggered = true;
        Debug.Log($"Fim do nível! Pontos adquiridos: {HitDetect.TotalPoints}");
    }
}
