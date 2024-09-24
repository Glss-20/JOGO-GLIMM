using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length;
    private float startPos;

    private Transform cam;

    public float parallaxEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform;
    }

    void Update()
    {
        float distance = cam.transform.position.x * parallaxEffect;
        float newPos = startPos + distance;

        // Atualizar a posição do objeto
        transform.position = new Vector3(newPos, transform.position.y, transform.position.z);

        // Verificar se o objeto precisa ser reposicionado
        if (cam.transform.position.x > startPos + length)
        {
            startPos += length;
        }
        else if (cam.transform.position.x < startPos - length)
        {
            startPos -= length;
        }
    }
}
