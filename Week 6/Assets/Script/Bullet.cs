﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<EnemyController>())
        {
            other.GetComponent<EnemyController>().Death();
        }
    }
}
