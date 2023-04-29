using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("yah")]
    public bool Flying;

    [Header("Jumping Info")]
    public int jumpCount;
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
        if (Input.GetMouseButtonDown (0))
        {
            if (!Flying)
            {
                if (jumpCount > jumpsExpended)
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
