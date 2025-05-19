using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Do you want to add one?
    [SerializeField] private GameObject _hitEffect;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        //If hit projectile
        if(collision.gameObject.name == "Projectile(Clone)")
        {
            Destroy(gameObject, 1f);
        }

        //If hit anything besides other projectile
        if(collision.gameObject.name != "Projectile(Clone)")
        {
            //print (collision.gameObject.tag);
            //print (collision.gameObject.name);
            Destroy(gameObject);
        }
    }
}
