using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinArea : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }




    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        string index = "Ers";

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);
        }
    }
}