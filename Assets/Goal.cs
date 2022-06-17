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

    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSource;
    public ParticleSystem particle;

    private void OnTriggerEnter(Collider other) //other:なにかオブジェクト
    {
        Debug.Log("ゴール！");

        clearText.SetActive(true);
        nextButton.SetActive(true);
        particle.Play();
        audioSource.Play();
    }
}
