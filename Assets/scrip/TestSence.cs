using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSence : MonoBehaviour
{
    public Staff staff;

    public void ButtonIdle()
    {
        staff.State = UniteState.Idle;
    }

    public void ButtonWalk()
    {
        staff.State = UniteState.Walk;
    }

    public void ButtonPlow()
    {
        staff.State = UniteState.Plow;
    }

    public void ButtonWater()
    {
        staff.State = UniteState.Water;
    }

    public void ButtonSow()
    {
        staff.State = UniteState.Sow;
    }

    public void ButtonHarvest()
    {
        staff.State = UniteState.Harvest;
    }
}
    
     

