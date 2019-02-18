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
        if (fly || Input.GetKeyDown(KeyCode.F))
        {
            Fly();
            fly = false;
        }
    }

    public void Fly()
    {
        GameObject gameObject = GameObject.Find("Canvas");
        gameObject.transform.position = new Vector3(0, 0, 25);
        gameObject.transform.DOMove(new Vector3(0, 0, 2.5f), .5f, false);
    }
}
