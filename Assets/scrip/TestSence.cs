using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSence : MonoBehaviour
{
    public Staff staff;

    public void ButtonIdle()
    {
        staff.State = UnitState.Idle;
    }

    public void ButtonWalk()
    {
        staff.State = UnitState.Walk;
    }

    public void ButtonPlow()
    {
        staff.State = UnitState.Plow;
    }

    public void ButtonWater()
    {
        staff.State = UnitState.Water;
    }

    public void ButtonSow()
    {
        staff.State = UnitState.Sow;
    }

    public void ButtonHarvest()
    {
        staff.State = UnitState.Harvest;
    }
}
    
     

