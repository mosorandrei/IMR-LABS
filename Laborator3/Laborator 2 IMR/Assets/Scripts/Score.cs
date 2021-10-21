using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMesh score;
    public void OnTriggerEnter(Collider collisionInfo)
    {
       
        if (collisionInfo.tag=="Transparent")
        {  
            score.text = "GOOD JOB!";
        }
    }
     

// Start is called before the first frame update
void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
