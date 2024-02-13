using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health;
    int currHealth;

    private void Start()
    {
        currHealth = Health;
    }

    private void Update()
    {
        if (currHealth <= 0) Die();
    }

    public void fullHeal()
    {
        currHealth = Health;
    }

    void Die()
    {

    }

}
