using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class menuflyingatyou : MonoBehaviour
{

    public float endValue;
    public float duration;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.position = new Vector3(0, 0, 100);
        canvas.transform.DOMoveZ(endValue, duration, false).SetDelay(delay);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
