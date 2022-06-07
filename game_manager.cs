using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_manager : MonoBehaviour
{

    private void Start()
    {
        GameObject gameobject = new GameObject("hook", typeof(SpriteRenderer));
       // gameobject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pfphook;
    }

    bool gamehasended = false;
    public GameObject completelevelUI;
    public GameObject loserUI;
    public void completeLevel()
    {
        completelevelUI.SetActive(true);
        PauseGame();
    }
    public void loselevel()
    {
        loserUI.SetActive(true);

    }

    // Start is called before the first frame update
    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("Game Over");

            PauseGame();
            loselevel();
        }

    }
    
    public void PauseGame()
    {
        if (gamehasended == true)
        {
            Time.timeScale = 0;
        }
    }
    
    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}

