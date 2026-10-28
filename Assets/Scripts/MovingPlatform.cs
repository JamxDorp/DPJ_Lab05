using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private float waitingTime = 0f;
    [SerializeField] private float movingSpeed = 2f;
 
    private Transform targetPoint;
    private float waitTimer;
    private bool isWaiting;

    private void Start()
    {
        targetPoint = pointB;
        waitTimer = 0f;
        isWaiting = false;
    }

    private void Update()
    {
         if (isWaiting)
        {
            waitTimer += Time.deltaTime;
 
            if (waitTimer >= waitingTime)
            {
                targetPoint = (targetPoint == pointA) ? pointB : pointA;
                isWaiting = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, movingSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                transform.position = targetPoint.position;
                isWaiting = true;
                waitTimer = 0f;
            }
        }
    }
}
