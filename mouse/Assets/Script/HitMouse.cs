using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HitMouse : MonoBehaviour {

	public Text winner_text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision hit){ //衝突したとき
		if(hit.gameObject.CompareTag("Mouse")){ //Mouseタグ
			//現在のシーンを読み直す
			/*
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;

			SceneManager.LoadScene(sceneIndex);
			*/

			//イノシシの勝利テキスト
			winner_text.GetComponent<Text>().text = "イノシシの勝ち";
		}
	}
}
