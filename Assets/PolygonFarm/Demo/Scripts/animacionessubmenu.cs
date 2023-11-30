using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionessubmenu : MonoBehaviour
{

    [SerializeField] private GameObject boton1;
    [SerializeField] private GameObject boton2;
    [SerializeField] private GameObject boton3;
    

    private void Start()
    {
        LeanTween.moveY(boton1.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1f).setEase(LeanTweenType.easeOutBounce);//setOnComplete(bajaralpha);
        LeanTween.moveY(boton2.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeOutBounce);//setOnComplete(bajaralpha);
        LeanTween.moveY(boton3.GetComponent<RectTransform>(), 0, 1.5f).setDelay(2f).setEase(LeanTweenType.easeOutBounce);//setOnComplete(bajaralpha);
        
    }
}
