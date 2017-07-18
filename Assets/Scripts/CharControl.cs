using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour {

    public static float flyHeight;
    public static float jumHeight;
    public static float consForceY;
    public static bool isBoot;

    Rigidbody2D charBody;
    ConstantForce2D consForce;

	// Use this for initialization
	void Start () {
        flyHeight = 0;
        charBody = GetComponent<Rigidbody2D>();
        
        isBoot = false;
        Debug.Log("Game started");
    }

    // Update is called once per frame
    void FixedUpdate() {
		if(isBoot)
        {
            isBoot = false;
            charBody.velocity = new Vector2(charBody.velocity.x, jumHeight);
            
            consForceY = jumHeight / 2;
            Debug.Log("Char runing X = " + charBody.velocity.x);
            Debug.Log("Char runing Y = " + charBody.velocity.y);
        }
        
        flyHeight = transform.position.y;
	}

    private void Update()
    {
        if (consForceY > 0)
        {
            consForce.relativeForce = new Vector2(0, consForceY);
            consForceY -= 1 * Time.deltaTime;
            if(consForceY < 1)
            {
                consForceY = 0;
            }
        }
    }

}
