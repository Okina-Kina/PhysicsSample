using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 等速円運動
public class UniformCircularMotion : MonoBehaviour
{
    [SerializeField] private float _radius = 2;
    [SerializeField] private Vector3 _velocity;
    private Vector3 _up;
    private Vector3 _acceleration;


    // Start is called before the first frame update
    void Start()
    {
        _up = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        _acceleration = Vector3.Cross(_up, _velocity) * _radius;
        _velocity += Time.deltaTime * _acceleration;
        transform.position += Time.deltaTime * _velocity;
    }

}
