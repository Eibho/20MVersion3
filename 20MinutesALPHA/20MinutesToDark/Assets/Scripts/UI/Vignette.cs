using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vignette : MonoBehaviour
{
    public Image image;

    void Start()
    {
        var tempColor = image.color;
        tempColor.a = 0.5f;
        image.color = tempColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
