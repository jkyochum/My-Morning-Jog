using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour {

    public float speed = -5f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }


}
