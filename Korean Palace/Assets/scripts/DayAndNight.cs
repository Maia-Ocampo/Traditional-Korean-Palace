using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndNight : MonoBehaviour
{
    Vector3 lightDecay = Vector3.zero;

    //the amount of degrees that is increased per second
    public float perSecond = 6;


    // Update is called once per frame
    void Update()
    {
        lightDecay.x = perSecond*Time.deltaTime; 
        transform.Rotate(lightDecay, Space.World);
    }

}
