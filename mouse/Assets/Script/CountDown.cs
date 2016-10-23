using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public static int MAX_TIME = 4;    // カウントダウンの開始値
    private GameObject selected;
    float timeCounter = MAX_TIME;
    private GameObject Car_boar;       // イノシシの定義
    private GameObject Car_mouse;      // ネズミの定義
    public Text countDown;
    
    void Start()
    {
        countDown = GetComponent<UnityEngine.UI.Text>();
        countDown.text = MAX_TIME.ToString();
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
        countDown.text = ((int)timeCounter).ToString();

        if (timeCounter <= 1)    // ゲーム開始時にネズミ、イノシシの動作再開
        {
            countDown.enabled = false;    // カウントダウン非表示
            cb.isKinematic = false;
            cm.isKinematic = false;
        }
    }
}
