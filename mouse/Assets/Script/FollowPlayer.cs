using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public GameObject player;
	private float offset = 30f;

	void Start ()
	{

	}

	void Update ()
	{
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offset, player.transform.position.z);
	}
}