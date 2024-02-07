using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    private string _gameVersion = "0.0.1";
    public string GameVersion { get => _gameVersion; }

    private string _nickName = "User_";
    public string NickName
    {
        get
        {
            int random_id = Random.Range(1, 9999);
            return _nickName + random_id.ToString();
        }
    }
}
