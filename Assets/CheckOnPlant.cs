using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOnPlant : MonoBehaviour
{
    public int counter = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerCounter triggerCounterComponent = collision.gameObject.GetComponent<TriggerCounter>();
        if (triggerCounterComponent == null)
        {
            return;
        }

        counter += triggerCounterComponent.countValue;
        Destroy(collision.gameObject, 0.2f);
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
