using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    public GameObject target;
    int x = 2;
    // Start is called before the first frame update
    void Start()
    {

        target = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {
       
            target.transform.Translate(Input.GetAxis("Horizontal")*0.5f, 0f, Input.GetAxis("Vertical")*0.5f);
            
        

       // target.transform.Translate(Input.GetAxis("Horizontal") * .5f, 0f, Input.GetAxis("Vertical") * .5f);

        //target.transform.Rotate(Input.GetAxis("Mouse Y") * 3f, -Input.GetAxis("Mouse X") * 3f, 0f);
        if (Input.GetKeyUp(KeyCode.N))
        {
            transform.localScale = new Vector3(x, x, x);

        }
        
    }
        

}
