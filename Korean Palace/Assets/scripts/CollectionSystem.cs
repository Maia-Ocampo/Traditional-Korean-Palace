using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectionSystem : MonoBehaviour
{
    public Text counterText;
    float collected = 0f;
    public float collectedScore = 1f;
    void Update()
    {
        counterText.text = collected.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "object")
        {
            other.gameObject.SetActive(false);
            collected += collectedScore;
        }
    }
}
