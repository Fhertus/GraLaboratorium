using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tool3 : MonoBehaviour
{
    //[SerializeField] private Transform _innerShape, _outerShape;
    //[SerializeField]
    private float _cycleLength = 2;
    //(-1.95, 2.385, -4.584)
    void Start()
    {
        transform.DOMove(new Vector3((float)-1.77, (float)2.385, (float)-2.01), _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {

    }
}