using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class StaffAnimation : MonoBehaviour
{
    private Animator amin;
    private Staffq staffq;

    void Awake()
    {
        amin = GetComponent<Animator>();
        staffq = GetComponent<Staffq>();
    }


    void Update()
    {
        if (staffq.Stats == UnitState.Idle)
        {
            DisableAll();
            amin.SetBool("isIdle", true);
        }
    }

    private void DisableAll()
    {
        amin.SetBool("isIdle", false);
        amin.SetBool("isWalk",false);
        
        
    }
}
