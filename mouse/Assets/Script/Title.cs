using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 2, 200, 40), "ステージ1"))
        {
            SceneManager.LoadScene("Stage_never");
        }
        if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 1.5f, 200, 40), "ステージ2"))
        {
            SceneManager.LoadScene("GameScene2");
        }
    }
}