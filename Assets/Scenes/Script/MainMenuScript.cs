using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MainMenuScript : MonoBehaviour
{
    public TextMeshProUGUI namee;
    public GameObject image;


    private void Start()
    {
        namee.text = PlayerPrefs.GetString("name");
        if (PlayerPrefs.GetInt("high") > 200) image.SetActive(true);
    }

    // Start is called before the first frame update
    public void Playgame()
    {
        SceneManager.LoadScene("Gameplay");

    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
