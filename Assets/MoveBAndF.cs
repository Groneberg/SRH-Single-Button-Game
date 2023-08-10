using UnityEngine;

public class MoveBAndF : MonoBehaviour
{
    [SerializeField] private float endPoint;
    [SerializeField] private float speed;
    Vector3 startPoint;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newXPosition = startPoint.x + endPoint * Mathf.Sin(Time.time * speed);
        transform.position = new Vector3(newXPosition, startPoint.y, startPoint.z);
    }
}
