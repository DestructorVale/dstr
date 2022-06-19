using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] int health = 10;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Autodestruction", health);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * -1 * Time.deltaTime);
    }

    private void Autodestruction()
    {
        Destroy(gameObject);
    }
}
