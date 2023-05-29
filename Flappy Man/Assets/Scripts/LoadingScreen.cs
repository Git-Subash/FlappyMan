using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadingScreen : MonoBehaviour
{
    public Animator Transition;
    public float TransitionTime;

    public void SinglePlayerButton()
    {
      StartCoroutine(Loadscene(SceneManager.GetActiveScene().buildIndex + 1));
      Debug.Log("ButtonClicked");

    }
    public void MultiPlayerButton()
    {
      StartCoroutine(Loadscene(SceneManager.GetActiveScene().buildIndex + 2));
      Debug.Log("ButtonClicked");
    }
     IEnumerator Loadscene(int Loadgame)
     {
      //Play Animation
      Transition.SetTrigger("Start");
      // wait
      yield return new WaitForSeconds(TransitionTime);
      //play scene
      SceneManager.LoadScene(Loadgame);

     }
}
