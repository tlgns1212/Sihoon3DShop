using System;
using System.Collections;
using System.Collections.Generic;
using Data;
using static Define;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using UnityEngine.Networking;




public class GameManager
{
    #region GameData

    #region Action
    public event Action OnResourcesChanged;
    #endregion

    public CameraController CameraController { get; set; }

    // #region Player
    // public PlayerController Player { get; set; }
    // #endregion

    #region Option
    public bool EffectSoundOn
    {
        get { return EffectSoundOn; }
        set { EffectSoundOn = value; }
    }

    public bool BGMOn
    {
        get { return BGMOn; }
        set
        {
            if (BGMOn == value)
                return;
            BGMOn = value;
            if (BGMOn == false)
            {
                Managers.Sound.Stop(Define.Sound.Bgm);
            }
            else
            {
                string name = "Bgm_Lobby";
                if (Managers.Scene.CurrentScene.SceneType == Define.Scene.GameScene)
                    name = "Bgm_Game";

                Managers.Sound.Play(Define.Sound.Bgm, name);
            }
        }
    }

    #endregion
    #endregion

    // public void Init()
    // {
    //     _path = Application.persistentDataPath + "/" + UserName + ".json";

    //     if (File.Exists(_path))
    //     {
    //         string fileStr = File.ReadAllText(_path);
    //         GameData data = JsonConvert.DeserializeObject<GameData>(fileStr);
    //         if (data != null)
    //             _gameData = data;
    //     }

    //     SaveGame();
    // }

    // #region Save&Load
    // public string _path = "";
    // public void SaveGame()
    // {
    //     _path = Application.persistentDataPath + "/" + UserName + ".json";
    //     string jsonStr = JsonConvert.SerializeObject(_gameData);
    //     File.WriteAllText(_path, jsonStr);
    //     Debug.Log($"Save Game Completed : {_path}");
    // }

    // public bool LoadGame()
    // {
    //     _path = Application.persistentDataPath + "/" + UserName + ".json";

    //     if (File.Exists(_path) == false)
    //     {
    //         Init();
    //         return false;
    //     }

    //     string fileStr = File.ReadAllText(_path);
    //     GameData data = JsonConvert.DeserializeObject<GameData>(fileStr);
    //     if (data != null)
    //         _gameData = data;

    //     Debug.Log($"Save Game Loaded : {_path}");
    //     return true;
    // }

    // public void ClearContinueData()
    // {
    //     // TODO Clear 후 저장
    // }

    // #endregion

}
