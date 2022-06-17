using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    CanvasGroup a;
    bool fade = false;
    public void Fade()
    {
        if (fade == false && a.alpha < 255.0f)
        {
            a.alpha += 1.0f;
        }

        if (a.alpha >= 255.0f)
        {
            fade = true;
        }

        if (fade == true && a.alpha > 0.0f)
        {
            a.alpha -= 1.0f;
        }

        if (a.alpha <= 0.0f)
        {
            fade = false;
        }
    }
}
