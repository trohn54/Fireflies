using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionControl : MonoBehaviour
{
    public Material material;
    Color color = new Color(0,0,0);
    float f = -3;
    float j = 1f;
    // Start is called before the first frame update
    void Start()
    {
        material.SetColor("_EmissionColor", color);
        //material.DisableKeyword("_EMISSION");
        
    }

    // Update is called once per frame
    void Update()
    {
        color = OscillatingColor();
        material.SetColor("_EmissionColor", color);
    }

    Color OscillatingColor()
    {
        
        if (f > 1)
        {
            j = -.0125f;
        }
        if (f < -1)
        {
            j = .0125f;
        }

        f += j;
        Debug.Log(f);
        return new Color(f, f, f*0.5f);  //light yellow
    }
}
