using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public void Loadp()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void ResetHighScore()
    {
        //Todo: Resetes Highscore
    }
    public void Donate()
    {
        Application.OpenURL("https://www.gov.pl/web/ncbr-en/how-to-make-a-donation-for-ukraine");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("MainGame");
    }
}
