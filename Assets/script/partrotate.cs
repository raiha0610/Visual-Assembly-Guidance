using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partrotate : MonoBehaviour
{
    private Vector3 _rotation;
    private float _speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * _speed *Time.deltaTime);
    }
}
