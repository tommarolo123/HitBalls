
using UnityEngine;

public class VelocityScripts : MonoBehaviour
{
    public float startSpeed = 50f;    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
