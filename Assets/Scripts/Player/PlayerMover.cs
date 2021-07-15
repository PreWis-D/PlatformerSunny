using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    private float _speed = 7;

    public bool IsGrounded { get; private set; }
    public Rigidbody2D RigidBody2D { get; private set; }
    public Vector3 Velocity { get; private set; }

    private void OnEnable()
    {
        RigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out CompositeCollider2D compositeCollider2D))
            IsGrounded = true;
    }

    private void Update()
    {
        Velocity = new Vector3(Input.GetAxis("Horizontal"), 0);
        transform.position += Velocity * _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && IsGrounded)
        {
            RigidBody2D.AddForce(new Vector2(0, 300));
            IsGrounded = false;
        }
    }
}
