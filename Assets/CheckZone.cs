using System.Collections.Generic;
using UnityEngine;

public class CheckZone : MonoBehaviour
{
    [SerializeField] private List<TriggerFlee> objectInZone = new List<TriggerFlee>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerFlee triggerFleeComponent = collision.gameObject.GetComponent<TriggerFlee>();

        if (triggerFleeComponent == null)
        {
            return;
        }
        objectInZone.Add(triggerFleeComponent);    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TriggerFlee triggerFleeComponent = collision.gameObject.GetComponent<TriggerFlee>();

        if (triggerFleeComponent == null)
        {
            return;
        }

        if (!objectInZone.Contains(triggerFleeComponent))
        {
            return;
        }
        
        objectInZone.Remove(triggerFleeComponent);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in objectInZone)
            {
                item.SetScared();
            }
        }
    }
}
