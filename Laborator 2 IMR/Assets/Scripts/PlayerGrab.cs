using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public GameObject ball;
    public GameObject myHand;
    bool inHands;
    Vector3 ballPosition;
    // Start is called before the first frame update
    void Start()
    {
        ballPosition = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ball.transform.SetParent(myHand.transform);
            ball.transform.localPosition = myHand.transform.localPosition;
        } else if(inHands)
        {
            ball.transform.SetParent(null);
            ball.transform.localPosition = ballPosition;
        }
    }
}
