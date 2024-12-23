using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed = 3.5f;

    public string layer;
    public string sortingLayer;

    public Vector2 _movement;

    public void OnMovement(InputValue value)
    {
        _movement = value.Get<Vector2>();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovment();

    }

    private void CalculateMovment()
    {
        transform.transform.Translate(new Vector3(_movement.x, _movement.y, 0) * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "Alter")
        {
            Debug.Log("Alter stepped on");
        }
    }
}
