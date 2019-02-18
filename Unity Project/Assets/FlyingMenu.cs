using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlyingMenu : MonoBehaviour
{

    public bool fly = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (fly)
        {
            Fly();
            fly = false;
        }
    }

    public void Fly()
    {
        GameObject gameObject = GameObject.Find("Canvas");
        gameObject.transform.DOMove(Vector3.zero, 1, false);
    }
}
