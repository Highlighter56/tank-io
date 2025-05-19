using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowP1 : MonoBehaviour
{
    [SerializeField] private int _test;

    [SerializeField] private GameObject _p1;
    [SerializeField] private Vector3 _camPosition = new Vector3(0f,0f,-10f);
    [SerializeField] private float _p1X;
    [SerializeField] private float _p1Y;

    // Update is called once per frame
    void Update()
    {
        //_test += 1;
        Track();
    }

    void Track()
    {
        _p1X = _p1.transform.position.x;
        _p1Y = _p1.transform.position.y;

        _camPosition = new Vector3(_p1X, _p1Y, -10f);
        gameObject.transform.position = _camPosition;
    }
}
