using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Vector3 pos;
    private int playerDirection;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerDirection = 0;
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = 0;
        if (Input.GetKey(KeyCode.D))
        {
            playerDirection++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerDirection--;
        }
        rigidbody.AddForce(Vector3.right * speed * playerDirection);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
