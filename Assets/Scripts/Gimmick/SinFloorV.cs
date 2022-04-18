using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinFloorV : MonoBehaviour
{
    public float speed;
    public float length;

    float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAccount = speed * Time.deltaTime;

        t += moveAccount;

        transform.localPosition = new Vector3(transform.position.x, Mathf.PingPong(t, length) - length / 2.0f, transform.position.z); 
    }
}
