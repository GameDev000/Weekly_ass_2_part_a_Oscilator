using System;
using System.Drawing;
using UnityEngine;

public class Escilator : MonoBehaviour
{
    public Vector3 CenterPoint;
    public float MoveSpeed = 0.7f, amplitude = 0.7f;
    private int direction = 1;
    private bool turning = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CenterPoint = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        MoveSpeed += 0.001f * direction;
        amplitude += 0.001f * direction;


        transform.position = CenterPoint + Mathf.Cos(Time.time * MoveSpeed) * Vector3.right * amplitude;
        if (amplitude >= 4f && !turning)
        {
            direction *= -1;
            turning = true;
        }
        if (amplitude <= 0.7f && turning)
        {
            direction *= -1;
            turning = false;
        }

    }
}
