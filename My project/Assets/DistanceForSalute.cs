using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DistanceForSalute : MonoBehaviour
{
    public Animator animatorKing;
    public Animator animatorQueen;
    public float salutationDistance = 0.0f;
    public GameObject firstTracker = null;
    public GameObject secondTracker = null;
    float prevPosition1 = 0f;
    float prevPosition2 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //se spawneaza cu animatia idle
        animatorKing.Play("Idle");
        animatorQueen.Play("Idle");
    }

    
    // Update is called once per frame
    void Update()
    {


        //float ftosDistance = Vector3.Distance(firstTracker.transform.position, secondTracker.transform.position);
        float position1X = firstTracker.transform.position.x;
        float position2X = secondTracker.transform.position.x;


        if (position1X != 0.0f && position2X != 0.0f)
        {
            if (position1X != prevPosition1 && position2X != prevPosition2)
            {//on the left side(looking on the screen) we keep the king, on the right side the queen.
                if (position2X - position1X < salutationDistance)
                {
                    animatorKing.Play("Attack");
                    animatorQueen.Play("Get_hit");
                    print("salutari");
                }
                else
                {
                    if (position1X - position2X < salutationDistance)
                    {
                        animatorKing.Play("Idle");
                        animatorQueen.Play("Idle");
                        print("stop");
                    }
                }               //if we move away the cards, the position will remain the last known one so we have to check if it was removed or so
                // we are counting on the fact that nobody can stay perfectly still so the cards will be moving anyway
                prevPosition1 = position1X;
                prevPosition2 = position2X;
                //Debug.Log(ftosDistance);
            }
        }

    }
}
