using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;


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
        transform.Rotate(1.5f, 0, 0);
       /* transform.DOMoveY(transform.position.y + 5.0f, 5.0f)
        .SetEase(Ease.InBack);
        GetComponent<Renderer>().material.DOFade(0, 5.0f)
         .OnComplete(() =>
         {
             Destroy(gameObject);
         });*/

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
