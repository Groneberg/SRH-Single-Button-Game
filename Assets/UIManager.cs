using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dayCounter;
    [SerializeField] private TMP_Text growthCounter;

    public void SetDayCounter(int day)
    {
        dayCounter.text = "Day:  " + day;
    } 

    public void SetGrowthCounter(int growth)
    {
        growthCounter.text = "Growth:  " + growth;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
