using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudRandom : MonoBehaviour

{
    private Vector3 startPosition;

    public GameObject cloud;
    public GameObject cloudEndpoint;
    public ChangeAsset changeAsset;

    void ResetCloudToStart()
    {
        cloud.transform.position = startPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = cloud.transform.position;
        changeAsset.ChangeGameAssetRandom();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(cloud.transform.position, cloudEndpoint.transform.position) <= 0.1f)
        {
            Debug.Log("cloud");
            ResetCloudToStart();
            changeAsset.ChangeGameAssetRandom();
        }
    }
}
