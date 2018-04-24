using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {

    Rigidbody rigidBody;
    public bool dead = false;

    

    void Start()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody>();
    }
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            rigidBody.AddForce(Vector3.up * 400f);
        }
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "scoreZone")
        {
            game_controller.instance.playerScored();
        }

        if(col.gameObject.tag == "deadZone")
        {
            dead = true;
            game_controller.instance.playerDied();
            Time.timeScale = 0;
            
        }
    }
}
