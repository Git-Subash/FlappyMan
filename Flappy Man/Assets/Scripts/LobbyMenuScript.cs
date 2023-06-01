using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public  class LobbyMenuScript : MonoBehaviour
{
    [SerializeField] private string VersionName = "0.1";


    [SerializeField]private GameObject LobbyPanel;
    [SerializeField] private GameObject CreatePanel;


    [SerializeField] private TMP_InputField CreateRoomNameInput;
    [SerializeField] private TMP_InputField JoinByRoomNameInput;

  
  private  void Awake()
  {
    PhotonNetwork.ConnectUsingSettings(VersionName);
    
  }
 private void OnConnectedToMaster()
 {
    PhotonNetwork.JoinLobby(TypedLobby.Default);
    Debug.Log("Connected");
 }

    [System.Obsolete]
    public void CreateGame()
 {
    PhotonNetwork.CreateRoom(CreateRoomNameInput.text, new RoomOptions(){maxPlayers = 4}, null);

 }

    [System.Obsolete]
    public void JoinGame()
 {
    RoomOptions roomOptions = new RoomOptions();
    roomOptions.maxPlayers = 4;
    Debug.Log("Not Excist");
 }

 public void OnJoinedRoom()
 {
    PhotonNetwork.LoadLevel("Room");
 }
    
}