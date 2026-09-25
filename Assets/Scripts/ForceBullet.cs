using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceBullet : MonoBehaviour
{   
    [SerializeField] private Rigidbody _rb;
    private float _speedForce;


    public void InsInitialize(float speedForce)
    {
        _speedForce = speedForce;

        _rb.AddForce(transform.forward * _speedForce, ForceMode.Impulse);

        Destroy(gameObject, 3f);
    }
}
