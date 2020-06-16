using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtounRotation : MonoBehaviour
{
    public GameObject firepoint;
    float angle = 0;
    void Start()
    {
        firepoint.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void onPressRight()
    {
        angle = angle - 10;

        if (angle > -91)
        {
            firepoint.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
    public void onPressLeft()
    {
        angle = angle + 10;
        if(angle<91)
        {
            firepoint.transform.rotation = Quaternion.Euler(0, 0, angle);
        }

    }
}
