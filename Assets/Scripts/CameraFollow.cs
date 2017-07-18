using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothing;

    Vector3 offset;
    //Vector3 offsetBgStatic;

    //GameObject bgStatic;


	// Use this for initialization
	void Start () {
        //bgStatic = GameObject.FindGameObjectWithTag("BgStatic");

        offset = transform.position - target.position;
        //offsetBgStatic = bgStatic.transform.position - target.position;
        smoothing = 50;
       
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(
            transform.position, targetCamPos, smoothing*Time.deltaTime);

        //Vector3 targetBgStaticPos = target.position + offsetBgStatic;
        //bgStatic.transform.position = Vector3.Lerp(
            //bgStatic.transform.position, targetBgStaticPos, smoothing * Time.deltaTime);

    }
}
