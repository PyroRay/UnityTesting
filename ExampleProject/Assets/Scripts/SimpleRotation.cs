using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    [Header("Transform Vector")]
    public Vector3 rotationPerSecond;
    [Header("Time Multiplier")]
    public float scalingFactor = 1;
    private float p_scalingFactor;
    private Vector3 p_rotationPerSecond = new Vector3();
    private Vector3 c_rotationPerSecond = new Vector3();

    void Start()
    {
        p_rotationPerSecond = rotationPerSecond;
        p_scalingFactor = scalingFactor;
    }

        // Update is called once per frame
    void Update()
    {
        //c_rotationPerSecond = rotationPerSecond;

        if(rotationPerSecond != p_rotationPerSecond)
        {
            c_rotationPerSecond = rotationPerSecond;
            p_rotationPerSecond = rotationPerSecond;
        }

        if(scalingFactor != p_scalingFactor)
        {
            //Debug.Log(string.Format("first check"));
            if (p_scalingFactor != 0)
            {
                Debug.Log(string.Format("second check 1 {0}", p_scalingFactor));
                c_rotationPerSecond.Scale(new Vector3((1 / p_scalingFactor), (1 / p_scalingFactor), (1 / p_scalingFactor)));
            }
            else
            {
                Debug.Log(string.Format("second check 2"));
                c_rotationPerSecond = rotationPerSecond;
            }
            Debug.Log(string.Format("scalingFactor will be updated from {0} to {1}", p_scalingFactor, scalingFactor));
            c_rotationPerSecond.Scale(new Vector3(scalingFactor, scalingFactor, scalingFactor));
            //Debug.Log(string.Format("scalingFactor was updated from {0} to {1}", p_scalingFactor, scalingFactor));
            p_scalingFactor = scalingFactor;
        }
        transform.Rotate(c_rotationPerSecond * Time.deltaTime);
    }
}
