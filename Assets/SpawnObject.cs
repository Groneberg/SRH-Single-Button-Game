using System.Collections;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 spawnPoint;

    public float repeatInterval = 5f;
    public int maxRepeats = 10; // Gib die Anzahl der Wiederholungen an

    void SpawnNewObject()
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

        spawnPoint = new Vector3(x, y, 0);

        // Spawn the object at the current position
        Instantiate(objectToSpawn, spawnPoint, Quaternion.identity);
    }

    IEnumerator RepeatedAction()
    {
        int repeatCount = 0;

        while (repeatCount < maxRepeats)
        {
            int spawnNumber = Random.Range(1, 4);

            for (int i = 0; i < spawnNumber; i++)
            {
                SpawnNewObject();
            }

            yield return new WaitForSeconds(repeatInterval);

            repeatCount++;
            maxRepeats++;
        }

        Debug.Log("Wiederholung beendet!");
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RepeatedAction());
    }

    // Update is called once per frame
    void Update()
    {
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        SpawnNewObject();
    //    }

    }

}

