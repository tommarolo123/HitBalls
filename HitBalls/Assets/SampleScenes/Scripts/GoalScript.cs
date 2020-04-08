
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.gameObject.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
