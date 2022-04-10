using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WEB : MonoBehaviour
{

    public  string scores = "";

    public IEnumerator GetDate()
    {
         using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/Unity-Reaclor/GetDate.php"))
        {
            // Request and wait for the desired page.
            yield return www.SendWebRequest();

            if (www.isNetworkError)
            {
                Debug.Log( www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

    public IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/Unity-Reaclor/GetUsers.php"))
        {
            // Request and wait for the desired page.
            yield return www.SendWebRequest();

            if (www.isNetworkError)
            {
                Debug.Log(www.error);
            }
            else
            {
               scores = www.downloadHandler.text;
                //Debug.Log(www.downloadHandler.text);
                PlayerPrefs.SetString("text", scores);
            }
        }
    }


    public IEnumerator Login(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginuser", username);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Unity-Reaclor/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                int n = int.Parse(www.downloadHandler.text);
                PlayerPrefs.SetInt("high", n);

                Debug.Log(PlayerPrefs.GetString("name"));
                Debug.Log(PlayerPrefs.GetInt("high"));


            }
        }
    }

    public IEnumerator Updatescore(string username,int score)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginuser", username);
        form.AddField("userscore", score);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Unity-Reaclor/Update.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }

}
