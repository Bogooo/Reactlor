using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ScriptScene1 : MonoBehaviour
{
    public Renderer ScreenR, LeftR, RightR;
    public Color ScreenC, LeftC, RightC;
    public float r1, g1, b1, r2, g2, b2;
    private int next;
    public bool midcheck = false;
    public int lv = 1;
    public float maxtime;
    public float starttime;
    public float timelv;
    float timeleft;
    public AudioSource efect;
    public GameObject achievement;
    public GameObject tutorial;
    public float scurt = 3f;
    private int ok = 0;
    private float timppp = 0,finn=2;
    private int check =0;
    public GameObject timesup,wrongbutton;
    private bool play = true;


    // Start is called before the first frame update
    void Start()
    {
        ScreenR = gameObject.GetComponent<Renderer>();
        LeftR = gameObject.GetComponent<Renderer>();
        RightR = gameObject.GetComponent<Renderer>();
        swichcolor();
        timeleft = starttime;
        LeftC = LeftR.material.color;
        RightC = RightR.material.color;
        efect = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("high") == 0)
        {
            tutorial.SetActive(true);
            timppp += Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {

            if (Input.GetMouseButtonDown(0))
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit) && Time.timeScale == 1)
                {

                    if (hit.transform.name == "ButtonMid")
                    {
                        midcheck = true;
                    }


                    if (hit.transform.name == "ButtonLeft")
                    {
                        if (next == 1 && midcheck == true)
                        {
                            timeleft = maxtime;
                            midcheck = false;
                            lv++;
                            swichcolor();
                            if (lv % 5 == 0 && maxtime > 0.6)
                            {
                                maxtime -= timelv;
                            }
                            efect.Play();
                        }
                        else
                        {
                            Sfarsit();
                            play = false;
                        }



                    }




                    if (hit.transform.name == "ButtonRight")
                    {
                        if (next == 2 && midcheck == true)
                        {
                            timeleft = maxtime;
                            midcheck = false;
                            lv++;
                            swichcolor();
                            if (lv % 10 == 0 && maxtime > 0.6)
                            {
                                maxtime -= timelv;
                            }
                            efect.Play();

                        }
                        else
                        {
                            Sfarsit();
                            play = false;
                        }



                    }


                }


            }

            if (PlayerPrefs.GetInt("high") < 200 && lv > 19 && ok == 0)
            {
                achievement.SetActive(true);
                ok = 1;
                scurt -= Time.deltaTime;
            }

            if (scurt < 3)
            {
                if (scurt > 0) scurt -= 1 * Time.deltaTime;
                else
                {
                    achievement.SetActive(false);
                    scurt = 3;
                }
            }

            if (timppp > 0)
            {
                if (timppp < 7) timppp += Time.deltaTime;
                else
                {
                    timppp = 0;
                    tutorial.SetActive(false);
                }
            }
            if (timeleft > 0)
            {
                timeleft -= Time.deltaTime;
            }
            else
            {
                check = 1;
                Sfarsit();
                play = false;
            }

        }
        else
        {
            if (finn > 0) finn -= Time.deltaTime;
            else EndGame();
        }
}


    void swichcolor()
    {
        next = Random.Range(1, 3);
        if (next == 1) ScreenC = new Color(r1, g1, b1, 1f);
        else ScreenC = new Color(r2, g2, b2, 1f);
        ScreenR.material.color = ScreenC;
    }

    void Sfarsit()
    {
        ScreenR.material.color = new Color(1, 0, 0, 1f);
        if (check == 1) timesup.SetActive(true);
        else wrongbutton.SetActive(true);
    }


    public void EndGame()
    {
        int score = (lv + 1) * 10 + Random.Range(0, 10);
        PlayerPrefs.SetInt("curent", score);
        int high = PlayerPrefs.GetInt("high");
        if (score > high)
        {
            string a = PlayerPrefs.GetString("name");
           StartCoroutine( Main.instance.web.Updatescore(a,score));
            PlayerPrefs.SetInt("high", score);
            SceneManager.LoadScene("HighScore");
        }
        else
            SceneManager.LoadScene("GameOver");
    }

}
