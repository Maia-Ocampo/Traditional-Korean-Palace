using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSound : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            audioSource.Play(); 
        }
    }
}
