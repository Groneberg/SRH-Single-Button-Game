using UnityEngine;

public class TriggerFlee : MonoBehaviour
{
    [SerializeField] private bool isScared;
    [SerializeField] private float speed;
    private Vector3 fleePoint;
    public void SetScared() 
    {
        GetFleePoint();
        isScared = true;
    }

    public bool CheckScared()
    {
        return isScared;
    }

    void GetFleePoint()
    {
        int x, y;
        x = Random.Range(-10, 11);
        if ((x >= -11 && x <= -9) || (x > 9 && x < 11))
        {
            y = Random.Range(-1, 5);
        }
        else
        {
            y = Random.Range(5, 7);
        }

        fleePoint = new Vector3(x, y, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isScared)
        {
            transform.position = Vector3.MoveTowards(transform.position, fleePoint, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, fleePoint) <= 0.1f)
            {
                Destroy(gameObject);
            }
        }
    }
}
