using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wes4 : MonoBehaviour
{
    public int prize = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1.5f);
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
