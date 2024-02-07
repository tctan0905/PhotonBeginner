using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class PunNetWorking: MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.GameVersion = MasterManager.instance.GameSetting.GameVersion;
        //PhotonNetwork.NickName = MasterManager.instance.GameSetting.NickName;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        Debug.Log(PhotonNetwork.LocalPlayer.NickName);
    }

    public override void OnConnected()
    {
        Debug.Log("Connected");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Dissconnect: " + cause);
    }
}
