using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Item that when used while held acts as a physics based projectile instantiator
/// </summary>
public class NerfGunItem : InteractiveItem
{
    public GameObject nerfDartPrefab;
    public Transform nerfDartSpawnLocation;
    public float fireRate = 1;
    public float launchForce = 10;
    protected float fireRateCounter;
    public GameObject bullet;


    protected void Update()
    {
    }

    public override void OnUse()
    {
        base.OnUse();

        
         bullet = Instantiate(nerfDartPrefab, nerfDartSpawnLocation.position, Quaternion.identity);FireNow();

    }

    public void FireNow()
    {
        Debug.Log("lll");
       
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * launchForce); 
        
    }

   
}
