using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool GameHasEnded = false ;
   public GameObject completeLevelUI;

   public void CompleteLevel()
   {
   	Debug.Log("complete level");
   	completeLevelUI.SetActive(true);
   }
   public void EndGame()
   {
   		if (GameHasEnded==false)
   		{
   			GameHasEnded=true;
   			Debug.Log("Game Over");
   			Invoke ("Restart",4f);


   		}
   }
   void Restart()
   {
   	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}

