using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> spawnPoints;
    public float spawnAfter;
    public LayerMask noPlayerNoEnemy;
    public GameObject enemy;

    float currTime;

    private void Start()
    {
        currTime = spawnAfter;
    }

    void spawn(Vector3 pos)
    {
        GameObject curr = Instantiate(enemy, pos, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        currTime -= Time.fixedDeltaTime;
        if (currTime <= 0)
        {
            List<GameObject> hidden = new List<GameObject>();
            foreach (GameObject point in spawnPoints)
            {
                if (Physics.Raycast(transform.position, point.transform.position - transform.position, Vector3.Distance(transform.position, point.transform.position), noPlayerNoEnemy)){
                    hidden.Add(point);
                }
            }
            if (hidden.Count > 0)
            {
                int i = Random.Range(0, hidden.Count);
                spawn(hidden[i].transform.position);
                hidden.Clear();
            }
            currTime = spawnAfter;
        }
    }

}
