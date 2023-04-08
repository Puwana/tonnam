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

    private void Awake()
    {
        anim = GetComponent<Animator>();
        staff = GetComponent<Staff>();
    }

    private void Update()
    {
        if (staff.State == UnitState.Idle)
        {
            DisableAll();
            anim.SetBool("isIdle",true);
        }
        else if (staff.State == UnitState.Walk)
        {
            DisableAll();
            anim.SetBool("isWalk",true);
        }
        else if (staff.State == UnitState.Harvest)
        {
            DisableAll();
            anim.SetBool("isHarvest",true);
        }
        else if (staff.State == UnitState.Sow)
        {
            DisableAll();
            anim.SetBool("isSow",true);
        }
        else if (staff.State == UnitState.Water)
        {
            DisableAll();
            anim.SetBool("isWater",true);
        }
        else if (staff.State == UnitState.Plow)
        {
            DisableAll();
            anim.SetBool("isPlow",true);
        }

    }

    private void DisableAll()
    {
        anim.SetBool("isIdle",false);
        anim.SetBool("isWalk",false);
        anim.SetBool("isPlow",false);
        anim.SetBool("isWater",false);
        anim.SetBool("isHarvest",false);
        anim.SetBool("isSow",false);
    }
}
