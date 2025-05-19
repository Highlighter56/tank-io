using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaturalSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _1Prefab;
    [SerializeField] private GameObject _2Prefab;
    [SerializeField] private GameObject _4Prefab;
    [SerializeField] private GameObject _27Prefab;
    [SerializeField] private int _spawnRange;
    [SerializeField] private int _spawnAmount;
    [SerializeField] private int _x;
    [SerializeField] private int _y;
    [SerializeField] private int _counter;
    [SerializeField] private int _type;

    void Start()
    {
        _spawnRange = 145;
        _spawnAmount = 2000;
        Spawn();
    }

    void Spawn()
    {
        //print("HI");
         while(_counter != _spawnAmount)
        {
            //Random number used to determin what type will spawn
            _type = Random.Range(1,101);
            //Spawn 1
            if(_type <= 65)
            {
                Instantiate(_1Prefab, RandomCords(_spawnRange), Quaternion.identity);
                print("1");
            }
            //Spawn 2
            else if(_type <= 80)
            {
                Instantiate(_2Prefab, RandomCords(_spawnRange), Quaternion.identity);
                print("2");
            }
            //Spawn 4
            else if(_type <= 90)
            {
                Instantiate(_4Prefab, RandomCords(_spawnRange), Quaternion.identity);
                print("4");
            }
            //Spawn 27
            else if(_type <= 95)
            {
                Instantiate(_27Prefab, RandomCords(_spawnRange), Quaternion.identity);
                print("27");
            }
            _counter += 1;
        }
    }

    Vector2 RandomCords(int _spawnRange)
    {
        _x = Random.Range(-(_spawnRange),_spawnRange);
        _y = Random.Range(-(_spawnRange),_spawnRange);
        return new Vector2 (_x,_y);
    }
}
