using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float lowBound = 40.0f;
    public float topBound = -25.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //delete object when it out is out of boundary
        if (transform.position.z < topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z > lowBound)
        {
            Debug.Log("GAME OVER!!!!");
            Destroy(gameObject);
        }
    }
}
