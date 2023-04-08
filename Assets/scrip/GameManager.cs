using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;

 

    public static GameManager instance;

 

    public GameObject spawnPosition;
    public GameObject rallyPosition;

 

    //resource
    public int money;
    public int wheat;
    public int melon;
    public int corn;
    public int apple;
    public int sellAmount;
 

    public int dailyWage;

 

    public List<Structure> structures = new List<Structure>();
    public List<Staff> staff = new List<Staff>();

 

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        money = 20000;
        wheat = 0;
        GenerateCandidate();
        UI.instance.UpdateHeaderPanel();
    }

 

    // Update is called once per frame
    void Update()
    {
        

    }

 

    private void GenerateCandidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, spawnPosition.transform.position, Quaternion.identity, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();

 

            s.InitCharID(i);
            s.ChangeCharSkin();
            HireStaff(s);

 

            s.SetToWalk(rallyPosition.transform.position);
            //Debug.Log("Go to " + rallyPosition.transform.position);
        }
    }

 

    public void HireStaff(Staff st)
    {
        money -= st.dailyWage;
        staff.Add(st);
    }

 

    public void SendStaff(GameObject target)
    {
        Farm f = target.GetComponent<Farm>();
        
        if (f.WorkingStaff.Count >= f.MaxStaffNum)
            return;

 

        int n = 0;

 

        for (int i = 0; i < staff.Count; i++)
        {
            Staff s = staff[i].GetComponent<Staff>();
            if (staff[i].WorkPlace == null)
            {
                staff[i].WorkPlace = target;
                staff[i].SetToWalk(target.transform.position);
                f.AddStaffToFarm(s);
                n++;
            }

 

            if (n >= f.MaxStaffNum)
                break;
        }        
    }

    public void SellAll()
    {
        money += sellAmount;

        wheat = 0;
        melon = 0;
        corn = 0;
        apple = 0;
    }

    public void SellUpdate()
    {
        int wheatSell = Convert.ToInt32(wheat * 1.2f);
        int melonSell = Convert.ToInt32(melon * 1.5f);
        int cornSell = Convert.ToInt32(corn * 1.7f);
        int appleSell = apple * 2;

        sellAmount = wheatSell + melonSell + cornSell + appleSell;
        UI.instance.UpdateHeaderPanel();
    }
}