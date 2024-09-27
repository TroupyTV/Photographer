using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 10;
    public int speedRotate = 70;
    private float horizontal;
    private float vertical;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * vertical * Time.deltaTime);
        transform.Rotate(Vector3.up * speedRotate * horizontal * Time.deltaTime);
    }
}
