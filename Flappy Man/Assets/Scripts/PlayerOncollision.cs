using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOncollision : MonoBehaviour
{
         public bool MoneyCollected;
         public bool GameOver;
    
     private AudioSource PlayerAudio;
     public AudioClip CoinSound;
     public AudioClip BombSound;



     private ParticleSystem PlayerAnim;
     public ParticleSystem CoinParticle;
     public ParticleSystem BombParticle;
     
    



 void Start()
  {
    PlayerAudio = GetComponent<AudioSource>();
    PlayerAnim = GetComponent<ParticleSystem>();
    

  
}
   private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Money"))
        {
            PlayerAudio.PlayOneShot(CoinSound, 1.0f);
            CoinParticle.Play(); 
            Destroy(other.gameObject);
            MoneyCollected = true;
            Debug.Log("GameObjectDeleted");
            ScoreManger.instance.AddPoints();
                       
        }
      
       if(other.gameObject.CompareTag("Bomb"))
        {
           
            PlayerAudio.PlayOneShot(BombSound, 1.0f);
            BombParticle.Play();
            Destroy(other.gameObject);
            GameOver = true;
            Debug.Log("GameOver");
           
            
        }
      
            
        }
    
    }
