using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wes1 : MonoBehaviour
{
    public int prize = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10f, 0, 0);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == true)
        {
            other.GetComponent<Sk>().points += prize;
            Destroy(gameObject);
        }
    }
}
