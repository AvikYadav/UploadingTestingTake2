using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    [SerializeField] float speed = 5f;

    void Update()
    {
        //float z = Input.GetAxis("Horizontal");
        //transform.Translate(new Vector3(0, 0, z) * Time.deltaTime) ;


        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, -1) * Time.deltaTime * speed;
        }
    }
}
