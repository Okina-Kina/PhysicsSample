using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 自由落下（等加速度運動）
public class UniformAcceleratedMotion : MonoBehaviour
{
    [SerializeField] private float _jumpingForce = 2.0f;
    [SerializeField] private float _gravitationForce = -9.8f;

    private Vector3 _velocity;
    private Vector3 _up;
    private Vector3 _acceleration;


    // Start is called before the first frame update
    void Start()
    {
        _up = new Vector3(0, 1, 0);
        _velocity = _up * _jumpingForce;
        _acceleration = _up * _gravitationForce;
    }

    // Update is called once per frame
    void Update()
    {
        _velocity += Time.deltaTime * _acceleration;
        transform.position += Time.deltaTime * _velocity;
    }
}
