using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_layer : MonoBehaviour
{

    public float speed = -1f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

        if (transform.position.x <= -18.5)
        {
            transform.Translate(37.5f, 0f, 0f);
        }

    }
}
