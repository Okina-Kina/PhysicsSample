using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 物体の正面ベクトルを利用した等速円運動
// カメラが追従する．
public class UniformCircularMotion2 : MonoBehaviour
{
    [SerializeField] private float _rotate = 0.2f;
    [SerializeField] private float _force = 2;
    [SerializeField] private Vector3 _initializeVelocity = new Vector3(0, 0, 10);
    private Vector3 _velocity;
    private Vector3 _up;


    // Start is called before the first frame update
    void Start()
    {
        _up = new Vector3(0, 1, 0);
        _velocity = _initializeVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, _rotate, 0);
        _velocity = transform.forward * _force;
        transform.position += Time.deltaTime * _velocity;
    }
}
