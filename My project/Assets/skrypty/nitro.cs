using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nitro : MonoBehaviour
{
    public ParticleSystem nitroLeft;
    public ParticleSystem nitroRight;

    //public GameObject pauseMenuUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            fire(); 
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            notfire();
        }
    }
    void fire()
    {
        nitroLeft.Play();
        nitroRight.Play();
    }
    void notfire()
    {
        nitroLeft.Stop();
        nitroRight.Stop();
    }
}
