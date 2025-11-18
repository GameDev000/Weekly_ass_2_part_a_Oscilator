using System;
using System.Drawing;
using UnityEngine;

public class Escilator : MonoBehaviour
{
    public Vector3 CenterPoint;
    [SerializeField] public float MoveSpeed = 0.7f;
    [SerializeField] public float amplitude = 0.7f;
    [SerializeField] private float changeRate = 0.001f;
    [SerializeField] private float maxAmplitude = 4f;
    [SerializeField] private float minAmplitude = 0.7f;
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
        MoveSpeed += changeRate * direction;
        amplitude += changeRate* direction;
        
        transform.position = CenterPoint + Mathf.Cos(Time.time * MoveSpeed) * Vector3.right * amplitude;
        if (amplitude >= maxAmplitude && !turning)
        {
            direction *= -1;
            turning = true;
        }
        if (amplitude <= minAmplitude && turning)
        {
            direction *= -1;
            turning = false;
        }

    }
}