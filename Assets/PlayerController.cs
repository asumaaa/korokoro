using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float power = 10;
    public Rigidbody rigitbody;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigitbody.AddForce(new Vector3(0, 0, 1) * power);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigitbody.AddForce(new Vector3(-1, 0, 0) * power);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigitbody.AddForce(new Vector3(0, 0, -1) * power);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigitbody.AddForce(new Vector3(1, 0, 0) * power);
        }
    }
}
