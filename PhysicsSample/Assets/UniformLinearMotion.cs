using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 等速直線運動
public class UniformLinearMotion : MonoBehaviour
{
    private Vector3 _velocity;
    private Vector3 _up;

    // Start is called before the first frame update
    void Start()
    {
        _velocity = new Vector3(0, 2, 0);
        _up = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Time.deltaTime * _velocity);
    }
}
