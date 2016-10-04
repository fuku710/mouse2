using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 200, 40), "スタートボタン"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}