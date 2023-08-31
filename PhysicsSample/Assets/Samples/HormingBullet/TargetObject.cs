using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    [SerializeField] private PlayerObject _player;
    [SerializeField] private float _radius = 1;
    [SerializeField] private Vector3 _initialVelocity = new Vector3(0, 0, 1);
    private Vector3 _velocity;
    private Vector3 _up;
    private Vector3 _acceleration;

    // Start is called before the first frame update
    void Start()
    {
        _up = new Vector3(0, 1, 0);
        _velocity = _initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 e2p = _player.transform.position - this.transform.position;
        Vector3 direction = Vector3.Cross(_velocity, e2p);

        // 右旋回
        if (0 < Vector3.Dot(direction, _up))
        {
            _acceleration = Vector3.Cross(_up, _velocity) * _radius;
        }
        else if (Vector3.Dot(direction, _up) < 0)
        {
            _acceleration = Vector3.Cross(_up, _velocity) * -_radius;
        }

        _velocity += Time.deltaTime * _acceleration;
        transform.position += Time.deltaTime * _velocity;
    }

}
