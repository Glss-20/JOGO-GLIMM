using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{

    private float length;
    private float StarPos;

    private Transform cam;

    public float ParallaxEffect;

    void Start()
    {
        StarPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform;
    }

    void Update()
    {
        float RePos = cam.transform.position.x * (1 - ParallaxEffect);
        float Distance = cam.transform.position.x * ParallaxEffect;

        transform.position = new Vector3(StarPos + Distance, transform.position.y, transform.position.z);
        
        if(RePos > StarPos + length)
        {
            StarPos += length;
        }
        else if(RePos < StarPos - length) 
        {
            StarPos -= length;
        }

    }

}
