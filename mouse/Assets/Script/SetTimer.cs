using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour {

	private int minute;
	private float second;
	private int oldSecond;
	//private bool timerFlag = true;
	private Text textField;

	// Use this for initialization
	void Start () {
		minute = 0;
		second = 0;
		oldSecond = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale > 0) {
			second += Time.deltaTime;
			if (second >= 60.0f) {
				minute++;
				second = second - 60;
			}
			if ((int)second != oldSecond) {
				this.GetComponent<Text>().text = minute.ToString ("00") + ":" + second.ToString ("00");
			}
			oldSecond = (int)second;
		}
	}
}
