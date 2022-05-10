using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float power = 8;
    public Vector3 jumpAngle = new Vector3(0, 1, 1);
    private void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            r.velocity = jumpAngle.normalized * power;  //jumpAngle:方向ベクトルなので正規化してる
        }
    }
}
