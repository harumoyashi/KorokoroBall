using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.velocity = new Vector3(); //移動ベクトルを0,0,0に
            r.angularVelocity = new Vector3();
        }
    }
}