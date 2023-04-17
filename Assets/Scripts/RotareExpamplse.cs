using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotareExpamplse : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pivot;
    void Start()
    {
       /* transform.RotateAround(
            pivot.transform.position, Vector3.forward, 50 * Time.deltaTime
        );
        transform.Rotate(0, 0, 100 * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0, 0, 40);*/

            
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(
            pivot.transform.position, Vector3.forward, 50 * Time.deltaTime
            );
        /*transform.Rotate(0, 0, 100 * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0, 0, 40);*/
            
               }
}
