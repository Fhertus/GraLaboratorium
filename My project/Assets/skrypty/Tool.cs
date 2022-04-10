using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tool : MonoBehaviour
{
    //[SerializeField] private Transform _innerShape, _outerShape;
    //[SerializeField]
    private float _cycleLength = 2;
    //(-1.95, 2.385, -4.584)
    void Start()
    {
        transform.DOMove(new Vector3((float)-1.781, (float)2.385, (float)-4.584), _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
