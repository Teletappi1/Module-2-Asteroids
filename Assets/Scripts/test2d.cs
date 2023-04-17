using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2d : MonoBehaviour
{
    //Rigibody2D rb;
    Rigidbody2D rb;
    float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
        force += 100 * Time.deltaTime;
        Debug.Log(force);
        }    
        if (Input.GetButtonUp("jump"))
        {
            rb.AddForce(new Vector2(0, force));
            force = 0;
        }

        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        float speed = 50;
        Debug.Log(xInput);

        gameObject.transform.Translate(
            new Vector3(xInput * Time.deltaTime * speed, yInput * Time.deltaTime * speed, 0f)
        );


    }
}
