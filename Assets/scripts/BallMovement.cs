using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float startSpeed;
    public float extraSpeed;
    public float maxExtraSpeed;

    public bool player1Start = true;


    private int hitCounter;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

        StartCoroutine(Launch());
    }

    private void RestartBall()
    {
        rb.velocity = new Vector2(0,0);
        transform.position = new Vector2(0,0);

    }

     public IEnumerator Launch()
     {

        RestartBall();
        hitCounter=0;
        yield return new WaitForSeconds(1);

        if(player1Start == true)
        {
            MoveBall(new Vector2(-1,0));
        }
        else
        {
             MoveBall(new Vector2(1,0));
        }

        Debug.Log("timeout");


     }

   
    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;

        float ballSpeed= startSpeed + hitCounter * extraSpeed;

        rb.velocity = direction * ballSpeed;   
    }

    public void IncreaseHitCounter()
    {
        if(hitCounter * extraSpeed < maxExtraSpeed)
        {
            hitCounter++;
        }
    }
}
