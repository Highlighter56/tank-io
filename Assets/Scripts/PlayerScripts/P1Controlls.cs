using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Controlls : MonoBehaviour
{
    //Test Variable(s)
    [SerializeField] private int test;

    //Movment  Variables
    [SerializeField] private Vector2 _spawnSpot = new Vector2(0f,0f);
    [SerializeField] private Vector2 _movment;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _walkSpeed = 8;

    //Facing Variables
    [SerializeField] private Camera _cam;
    [SerializeField] private Vector2 _mouseCords;
    [SerializeField] private Vector2 _lookDir;
    [SerializeField] private float _angle;

    //First thing to happen when game starts
    void Start()
    {
        gameObject.transform.position = _spawnSpot;
    }

    // Update is called once per frame
    void Update()
    {
        _movment.x = Input.GetAxisRaw("Horizontal");
        _movment.y = Input.GetAxisRaw("Vertical");

        _mouseCords = _cam.ScreenToWorldPoint(Input.mousePosition);
    }


    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movment * _walkSpeed * Time.fixedDeltaTime);

        _lookDir = _mouseCords - _rb.position;
        _angle = Mathf.Atan2(_lookDir.y, _lookDir.x) * Mathf.Rad2Deg - 90f;
        _rb.rotation = _angle;
    }
}
