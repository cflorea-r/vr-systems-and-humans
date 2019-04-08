using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fearofheights : MonoBehaviour
{

    public float endValue;
    public float duration;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.DOMoveY(endValue, duration, false).SetDelay(delay);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
