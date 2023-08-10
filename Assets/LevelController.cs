using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int level = 1;
    private Vector3 startPosition;
    [SerializeField] private int maxGrowthCounter;

    [SerializeField] CheckOnPlant checkOnPlant;

    public GameObject sun;
    public GameObject sunEndpoint;
    public ChangeAsset changeAsset;
    public UIManager uIManager;


    public void ChangeLevel()
    {
        level++;
    }

    void ResetSunToStart()
    {
        sun.transform.position = startPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = sun.transform.position;
        uIManager.SetDayCounter(level);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(sun.transform.position, sunEndpoint.transform.position) <= 0.1f)
        {
            ChangeLevel();
            ResetSunToStart();
            if (checkOnPlant.counter >= maxGrowthCounter)
            {
                changeAsset.ChangeGameAsset();
                checkOnPlant.counter = 0;
            }
            uIManager.SetDayCounter(level);
        }
        uIManager.SetGrowthCounter(checkOnPlant.counter);
    }
}
