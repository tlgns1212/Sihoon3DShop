using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_GameScene : UI_Scene
{
    #region Enum
    enum GameObjects
    {
    }

    enum Buttons
    {
    }

    enum Toggles
    {
    }

    enum Texts
    {
    }

    #endregion




    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        Application.targetFrameRate = 60;


        Refresh();

        return true;
    }

    void Refresh()
    {

    }


    void Awake()
    {
        Init();
    }

    void Start()
    {

    }
}
