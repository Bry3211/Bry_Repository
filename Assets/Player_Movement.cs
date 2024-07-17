using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
        }
    }
}