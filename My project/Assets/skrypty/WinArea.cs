using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
//using 

public class WinArea : MonoBehaviour
{
    public RectTransform winPanel;
    public string index = "Ers";


    //public ImageConversion progressBar = null;

    // public float timeToLoad = 3f;
    // private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        winPanel.gameObject.SetActive(false);
    }




    // Update is called once per frame
    void Update()
    {
      // timer += Time.deltaTime;
      // progressBar.fillAmout = timer / timeToLoad;
    }

    public void LoadNewLevel()
    {
        SceneManager.LoadScene(index);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<Sk>().points == 11)
            {
                winPanel.gameObject.SetActive(true);
            }
            
            // timer = 0;
            // progressBar.enabled = true;
        }
    }

   
    }
