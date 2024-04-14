using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinMovement : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
