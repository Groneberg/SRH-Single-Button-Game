using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private bool random;
    [SerializeField] private float randomSpeed;



    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(speed, speed + 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (random)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, randomSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }
}
