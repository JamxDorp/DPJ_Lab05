using UnityEngine;
using UnityEngine.UIElements;

public class SpinningObstacle : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;

    private void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
