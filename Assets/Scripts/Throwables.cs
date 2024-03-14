using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Throwable : MonoBehaviour
{
    public float Force;
    public float Lift;
    public float SpawnAfter;
    [HideInInspector]
    public bool inAir = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.GetComponent<Player>()==null) inAir = false;
    }
}
