using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Car
{
    protected override void Update()
    {
        base.Update();
    }

    protected override void Movement()
    {
        base.Movement();
        moveForce += transform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.position += moveForce * Time.deltaTime;

        float z = Input.GetAxisRaw("Horizontal");
        transform.Rotate(Vector3.forward * z * moveForce.magnitude * rotateSpeed * Time.deltaTime);

        moveForce = Vector3.Lerp(moveForce.normalized, transform.forward, traction * Time.deltaTime) * moveForce.magnitude;
        moveForce = Vector3.ClampMagnitude(moveForce, maxSpeed);
    }

    protected override void Drift()
    {
        base.Drift();
        float driftDir = 0; // �帮��Ʈ ���� �����ϴ� ����

        // �帮��Ʈ ���� ����
        if (Input.GetKeyDown(KeyCode.LeftControl) && !isDrift && Input.GetAxisRaw("Horizontal") != 0)
        {
            moveSpeed = driftMoveSpeed;
            rotateSpeed = driftRotateSpeed;
            traction = driftTraction;
            driftDir = Input.GetAxisRaw("Horizontal");
            isDrift = true;
        }

        if (isDrift)
        {
            // �帮��Ʈ ��� ����
            if (moveForce.normalized == transform.up || Input.GetAxisRaw("Horizontal") == -driftDir || moveForce.magnitude < driftMoveSpeed)
            {
                isDrift = false;
            }

            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                traction = driftTraction;
            }
            else
            {
                traction = baseTraction;
            }
        }
        else
        {
            traction = baseTraction;
            moveSpeed = baseMoveSpeed;
            rotateSpeed = baseRotateSpeed;
        }
    }
}
