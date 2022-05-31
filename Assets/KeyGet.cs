using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGet : MonoBehaviour
{
    public GameObject door;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(door);
        Destroy(gameObject);
    }
    public Rigidbody rigibody;
    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
