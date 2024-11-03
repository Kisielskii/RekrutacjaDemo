using UnityEngine;

public class MenuManagerScript : MonoBehaviour
{
    public GameObject canvas;
    public static bool isOpen = false;
    void Update()
    {
          if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isOpen)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

   

    void Pause()
    {
        canvas.SetActive(true);
        isOpen = true;
    }
    
    void Resume()
    {
        canvas.SetActive(false);
        isOpen = false;
    }
}
