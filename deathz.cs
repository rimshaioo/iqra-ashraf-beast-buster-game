﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathz : MonoBehaviour {
 public int EnemyHealth = 20;
    public GameObject theEnemy;
    public int statuscheck;
   public AudioSource Death;
    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    // Update is called once per frame
    void Update () {
		if(EnemyHealth<=0 && statuscheck == 0)
        {
            this.GetComponent<Z>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            statuscheck = 2;
            theEnemy.GetComponent<Animation>().Stop("walkZ");
            theEnemy.GetComponent<Animation>().Play("deathZ");
           Death.Play();
        }
	}
}
