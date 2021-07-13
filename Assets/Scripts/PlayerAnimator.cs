using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
[RequireComponent (typeof(Animator))]
[RequireComponent (typeof(PlayerMover))]

public class PlayerAnimator : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    private PlayerMover _player;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
        _player = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        AnimatePlayerInAir();

        _animator.SetFloat("ySpeed", _player.RigidBody2D.velocity.y);
        _animator.SetFloat("Speed", Mathf.Abs(_player.Velocity.x));

        Flip();
    }

    private void Flip()
    {
        if (_player.Velocity.x < 0)
            _spriteRenderer.flipX = true;
        else if (_player.Velocity.x > 0)
            _spriteRenderer.flipX = false;
    }

    private void AnimatePlayerInAir()
    {
        if (_player.IsGrounded)
            _animator.SetBool("IsGrounded", true);
        else
            _animator.SetBool("IsGrounded", false);
    }
}
