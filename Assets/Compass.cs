using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{

    RawImage rawImage;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {

        //rawImage.uvRect = new Rect(x,0,1,1) ;
        Debug.Log(Vector3.SignedAngle(Camera.main.transform.forward,Vector3.forward,Vector3.up));
    }
}
