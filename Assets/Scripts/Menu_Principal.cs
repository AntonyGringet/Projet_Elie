using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Principal : MonoBehaviour
{
    public string levelToLoad = "SampleScene";

    public void Jouer()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quitter()
    {
        Application.Quit();
    }

}
