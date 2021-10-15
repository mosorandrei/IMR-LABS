using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject transparent;
    void OnTriggerEnter(Collider someObject)
    {
        if (someObject.transform.gameObject.tag == "Ball")
        {
            Destroy(transparent);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
