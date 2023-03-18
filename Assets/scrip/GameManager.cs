using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject staffPrefab;
    public GameObject staffParent;

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
            Staffq s = staffObj.GetComponent<Staffq>();
            
            s.InitCharID(i);
        }
    }
}
