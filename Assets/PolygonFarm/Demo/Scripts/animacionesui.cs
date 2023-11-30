using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionesui : MonoBehaviour
{
    [SerializeField] private GameObject boton1;
    [SerializeField] private GameObject boton2;
    [SerializeField] private GameObject boton3;
    [SerializeField] private GameObject boton4;


    [SerializeField] private GameObject inicio;

    private void Start()
    {
        LeanTween.moveX(boton1.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1f).setEase(LeanTweenType.easeOutBounce);//setOnComplete(bajaralpha);
        LeanTween.moveX(boton2.GetComponent<RectTransform>(), 0, 1.5f).setDelay(1.5f).setEase(LeanTweenType.easeOutBounce);//setOnComplete(bajaralpha);
        LeanTween.moveX(boton3.GetComponent<RectTransform>(), 0, 1.5f).setDelay(2f).setEase(LeanTweenType.easeOutBounce);//setOnComplete(bajaralpha);
        LeanTween.moveX(boton4.GetComponent<RectTransform>(), 0, 1.5f).setDelay(2.5f).setEase(LeanTweenType.easeOutBounce);//setOnComplete(bajaralpha);
    }

    private void bajaralpha ()
    {

      //  LeanTween.alpha(inicio.GetComponent<RectTransform>(),0f,1f);
        //inicio.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
