﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CheckForRaycastHit()
    {
        RaycastHit hit;
        if (Physics.Raycast (transform.position,transform.forward,out hit))
        {
            print(hit.collider.gameObject.name + "destoryed!");
            Destroy(hit.collider.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        transform.Rotate(dirX, dirY, 0);
        CheckForRaycastHit();
    }
}
