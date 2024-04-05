using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchShooting : MonoBehaviour
{
    public GameObject attack;
    public Transform startPos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) spawn();
    }

    void spawn()
    {
        GameObject attackCurr = Instantiate(attack, startPos.position, Quaternion.identity);
        attackCurr.transform.forward = Camera.main.transform.forward;
    }

}
