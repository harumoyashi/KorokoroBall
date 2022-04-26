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

    //何か重なった時に自動実行されるメソッド
    private void OnTriggerEnter(Collider other) //other:衝突してきた相手の情報
    {
        Debug.Log("ゴール！");
    }
}
