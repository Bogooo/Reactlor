using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Nameinput : MonoBehaviour
{
    public TMP_InputField player;
    public TextMeshProUGUI text;
    public static int n;

    public void inputname()
    {
        if (player.text != "" && player.text.Length < 10)
        {
            string name = player.text.ToString();
            PlayerPrefs.SetString("name", name);
            StartCoroutine(Main.instance.web.Login(name));
            SceneManager.LoadScene("Menu");
        }
        else
            if (player.text == "") text.text = "Please enter a name";
               else text.text = "To many characters";

    }
   
}
