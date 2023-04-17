using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

  Rigidbody2D rb;
    float force = 200;

    bool jumpButtonPressed = false;
    void move ()
    {
        rb.AddForce(transform.up * force * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position + new Vector3(0,1,0);
        transform.Translate(new Vector3(0,1,0), Space.Self);
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    
    {   

        if (Input.GetKeyDown(KeyCode.Joystick1Button0))

    {
        move();
    }

        if (Input.GetButtonDown("Jump")) // Input.GetKeyUp(KeyCode.Space)
        {
            jumpButtonPressed = true;
        }

        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        float speed = 25;
        Debug.Log(xInput);

        gameObject.transform.Translate(
            new Vector3(xInput * Time.deltaTime * speed, yInput * Time.deltaTime * speed, 0f)
        );
    }

        void FixedUpdate()
    {
        if (jumpButtonPressed) { // discrete
            rb.AddForce(new Vector2(0, 200));
            jumpButtonPressed = false;
        }
    }
}
