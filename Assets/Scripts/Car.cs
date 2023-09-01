using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [Header("Use Stat")]
    public float maxSpeed;
    public float moveSpeed;
    public float rotateSpeed;
    public float traction;

    [Space(15f)]
    [Header("Base Stat")]
    public float baseMaxSpeed;
    public float baseMoveSpeed;
    public float baseRotateSpeed;
    public float baseTraction;

    [Space(15f)]
    [Header("Drift Stat")]
    public float driftMaxSpeed;
    public float driftMoveSpeed;
    public float driftRotateSpeed;
    public float driftTraction;
    protected bool isDrift;

    [Space(15f)]
    [Header("Nitro Stat")]
    public float nitroMaxSpeed;
    public float nitroMoveSpeed;
    public float nitroRotateSpeed;
    public float nitroTraction;

    [Space(20f)]
    [Header("Move Stat")]
    protected Vector3 moveForce;
    [SerializeField] protected float dragValue;
    [SerializeField] protected float brakePower;

    protected virtual void Update()
    {
        Movement();
    }

    protected virtual void Movement() { }

    protected virtual void Drift() {}
}
