using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 600.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var gravity = new Vector3 (
            Input.acceleration.x,
            0,
            Input.acceleration.y
        ) * speed;

        GetComponent<Rigidbody>().AddForce (gravity, ForceMode.Acceleration);
    }
}
