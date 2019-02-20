using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{

    [Range(0, 5)]
    public int damping;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform tree in transform)
        {
            //Transform target = GameObject.Find("Main Camera").transform;
            Transform target = UnityEditor.SceneView.lastActiveSceneView.camera.transform;
            var lookPos = target.position - tree.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            tree.rotation = Quaternion.Slerp(tree.rotation, rotation, Time.deltaTime * damping);
        }
    }
}
