using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float power = 20;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody r = other.GetComponent<Rigidbody>();
        if (r != null)
        {
            //当たった時の位置から逆方向割り出して、プレイヤーをはじく
            Vector3 angle = (other.transform.position - transform.position).normalized;   //angle:方向ベクトルなので正規化してる
            r.velocity = angle * power;  
        }
    }
}
