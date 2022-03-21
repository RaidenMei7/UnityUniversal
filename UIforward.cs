 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIforward : MonoBehaviour
{
    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = camera.transform.forward;
        transform.rotation = camera.transform.rotation;
        
    }
}
