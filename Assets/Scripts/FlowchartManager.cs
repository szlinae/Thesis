using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowchartManager : MonoBehaviour
{
    public GameObject[] flowcharts;
    public GameObject thisFlow;
    private int x = 0;


    public void ChangeFlow()
    {   
        thisFlow.SetActive(false);
        x++;
        thisFlow = flowcharts[x];
        thisFlow.SetActive(true);
    }
}
