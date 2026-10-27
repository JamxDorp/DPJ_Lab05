using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    public int points;

    private void Update()
    {
        MovePlayer();
    }

// Moves the player using old Input Manager axes
    private void MovePlayer()
    {
        float xMoveValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yMoveValue = 0f;
        float zMoveValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(xMoveValue, yMoveValue, zMoveValue);
    }
}
