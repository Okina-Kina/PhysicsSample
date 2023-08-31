using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    [SerializeField] private float _force = 2;
    [SerializeField] private float _rotation = 0.2f;
    [SerializeField] private Vector3 _initialVelocity = new Vector3(0, 0, 10);
    private Vector3 _velocity;
    private Vector3 _up;


    // Start is called before the first frame update
    void Start()
    {
        _up = new Vector3(0, 1, 0);
        _velocity = _initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -_rotation, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, _rotation, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            _velocity += transform.forward * _force;
            transform.position += Time.deltaTime * _velocity;
        }

    }

}
