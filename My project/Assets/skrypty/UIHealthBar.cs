using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIHealthBar : MonoBehaviour
{
    
    public Sk player;
    public Image healthbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = (float)player.health / player.maxHealth;
        //if (player.health < 10)
       // {
       //     transform.DOScale(new Vector3(3, 3, 3), 1f).SetLoops(-1, LoopType.Yoyo);
       // }
    }


}
//transform.DOScale(Vector3.one, 3f).SetEase(Ease.InBounce);