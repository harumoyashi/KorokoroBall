using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tereport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject exitObject;
    private void OnTriggerEnter(Collider other)
    {
        if (exitObject != null)
        {
            other.transform.position = exitObject.transform.position;
        }
    }
}
