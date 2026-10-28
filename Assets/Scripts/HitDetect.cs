using System;
using Unity.VisualScripting;
using UnityEngine;

public class HitDetect : MonoBehaviour
{
    [SerializeField] GameObject ObjectToColorChange;
    [SerializeField] Material Collided;
    private bool alreadyCollided = false;
    private int points = 10;
    public static int TotalPoints { get; private set; }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && alreadyCollided == false)
        {
            ObjectToColorChange.GetComponent<Renderer>().material = Collided;
            alreadyCollided = true;
            TotalPoints += points;
        }
    }

     public static void ResetPoints() => TotalPoints = 0;
}
