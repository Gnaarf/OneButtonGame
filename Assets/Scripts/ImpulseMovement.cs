using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ImpulseMovement : MonoBehaviour
{
    [SerializeField] RotateAround _direction;
    [SerializeField] float _forceFactor = 1f;
    
    Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (InputManager.GetInputUp())
        {
            _rigidbody.AddForce(_direction.GetDirectionFromParent() * _forceFactor);
        }
    }
}
