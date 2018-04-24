using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_layer_scroll : MonoBehaviour {

    public float speed = -4f;

	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

      if (transform.position.x<=-18.5)
        {
            transform.Translate(38.1f, 0f, 0f);
        }
      
    }
}
