using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Wes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") == true && Input.GetKeyDown(KeyCode.E))
        {
            other.GetComponent<Sk>().points += 1;
            Destroy(gameObject);
        }
    }
}
