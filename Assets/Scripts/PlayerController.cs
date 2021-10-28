using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D player;
    private float horizontal;
    public float speed = 10;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movemente();
    }
    private void Movemente()
    {
        horizontal = Input.GetAxis("Horizontal");
        player.AddForce(Vector2.up * Time.deltaTime * speed * horizontal);
    }
}
