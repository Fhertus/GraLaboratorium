using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ToolButton : MonoBehaviour
{
    public Sk player;
    public Image healthbar;
    private float _cycleLength = 2;
   
    void Start()
    {
        //transform.DOMove(new Vector3((float)-1.781, (float)2.385, (float)-4.584), _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
            //transform.DOScale(new Vector3(3, 3, 3), 1f).SetLoops(-1, LoopType.Yoyo);

      
    }

    // Update is called once per frame
    void Update()
    {
        //healthbar.fillAmount = (float)player.health / player.maxHealth;
        
    }

    /*  if (player.health < 10)
        {
            transform.DOScale(new Vector3(3, 3, 3), 1f) _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        }
     }*/


}
