using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //忘れない
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Screen.SetResolution(1920, 1080, false);    //1920x1080のウィンドウモード
                                                    //trueにするとフルスクリーンになる
        Application.targetFrameRate = 60;   //FPS固定
        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //リセットボタン
    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    //次のシーンに切り替え
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }

    //コイン取得数カウント
    private int coinCount;
    public Text textComponent;
    public void AddCoinCount()
    {
        coinCount++;
        Debug.Log("CoinCount:" + coinCount);
        textComponent.text = "CoinCount:" + coinCount;
    }
}
