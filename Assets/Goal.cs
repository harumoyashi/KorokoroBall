using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�����d�Ȃ������Ɏ������s����郁�\�b�h
    private void OnTriggerEnter(Collider other) //other:�Փ˂��Ă�������̏��
    {
        Debug.Log("�S�[���I");
    }
}
