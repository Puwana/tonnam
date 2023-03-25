using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using Random = UnityEngine.Random;


public enum UnitState
{
    Idle,
    Walk,
}

public class Staffq : MonoBehaviour
{
    private int _id;
    

    [SerializeField] private UnitState state;
    [SerializeField] private NavMeshAgent navAgent;

    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        CheckStop();
    }

    public void SetWalk(Vector3 dest)
    {
        state = UnitState.Walk;

        navAgent.SetDestination(dest);
        navAgent.isStopped = false;
    }

    private void CheckStop()
    {
        float dist = Vector3.Distance(transform.position, navAgent.destination);

        if (dist <= 3f)
        {
            state = UnitState.Idle;
            navAgent.isStopped = true;
        }
    }

    public NavMeshAgent NavAgent
    {
        get { return navAgent; }
        set { navAgent = value; }
    }

    public UnitState Stats
    {
        get { return state; }
        set { state = value; }
    }
    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    public GameObject[] charSkin;
    private int charSkinId;
    private string staffName;
    private int dailyWage;
    public int CharskinID
    {
        get { return charSkinId; }
        set { charSkinId = value; }
    }

    public void InitCharID(int id)
    {
        _id = id;
        charSkinId = Random.Range(0, charSkin.Length - 1);
        staffName = "xxxx";
        dailyWage = Random.Range(80, 125);
        
        
    }

    public void ChangeCharSkin()
    {
        for (int i = 0; i < charSkin.Length; i++)
        {
            if (i == charSkinId)
            {
                charSkin[i].SetActive(true);
            }
            else
            {
                charSkin[i].SetActive(false);
            }
        }
    }
}
