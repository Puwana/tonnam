using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staffq : MonoBehaviour
{
    private int _id;
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
        ChangeCharSkin();
        
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
