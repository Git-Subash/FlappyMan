using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManger : MonoBehaviour
{
    void Update()
    {
        
    }

    // this used in StartMainMenuPanel!!1

    public void StartButton()
    {
        // Start button click
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void LoadingScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("gameClosed..!!!!");
    }
    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }
}
