using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Vector3 GetDirectionFromParent()
    {
        return (transform.position - _parent.position).normalized;
    }

    [SerializeField] float _frequency = 1f;
    [SerializeField] Transform _parent = default;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(_parent.position, _parent.forward, Time.deltaTime * 360 * _frequency);
    }
}
