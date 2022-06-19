using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] objectToSpawned;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(objectToSpawned, new Vector3(0, -10, 0), Quaternion.identity);
        Invoke("primerspawn", 0);
        Invoke("segundospawn", 0);
        Invoke("tercerspawn", 0);
        Invoke("cuartospawn", 0);
        Invoke("quintospawn", 0);
        Invoke("sextospawn", 0);
        InvokeRepeating("spawn", 1.7f, 1.5f);
    }

    private void spawn()
    {
        Instantiate(objectToSpawned[Random.Range(0, 6)], new Vector3(0.46f, -7, 0), Quaternion.identity);
    }
    private void primerspawn()
    {
        Instantiate(objectToSpawned[Random.Range(0, 6)], new Vector3(0.46f, 0, 0), Quaternion.identity);
    }
    private void segundospawn()
    {
        Instantiate(objectToSpawned[Random.Range(0, 6)], new Vector3(0.46f, -1.5f, 0), Quaternion.identity);
    }
    private void tercerspawn()
    {
        Instantiate(objectToSpawned[Random.Range(0, 6)], new Vector3(0.46f, -3f, 0), Quaternion.identity);
    }
    private void cuartospawn()
    {
        Instantiate(objectToSpawned[Random.Range(0, 6)], new Vector3(0.46f, -4.5f, 0), Quaternion.identity);
    }
    private void quintospawn()
    {
        Instantiate(objectToSpawned[Random.Range(0, 6)], new Vector3(0.46f, -6f, 0), Quaternion.identity);
    }
    private void sextospawn()
    {
        Instantiate(objectToSpawned[Random.Range(0, 6)], new Vector3(0.46f, -7.5f, 0), Quaternion.identity);
    }
}
