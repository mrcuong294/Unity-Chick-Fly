using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    GameObject boxSprings;

	public void startGameClick()
    {
        boxSprings = GameObject.FindGameObjectWithTag("BoxSpring");
        CharControl.flyHeight = 20;
        CharControl.isBoot = true;
        Debug.Log("Button launcher clicked");
    }
}
