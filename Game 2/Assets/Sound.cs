using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;
    public static int notcorrect; // and correct
    private int soft = 1, hard = 0, val;
    public GameObject Timer;
    public GameObject Coin1, Coin2;
    public float timeLeft = 5.0f;
    public GameObject Canvas2 = GameObject.Find("Canvas2");

    public void Start()
    {
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);

        ChangeSound();
            
        timeLeft -= Time.deltaTime;
        Timer.GetComponent<Text>().text = (Mathf.Round(timeLeft * 10.0f) * 0.1f).ToString();
        
        if (timeLeft <= 0.0f)
        {
            notcorrect += 1;
            gameObject.SetActive(false);
            timeLeft = 5.0f;
            Coin1.gameObject.SetActive(true);
            Coin2.gameObject.SetActive(true);
        }
    }
    public void Update()
    {
        Coin1.gameObject.SetActive(false);
        Coin2.gameObject.SetActive(false);

        ChangeSound();
        
        timeLeft -= Time.deltaTime;
        Timer.GetComponent<Text>().text = (Mathf.Round(timeLeft * 10.0f) * 0.1f).ToString();
        if (timeLeft <= 0.0f)
        {
            notcorrect += 1;
            gameObject.SetActive(false);
            timeLeft = 5.0f;
            Coin1.gameObject.SetActive(true);
            Coin2.gameObject.SetActive(true);
        }
    }
    
    public void ChangeSound()
    {
        int rand = Random.Range(0, audioClipArray.Length);

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClipArray[rand];
        audioSource.PlayOneShot(audioSource.clip);

        switch (rand)
        {
            case 1:
            {
                val = 1;
                break;
            }
            case 2:
            {
                val = 1;
                break;
            }
            case 3:
            {
                val = 0;
                break;
            }
            case 4:
            {
                val = 1;
                break;
            }
            case 5:
            {
                val = 1;
                break;
            }
            case 6:
            {
                val = 0;
                break;
            }
        }
    }
    public void SoftSound()
    {
        
        if (val == soft)
            Canvas2.GetComponent.<ChangeCard>().correct += 1;
        else 
            notcorrect += 1;
        gameObject.SetActive(false);
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
        timeLeft = 5.0f;
        Coin1.gameObject.SetActive(true);
        Coin2.gameObject.SetActive(true);
    }
}
