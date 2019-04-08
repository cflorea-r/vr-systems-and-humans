using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeFOV : MonoBehaviour
{
    public float fieldOfView;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.fieldOfView = fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
