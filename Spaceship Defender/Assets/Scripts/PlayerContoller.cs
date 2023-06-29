using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right *-1*hInput* moveSpeed * Time.deltaTime);
    }
}
