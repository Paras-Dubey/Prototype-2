using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //Move player on horizontal axis using horizontal input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }
}
