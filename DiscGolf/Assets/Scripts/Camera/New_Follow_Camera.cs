﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Follow_Camera : MonoBehaviour {

    private Vector3 offset;
    private Vector3 stand_offset;
    private SimulatorUIhelper frisbee;
    public camera_mode mode = camera_mode.throw_mode;

    private float climbSpeed = 4;
    private float normalMoveSpeed = 10;
    private float slowMoveFactor = 0.25f;
    private float fastMoveFactor = 3;

    void Start()
    {
        frisbee = FindObjectOfType<SimulatorUIhelper>();
        offset = transform.position - frisbee.transform.position;
    }


    void Update()
    {
                transform.position = Vector3.MoveTowards(transform.position, frisbee.transform.position + offset, 20f);
                transform.LookAt(frisbee.transform);
              
    }

  


}
