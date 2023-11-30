using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botones : MonoBehaviour
{
    public Button startbutton;
    public Button[] otherbuttons;
    public Button  boton2;
    public Button boton3;
    public Button boton4;




    void Start()
    {
        startbutton.onClick.AddListener(StartGame);
        //boton2.onClick.AddListener(Buttonj2Click);
        // boton3.onClick.AddListener(Buttonj3Click);
        // boton4.onClick.AddListener(Buttonj4Click);

        startbutton.onClick.AddListener(() => botonenlaanimacion(startbutton));
        boton2.onClick.AddListener(() => botonenlaanimacion(boton2));
        boton3.onClick.AddListener(() => botonenlaanimacion(boton3));
        boton4.onClick.AddListener(() => botonenlaanimacion(boton4));

    }

    void StartGame()
    {
        LeanTween.alphaCanvas(startbutton.GetComponent<CanvasGroup>(),0f,1f).setOnComplete(() =>startbutton.gameObject.SetActive(false));
        foreach (Button button in otherbuttons)
        {
            LeanTween.alphaCanvas(button.GetComponent<CanvasGroup>(), 0f,1f).setOnComplete(() => button.gameObject.SetActive(false));
        }
        //LeanTween.move(startbutton.GetComponent<RectTransform>(),new Vector3(0,1000,0),1f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(()=>startbutton.gameObject.SetActive(false));
        Debug.Log("Iniciando el juego");
        //startbutton.gameObject.SetActive(true);

    }
    void botonenlaanimacion(Button button)
    {
        LeanTween.scale(button.gameObject, Vector3.one * 1.2f, 0.2f).setEase(LeanTweenType.easeOutQuad).setLoopPingPong(1);
    }
}
