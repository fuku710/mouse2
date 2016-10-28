using UnityEngine;
using System.Collections;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    private float offset = 5f;
    public float adjust_y;
    public float adjust_z;

    void Start ()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + offset + adjust_y, player.transform.position.z - offset + adjust_z);
    }

    void Update ()
    {

    }
}