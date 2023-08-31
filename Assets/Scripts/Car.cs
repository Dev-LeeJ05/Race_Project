using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("Use Stat")]
    public float moveSpeed;
    public float rotateSpeed;
    public float traction;

    [Space(15f)]
    [Header("Base Stat")]
    public float baseMoveSpeed;
    public float baseRotateSpeed;
    public float baseTraction;

    [Space(15f)]
    [Header("Drift Stat")]
    public float driftMoveSpeed;
    public float driftRotateSpeed;
    public float driftTraction;
    
    [Space(15f)]
    [Header("Nitro Stat")]
    public float nitroMoveSpeed;
    public float nitroRotateSpeed;
    public float nitroTraction;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
