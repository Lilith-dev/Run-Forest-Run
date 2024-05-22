using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_Generator : MonoBehaviour
{
    public GameObject Road;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(Road);
        }
    }
}
