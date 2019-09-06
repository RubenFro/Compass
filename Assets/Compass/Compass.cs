using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{

    RawImage rawImage;
    public float shiftX = 0.01F;
    private Camera mainCamera;
    void Start()
    {
        rawImage = GetComponent<RawImage>();
        mainCamera = Camera.main;
    }

    void Update()
    {

        float direction = (mainCamera.transform.eulerAngles.y / 360f);
        rawImage.uvRect = new Rect(shiftX + direction, 0, 0.5f, 1);

    }
}
