using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granade : MonoBehaviour
{
    public LayerMask enemyLayer;
    public float range;
    public int damage;
    public int maxBounces;

    int bounces;

    private void OnCollisionEnter(Collision collision)
    {
        bounces++;
    }

    private void Update()
    {
        if (bounces >= maxBounces) blast();
    }

    void blast()
    {
        RaycastHit[] objs = Physics.SphereCastAll(transform.position, range, Vector3.up, enemyLayer);
        foreach(RaycastHit hit in objs)
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null) enemy.TakeDamage(damage);
        }
    }

}
