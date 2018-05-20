﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotationsPerSecond = 1;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(0, 0, -360f * rotationsPerSecond * Time.deltaTime);
    }
}
