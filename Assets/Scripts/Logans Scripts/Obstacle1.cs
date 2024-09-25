using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle1 : MonoBehaviour
{

    Rigidbody Rigidbody;
    public Transform pointA;
    public Transform pointB;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        //pointA = transform.position = new Vector3(0.5f, 0.5f, -17);
        //pointB = transform.position = new Vector3(5.5f, 0.5f, -17);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA.position, pointB.position, time);
    }
}
