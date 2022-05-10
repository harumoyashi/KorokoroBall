using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addSpeedPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public float power = 3;
    private void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.AddForce(new Vector3(0, 0, 1) * power * 3);   //Vector3:加速したい方向
        }
    }
}
