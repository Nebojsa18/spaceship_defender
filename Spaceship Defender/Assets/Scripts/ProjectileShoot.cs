using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Instantiate(projectilePrefab, transform.position,  Quaternion.Euler(0,0,180f));
        }
    }



    
}
