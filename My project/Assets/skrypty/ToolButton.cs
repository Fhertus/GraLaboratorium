using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ToolButton : MonoBehaviour
{

    public Button button;

    public void HandleMouseEnter()
    {
        if (button.IsInteractable())
        {
            transform.DOScale(Vector3.zero, 3f).SetEase(Ease.InBounce);
        }
    }
    //private Transform[] _shapes;
    // Start is called before the first frame update
    void Start()
    {
        //foreach (Transform shape in _shapes) 
        // {
       
       // transform.DOScale(Vector3.zero, 3f).SetEase(Ease.InBounce);
       // }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
  
    

}
