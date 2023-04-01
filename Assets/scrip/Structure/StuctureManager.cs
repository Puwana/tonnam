using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuctureManager : MonoBehaviour
{
    [SerializeField] private bool isConstructing;

    public GameObject curBuildingPrefab;

    public GameObject buildingParnent;

    [SerializeField] private Vector3 cursorPos;
    [SerializeField] private GameObject buildcursor;
    [SerializeField] private GameObject gridPlane;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cursorPos = Selector.instance.GetcuTilePosition();
        if (isConstructing)
        {
            buildcursor.transform.position = cursorPos;
            gridPlane.SetActive(true);
            
        }
    }

    public void beginNewBuildingPlacement(GameObject prefab)
    {
        isConstructing = true;
        curBuildingPrefab = prefab;
        
        buildcursor = Instantiate(curBuildingPrefab,cursorPos,Quaternion.identity);
        buildcursor.SetActive(true);
    }
}
