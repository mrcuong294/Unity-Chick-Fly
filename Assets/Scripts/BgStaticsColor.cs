using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgStaticsColor : MonoBehaviour {

    public float maxHeight;
    public float colorAlpha;
    
    Image image;
    // Use this for initialization
    void Start () {
        
        colorAlpha = 1f;
        image = GetComponent<Image>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if(CharControl.flyHeight > maxHeight && colorAlpha > 0.01)
        {
            colorAlpha = Mathf.Pow(maxHeight, 3) / Mathf.Pow(CharControl.flyHeight, 3);
            colorAlpha = Mathf.Abs(colorAlpha);
            if (colorAlpha > 1) colorAlpha = 1;

            image.color = new Color(0.211764706f, 0.780392157f, 0.956862745f, colorAlpha);
        }
    }
}
