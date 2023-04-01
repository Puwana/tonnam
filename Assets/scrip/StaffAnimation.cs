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
        if (staff.State == UniteState.Idle)
        {
            DisableAll();
            anim.SetBool("isIdle",true);
        }
        else if (staff.State == UniteState.Walk)
        {
            DisableAll();
            anim.SetBool("isWalk",true);
        }
        else if (staff.State == UniteState.Harvest)
        {
            DisableAll();
            anim.SetBool("isHarvest",true);
        }
        else if (staff.State == UniteState.Sow)
        {
            DisableAll();
            anim.SetBool("isSow",true);
        }
        else if (staff.State == UniteState.Water)
        {
            DisableAll();
            anim.SetBool("isWater",true);
        }
        else if (staff.State == UniteState.Plow)
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
