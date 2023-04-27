using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public GameObject loopPosition;
    public GameObject resetPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < loopPosition.transform.position.x)
            RepositionBackground();
    }

    private void RepositionBackground()
    {
        transform.position = resetPosition.transform.position;
    }
}
