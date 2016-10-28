using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour {

	private float totalTime;
	private int minute;
	private float second;
	private float timeCounter;
	private int oldSecond;
	//private bool timerFlag = true;
	private Text textField;
    public Text winner_text;

	// Use this for initialization
	void Start () {
		minute = 1;
		second = 2f;
		totalTime = minute * 60 + second;
		timeCounter = 63;                // 60+3秒(カウントダウン)
		oldSecond = 0;
		textField = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Time.timeScale > 0 && totalTime > 0f) {
			totalTime = minute * 60 + second;
			totalTime -= Time.deltaTime;

			minute = (int)(totalTime / 60);
			second = totalTime - minute * 60;
			if ((int)second != oldSecond) {
				textField.text = minute.ToString ("00") + ":" + second.ToString ("00");
			}
			oldSecond = (int)second;

			if (totalTime <= 0f) {
				Debug.Log ("制限時間終了");
			}
		}
		*/
		timeCounter -= Time.deltaTime;

		timeCounter = Mathf.Max (timeCounter, 0.0f);
        if (timeCounter > 60)
        {
            textField.text = "60";
        }
        else
        {
            textField.text = ((int)timeCounter).ToString();
        }

    }
}
