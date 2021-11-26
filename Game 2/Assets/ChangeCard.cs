using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCard : MonoBehaviour
{
    public static int correct, notcorrect;
    public Sprite sprite1, sprite2, sprite3, sprite4, sprite5, sprite6;
    private int soft = 1, hard = 0, val, count = 0;
    public GameObject Photo, Txt, Timer;
    public GameObject Coin1, Coin2;
    public float timeLeft = 5.0f;

    public void Start()
    {
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        count = 1;
        ChangeImg();
        timeLeft -= Time.deltaTime;
        Timer.GetComponent<Text>().text = (Mathf.Round(timeLeft * 10.0f) * 0.1f).ToString();
        if (timeLeft <= 0.0f)
        {
            notcorrect += 1;
            gameObject.SetActive(false);
            // Time.timeScale = 1;
            count += 1;
            timeLeft = 5.0f;
            Coin1.gameObject.SetActive(true);
            Coin2.gameObject.SetActive(true);
        }
    }
    public void Update()
    {
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);
        ChangeImg();
        timeLeft -= Time.deltaTime;
        Timer.GetComponent<Text>().text = (Mathf.Round(timeLeft * 10.0f) * 0.1f).ToString();
        if (timeLeft <= 0.0f)
        {
            notcorrect += 1;
            gameObject.SetActive(false);
            // Time.timeScale = 1;
            count += 1;
            timeLeft = 5.0f;
            Coin1.gameObject.SetActive(true);
            Coin2.gameObject.SetActive(true);
        }
    }
    public void ChangeImg()
    {
        // int rand=Random.Range(1,7);
        switch (count)
        {
            case 1:
            {
                Photo.GetComponent<Image>().overrideSprite = sprite1;
                Txt.GetComponent<Text>().text = "Cappello";
                val = 1;
                break;
            }
            case 2:
            {
                Photo.GetComponent<Image>().overrideSprite = sprite2;
                Txt.GetComponent<Text>().text = "Castagna";
                val = 1;
                break;
            }
            case 3:
            {
                Photo.GetComponent<Image>().overrideSprite = sprite3;
                Txt.GetComponent<Text>().text = "Ghiacciolo";
                val = 0;
                break;
            }
            case 4:
            {
                Photo.GetComponent<Image>().overrideSprite = sprite4;
                Txt.GetComponent<Text>().text = "Cavi";
                val = 1;
                break;
            }
            case 5:
            {
                Photo.GetComponent<Image>().overrideSprite = sprite5;
                Txt.GetComponent<Text>().text = "Sciarpa";
                val = 1;
                break;
            }
            case 6:
            {
                Photo.GetComponent<Image>().overrideSprite = sprite6;
                Txt.GetComponent<Text>().text = "Cinghiale";
                val = 0;
                break;
            }
        }
    }

    public void SoftSound()
    {
        if (val == soft)
            correct += 1;
        else 
            notcorrect += 1;
        gameObject.SetActive(false);
        // Time.timeScale = 1;
        count += 1;
        timeLeft = 5.0f;
        Coin1.gameObject.SetActive(true);
        Coin2.gameObject.SetActive(true);
    }
    public void HardSound()
    {
        if (val==hard)
            correct += 1;
        else 
            notcorrect += 1;
        gameObject.SetActive(false);
        // Time.timeScale = 1;
        count += 1;
        timeLeft = 5.0f;
        Coin1.gameObject.SetActive(true);
        Coin2.gameObject.SetActive(true);
    }
}
