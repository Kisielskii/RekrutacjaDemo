using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{
    
   public void ResetButton()
   {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
   }
    

   public void ExitButton()
   {
        Application.Quit();
   }
}
