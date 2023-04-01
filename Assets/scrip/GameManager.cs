using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;

    public GameObject sapmPos;
    public GameObject rallryPos;

    public int money;
    public int staff;
    public int wheat;
    public int melon;
    public int corn;
    public int apple;
        
    public static GameManager instance;
    private void Start()
    {
       GenerateCanidate();
    }

    private void Update()
    {
        
    }

    private void GenerateCanidate()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject staffObj = Instantiate(staffPrefab, staffParent.transform);
            Staff s = staffObj.GetComponent<Staff>();
            
            s.InitCharID(i);
            s.ChangeCharSkin();
            
            s.SetWalk(rallryPos.transform.position);
        }
    }
}
