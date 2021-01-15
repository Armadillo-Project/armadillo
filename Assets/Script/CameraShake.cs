using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float ShakeAmount;
    public float ShakeTime;
    Vector3 initialPosition;

    public void VibrateForTime(float time)
    {
        ShakeTime = time;
    }

    private void Start()
    {
        initialPosition = new Vector3(0f, 0f, -10f);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            while (ShakeTime >0)
            {
                if (ShakeTime > 0)
                {
                    transform.position = Random.insideUnitSphere * ShakeAmount + initialPosition;
                    ShakeTime -= Time.deltaTime;
                }
                else
                {
                    ShakeTime = 0.0f;
                    transform.position = initialPosition;
                }
            }
            
        }
    }
}