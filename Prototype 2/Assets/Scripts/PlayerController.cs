using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float range = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Limit player movements to the boundries
        if(transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }

        if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }

        //Get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //Move player on horizontal axis using horizontal input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }
}
