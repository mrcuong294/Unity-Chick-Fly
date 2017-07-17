using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainParamter : MonoBehaviour {
    public const float S = 384400000; // khoảng cách trái đất tới mặt trang (m)
    public const float G = 9.8f;
    public float maxGiaToc;
    public float giaToc;
    public float vanToc;
    public float doCao;
    public bool isBoot;
    public bool isImpactCloud;


    // Use this for initialization
    void Start () {
        doCao = 0;
        isBoot = false;
        isImpactCloud = false;

    }
	
	// Update is called once per frame
	void Update () {
        // Tinh hieu gia toc - gia toc trong truong;
        float hieuGiaToc = giaToc - G;

        // Van toc bay, van toc am => dang roi;
        vanToc = hieuGiaToc * Time.deltaTime;

        // van toc = 0 khi tiep dat;
        if(doCao <= 0)
        {
            // Tiep dat v = 0;
            vanToc = 0;
        } else if(isImpactCloud && vanToc <= 0)
        {
            // Cham vao dam may khi dang roi v = 0;
            vanToc = 0;
        }

        // Tinh do cao bay theo van toc;
        doCao += vanToc * Time.deltaTime;

        // Dao chieu vector gia toc;
        if (giaToc >= maxGiaToc)
        {
            isBoot = false;
        }

        // Gia toc bien thien;
        if(isBoot)
        {
            // Gia toc tang;
            giaToc += G * Time.deltaTime;
        } if (giaToc > 0)
        {
            // Gia toc giam
            giaToc -= (G / 6) * Time.deltaTime;
        } if(giaToc < 0)
        {
            giaToc = 0;
        }
        Debug.Log("Gia toc = " + giaToc);
        Debug.Log("Van toc = " + vanToc);
        Debug.Log("Do cao = " + doCao);
    }

    public void updateCharPosition()
    {

    }

    public void onClickBtnLauncher()
    {
        maxGiaToc = 3 * G;
        isBoot = true;
    }
}
