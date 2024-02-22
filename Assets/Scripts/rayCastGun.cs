using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastGun : MonoBehaviour
{
    public int damage = 1;
    public float reloadTime;
    private bool isReloading;
    //public float fireRate;
    //public int magSize;
    float currAmmo;
    public int maxAmmo;

    void Start()
    {
        if (currAmmo == -1)
            currAmmo = maxAmmo;
    }

    void Update()
    {
        if (isReloading)
            return;
        if (currAmmo <= 0)
        {
            StartCoroutine(Reload());
            Reload();
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading");
        yield return new WaitForSeconds(reloadTime);
        currAmmo = maxAmmo;
        isReloading = false;
    }
    void Shoot()
    {
        currAmmo--;
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            Enemy target = hit.transform.GetComponent<Enemy>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
