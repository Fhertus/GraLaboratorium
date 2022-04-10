using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class War2 : MonoBehaviour
{
    //public int prize = 1;
    public RectTransform winPanel;
    public string index = "Ers";
    // Start is called before the first frame update
    void Start()
    {
        winPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadNewLevel()
    {
        SceneManager.LoadScene(index);
    }
    private void OnTriggerStay(Collider enter)
    {
        if (enter.CompareTag("Player"))
        {
            enter.GetComponent<Sk>().health -= 1;
            if (enter.GetComponent<Sk>().health == 0)
            {
                winPanel.gameObject.SetActive(true);
            }
            //Destroy(gameObject);
        }
    }
}
