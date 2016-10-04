using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HitMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision hit){ //衝突したとき
		if(hit.gameObject.CompareTag("Mouse")){ //Mouseタグ
			//現在のシーンを読み直す
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;

			SceneManager.LoadScene(sceneIndex);
		}
	}
}
