using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + "has entered the cube");
    }
    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + "is staying in the cube");

    }
    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + "has left the cube");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")/10, 0, Input.GetAxis("Vertical")/10);
    }
}
