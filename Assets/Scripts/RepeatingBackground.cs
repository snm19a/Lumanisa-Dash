using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public GameObject loopPosition;
    public float loopOffset;
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D> ();
        groundHorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < loopPosition.transform.position.x)
            RepositionBackground();
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2 (groundHorizontalLength * loopOffset, 0);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
