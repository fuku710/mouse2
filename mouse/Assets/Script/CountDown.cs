// ゲームスタート時にカウントダウンする

using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class CountDown : MonoBehaviour {

    public static int MAX_TIME = 4; // カウントダウンの開始値
    private GameObject selected;
    float timeCounter = MAX_TIME;
    private GameObject Car_boar;    // ゲームオブジェクトの定義
    private GameObject Car_mouse;

    void Start()
    {
        GetComponent<UnityEngine.UI.Text>().text = MAX_TIME.ToString();
    }

    void Update()
    {
        timeCounter -= Time.deltaTime;

        Car_boar = GameObject.Find("Car_boar");    // ゲームオブジェクトの設定
        Car_mouse = GameObject.Find("Car_mouse");
        Rigidbody cb = Car_boar.GetComponent<Rigidbody>();
        Rigidbody cm = Car_mouse.GetComponent<Rigidbody>();

        if (timeCounter > 1)    // ゲームが開始するまでネズミ、イノシシの動作を停止
        {
            cb.isKinematic = true;
            cm.isKinematic = true;
        }

        // マイナス値にならないようにしている
        timeCounter = Mathf.Max(timeCounter, 0.0f);
        GetComponent<UnityEngine.UI.Text>().text = ((int)timeCounter).ToString();

        if (timeCounter <= 1)    // ゲーム開始時にネズミ、イノシシの動作再開
        {
            GetComponent<UnityEngine.UI.Text>().enabled = false;    // カウントダウン非表示
            cb.isKinematic = false;
            cm.isKinematic = false;
        }
    }
}
