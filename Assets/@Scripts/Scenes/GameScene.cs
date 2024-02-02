using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    SpawningPool _spawningPool;
    GameManager _game;
    // PlayerController _player;
    UI_GameScene _ui;

    private void Awake()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();
        SceneType = Define.Scene.GameScene;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Time.timeScale = 1;
        _game = Managers.Game;

        _ui = Managers.UI.ShowSceneUI<UI_GameScene>();


    }


    public override void Clear()
    {
    }

}
