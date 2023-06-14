using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float parallaxFactor = 0.5f; 

    void Update()
    {
        float parallaxOffset = Time.deltaTime * parallaxFactor;
        transform.Translate(Vector3.left * parallaxOffset);
    }
}
