using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public InputField username;
    public Toggle isCustom;
    private string custom;

    public void StartGame()
    {
        PlayerPrefs.SetString("username", username.text);
        if (isCustom.isOn)
            custom = "yes";
        else
            custom = "no";
        PlayerPrefs.SetString("isCustom", custom);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
