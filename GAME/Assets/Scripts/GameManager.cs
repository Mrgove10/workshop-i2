using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [ReadOnly]
    public float Quantiq = 0;
    [ReadOnly]
    public float Security = 0;
    [ReadOnly]
    public float Budget = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void launchEffect(AreaTypes type)
    {
        switch (type)
        {
            case AreaTypes.OnlinePayement:
                break;
            case AreaTypes.HrDepartment:
                break;
            case AreaTypes.ItDepartment:
                break;
            case AreaTypes.SalesDepartment:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
    }
}

