using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("General")]
    public bool Flying;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool Grounded;

    [Header("Dying Info")]
    public Transform deathCheck;
    public LayerMask obstacleLayer;

    [Header("Jumping Info")]
    public int DoubleJumpCount;
    private int jumpsExpended;
    public float JumpUpForce;

    [Header("Flying Info")]
    public float FlyUpForce;
    public float FlyBoost;
    
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        //Ground Check

        Grounded = IsGrounded();
        if (Grounded == true)
        {
            jumpsExpended = 0;
        }

        if (IsDead())
        {
            GameControl.instance.gameOver = true;
        }

        if (GameControl.instance.gameOver == false)
        {
            if (Input.GetMouseButtonDown (0))
            {
                if (!Flying)
                {
                    if (DoubleJumpCount > jumpsExpended || Grounded)
                    {
                        jumpsExpended++;
                        rb2d.velocity = Vector2.zero;
                        rb2d.AddForce(new Vector2(0, JumpUpForce));
                    }
                }
                else
                {
                    rb2d.AddForce(new Vector2(0, FlyBoost));

                }
                
            }

            if (Input.GetMouseButton (0))
            {
                if (Flying)
                {
                    rb2d.AddForce(new Vector2(0, FlyUpForce));
                }
            }    
        }  
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    private bool IsDead()
    {
        return Physics2D.OverlapCircle(deathCheck.position, 0.15f, obstacleLayer);
    }
}
