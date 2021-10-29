using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rB;
    private float horizontal;
    public float speed = 10;
    public float jump = 10;
    private Vector2 move;
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Pulo();
        Movemente();

    }
    private void FixedUpdate()
    {
        rB.AddForce(move * speed * Time.deltaTime, ForceMode2D.Force);
    }

    private void Movemente()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
       
    }
    private void Pulo()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rB.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }
}
