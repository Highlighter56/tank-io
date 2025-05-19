using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I27 : MonoBehaviour
{
    [SerializeField] private int _test;
    [SerializeField] private int _health = 27;

    void Update()
    {
        if(_health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            _health -= 1;
        }
    }
}
