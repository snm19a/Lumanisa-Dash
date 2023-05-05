using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    private GameObject despawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        despawnPosition = GameObject.Find("DespawnPosition");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < despawnPosition.transform.position.x)
            Destroy(gameObject);
    }
}
