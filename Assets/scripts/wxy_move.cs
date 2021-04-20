using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wxy_move : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 speed = new Vector2(2, 2);
    private Vector2 movement;
    private Rigidbody2D RigidbodyComponent;
    void Start()
    {
        transform.position = new Vector3(-4, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        movement = new Vector2(speed.x * x, speed.y * y);
    }
    private void FixedUpdate()
    {
        if (RigidbodyComponent == null) RigidbodyComponent = GetComponent<Rigidbody2D>();
        RigidbodyComponent.velocity = movement;
    }
}
