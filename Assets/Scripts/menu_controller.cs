using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_controller : MonoBehaviour {
   
    public GameObject credits;
    public int counter;
    public GameObject gameTitle;
    

   
	public void Play()
    {
        
        SceneManager.LoadScene("Main");
           
        
    }

    public void Credits()
    {

        counter++;
         if (counter %2 == 1)
        {
            credits.gameObject.SetActive(true);
            gameTitle.gameObject.SetActive(false);

        }
        else
        {
            credits.gameObject.SetActive(false);
            gameTitle.gameObject.SetActive(true);
        }
        
      
        

    }
}
