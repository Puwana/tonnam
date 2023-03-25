using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class StaffAnimation : MonoBehaviour
{
    private Animator anim;
    private Staff staff;

    void Awake()
    {
        anim = GetComponent<Animator>();
        staff = GetComponent<Staff>();
    }


    void Update()
    {
        if (staff.State == UnitState.Idle)
        {
            DisableAll();
            anim.SetBool("isIdle", true);
        }
        else if (staff.State == UnitState.Walk)
        {
            DisableAll();
            anim.SetBool("isWalk", true);
        }
    }

    private void DisableAll()
    {
        anim.SetBool("isIdle", false);
        anim.SetBool("isWalk",false);
        
        
    }
}
