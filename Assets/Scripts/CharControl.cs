using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour {

    public static float flyHeight;
    public static bool isBoot;

    Rigidbody2D charBody;

	// Use this for initialization
	void Start () {
        charBody = GetComponent<Rigidbody2D>();
        isBoot = false;
        Debug.Log("Game started");
    }

    // Update is called once per frame
    void FixedUpdate() {
		if(isBoot)
        {
            isBoot = false;
            charBody.velocity = new Vector2(charBody.velocity.x, flyHeight);
            Debug.Log("Char runing X = " + charBody.velocity.x);
            Debug.Log("Char runing Y = " + charBody.velocity.y);
        }
	}

}
