using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    public float jumHeight;
    GameObject boxSprings;

    private void Start()
    {
        boxSprings = GameObject.Find("BoxSprings");
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            boxSprings.transform.localScale = new Vector3(1f, 0.8f, 1f);
            transform.localScale = new Vector3(0.6f, 0.6f, 1f);
            
        } else if(Input.GetMouseButtonUp(0))
        {
            boxSprings.transform.localScale = new Vector3(1f, 1f, 1f);
            transform.localScale = new Vector3(0.7f, 0.7f, 1f);
            CharControl.jumHeight = jumHeight;
            CharControl.isBoot = true;
            
        }
    }
   
}
