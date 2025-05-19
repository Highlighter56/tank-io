using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform _barrelEnd;
    [SerializeField] private GameObject _projectile;

    [SerializeField] private float _projectileFroce = 1000f;

    [SerializeField] private int _shotDelayTimer;
    [SerializeField] private int _shotDelay;
    
    void Start()
    {
        _shotDelay = 25;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            if(_shotDelayTimer >= _shotDelay)
            {
                _shotDelayTimer = 0;
                Shoot();
            }
        }
    }

    void FixedUpdate()
    {
        if(_shotDelayTimer < _shotDelay)
        {
            _shotDelayTimer += 1;
        }
    }

    void Shoot()
    {
        GameObject firedProjectile = Instantiate(_projectile, _barrelEnd.position, _barrelEnd.rotation);
        Rigidbody2D rb = firedProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(_barrelEnd.up * _projectileFroce);
    }
}
