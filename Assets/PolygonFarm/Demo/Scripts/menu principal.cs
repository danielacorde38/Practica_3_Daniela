using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class menuprincipal : MonoBehaviour
{
    public GameObject menu;
    public Button start;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;

    bool menuvisible = false;
    float posicion;

    private void Start()
    {
        start.onClick.AddListener(menuprcl);
        button1.onClick.AddListener(()=> botonenlaanimacion(button1));
        button2.onClick.AddListener(() => botonenlaanimacion(button2));
        button3.onClick.AddListener(() => botonenlaanimacion(button3));
        button4.onClick.AddListener(() => botonenlaanimacion(button4));

        posicion = menu.transform.localPosition.y;

        menu.SetActive(false);
    }
    void menuprcl ()
    {
        menuvisible = !menuvisible;

        

        if(menuvisible) 
            LeanTween.moveLocalY(menu, posicion, 0.5f).setEase(LeanTweenType.easeOutQuad);
        else
            LeanTween.moveLocalY(menu, posicion + 200f, 0.5f).setEase(LeanTweenType.easeInQuad);

        if (menuvisible) { menu.SetActive(true); }


    }


    void botonenlaanimacion (Button button)
    {
        LeanTween.scale(button.gameObject,Vector3.one *1.2f,0.2f).setEase (LeanTweenType.easeOutQuad).setLoopPingPong(1);
    }

}

