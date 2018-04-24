using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class third_layer : MonoBehaviour
{

    public float speed = -.2f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x <= -18.5)
        {
            transform.Translate(38.1f, 0f, 0f);
        }

    }
}