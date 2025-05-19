using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rings : MonoBehaviour
{
    [SerializeField] private float _materialDistance;
    [SerializeField] private float _xPos;
    [SerializeField] private float _yPos;

    // Start is called before the first frame update
    void Start()
    {
        Ring(240,1,5);
        Ring(220,1,4);
        Ring(180,1,4);
        Ring(150,1,4);
        Ring(120,1,4);
        Ring(80,1,4);
        Ring(50,1,4);
        Ring(40,1,4);
        Ring(30,1,1);
    }

    void Ring(int RingDistance, int RandomRange1, int RandomRange2)
    {
        _xPos = gameObject.transform.position.x;
        _yPos = gameObject.transform.position.y;
        _materialDistance = Mathf.Abs(_xPos) + Mathf.Abs(_yPos);
        if(_materialDistance <= RingDistance)
        {
            if(Random.Range(RandomRange1,RandomRange2) == 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
