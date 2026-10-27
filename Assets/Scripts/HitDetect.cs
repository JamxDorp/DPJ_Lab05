using System;
using Unity.VisualScripting;
using UnityEngine;

public class HitDetect : MonoBehaviour
{
    [SerializeField] GameObject ObjectToColorChange;
    [SerializeField] Material Collided;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ObjectToColorChange.GetComponent<Renderer>().material = Collided;
        }
    }
}
