using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Generate a random color
            Color newColor = new Color(Random.value, Random.value, Random.value);

            // Change the color of the object
            rend.material.color = newColor;
        }
    }
}
