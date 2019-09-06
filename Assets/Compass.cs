using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{

    RawImage rawImage;
    public float shiftX = 0.01F;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    void Update()
    {

        float direction= (Camera.main.transform.eulerAngles.y / 360f);
        rawImage.uvRect = new Rect(shiftX+direction, 0, 0.5f, 1);

    }
}
