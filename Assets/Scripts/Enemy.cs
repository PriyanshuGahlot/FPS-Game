using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    private void Update()
    {
        if (health <= 0) Die();
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
    }

    void Die()
    {
        Debug.Log("Dead");
    }
}
