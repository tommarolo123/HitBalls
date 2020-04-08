using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCubeScirpt : MonoBehaviour
{
    private GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindWithTag("ccub");
    }

    // Update is called once per frame
    void Update()
    {
        Target.transform.Translate(.05f, 0f, 0f);
        Target.transform.Rotate(0f, 0f, 1f);
        Target.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }

}
