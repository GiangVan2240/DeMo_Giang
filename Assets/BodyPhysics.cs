using System;
using UnityEngine;

public class BodyPhysics : MonoBehaviour
{
    [SerializeField] private float mass = 1f;
    [SerializeField] private bool useGravity = true;
    [SerializeField] private Vector3 gravity = new Vector3(0, -9.81f, 0);

    private Vector3 velocity =Vector3.zero;
    private Vector3 force =Vector3.zero;
    private void Update()
    {
        if (useGravity)
        {
            ApplyGravity();
        }
        ApplyForce();

        transform.position += velocity * Time.deltaTime;
    }
    private void ApplyGravity()
    {
        velocity += gravity * (Time.deltaTime / mass);
    }
    private void ApplyForce()
    {
        velocity += force * (Time.deltaTime / mass);
    }

}
