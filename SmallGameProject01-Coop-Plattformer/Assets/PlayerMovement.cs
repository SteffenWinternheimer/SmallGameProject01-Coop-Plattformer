using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Movement")]
    private Rigidbody2D rb;
    [SerializeField] private float speed, jumpForce, checkRadius;
    private float input;
    [SerializeField] private Transform groundCheck;
    private bool isGround;
    [SerializeField] private LayerMask groundLayerMask;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayerMask);
        input = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(input * speed * Time.deltaTime, rb.velocity.y);
        if (isGround && Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce * Time.deltaTime;
        }
    }
}
