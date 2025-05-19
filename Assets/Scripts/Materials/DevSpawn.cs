using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevSpawn : MonoBehaviour
{
    //Prefabs
    [SerializeField] private GameObject _p1;
    [SerializeField] private GameObject N1;
    [SerializeField] private GameObject J2;
    [SerializeField] private GameObject I27;
    //Singel Inputs
    [SerializeField] private int _singleInput1;
    [SerializeField] private int _singleInput2;
    [SerializeField] private int _singleInput27;
    //Spawning Variables
    [SerializeField] private float _spawnRange = 9.5f;
    [SerializeField] private float _x;
    [SerializeField] private float _y;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.N))
        {
            _singleInput1 += 1;
            if(_singleInput1 == 1)
            {
                Instantiate(N1, Cords(), Quaternion.identity);
                print(1);
            }
        }
        else
        {
            _singleInput1 = 0;
        }

        if(Input.GetKey(KeyCode.J))
        {
            _singleInput2 += 1;
            if(_singleInput2 == 1)
            {
                Instantiate(J2, Cords(), Quaternion.identity);
                print(2);
            }
        }
        else
        {
            _singleInput2 = 0;
        }

        if(Input.GetKey(KeyCode.I))
        {
            _singleInput27 += 1;
            if(_singleInput27 == 1)
            {
                Instantiate(I27, Cords(), Quaternion.identity);
                print(27);
            }
        }
        else
        {
            _singleInput27 = 0;
        }
    }

    Vector2 Cords()
    {
        _x = Random.Range(
            _p1.transform.position.x - _spawnRange,
            _p1.transform.position.x + _spawnRange
         );
        _y = Random.Range(
            _p1.transform.position.y - _spawnRange,
            _p1.transform.position.y + _spawnRange
        );
        return new Vector2(_x,_y);
    }
}