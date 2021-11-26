using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    public float increment;
    public Vector2 targetPos;
    private float collectedCoins = 0;
    public float speed;
    public List<float> possiblePosition;
    private Vector2 newPos;
    private Vector2 newPos2;
    public GameObject Canvas1, Canvas2, Canvas3, CanvasMenu;

    public void awake()
    {
        targetPos = transform.position;
    }
    public void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        if (collectedCoins >= 5)
        {
            if (Random.value > 0.85)
            {
                Canvas3.gameObject.SetActive(true);
            }
            else
            {
                Canvas2.gameObject.SetActive(true);
            }
            //It would be used to stop the background and coins from scrolling, but the timer doesn't work
            // Time.timeScale = 0; 
            collectedCoins = 0;
        }
    }

    public void MoveLeft()
    {
        if (transform.position.x > -2)
        {
            targetPos = new Vector2(transform.position.x - increment, transform.position.y);
        }
    }
    public void MoveRight()
    {
        if (transform.position.x < 2)
        {
            targetPos = new Vector2(transform.position.x + increment, transform.position.y);
        }
    }

    public void Pause()
    {
        Canvas1.gameObject.SetActive(false);
        Canvas2.gameObject.SetActive(false);
        CanvasMenu.gameObject.SetActive(true);
    }
    public void Resume()
    {
        Canvas1.gameObject.SetActive(true);
        Canvas2.gameObject.SetActive(false);
        CanvasMenu.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        int rand = Random.Range(0, possiblePosition.Count);
        int rand2 = Random.Range(0, possiblePosition.Count);
        newPos.x = possiblePosition.ElementAt(rand);
        newPos.y = 6f;
        newPos2.x = possiblePosition.ElementAt(rand2);
        newPos2.y = 6f;
        
        if (other.gameObject.name == "Coin")
        {
            collectedCoins+=1;
            other.gameObject.transform.position = newPos;
        }
        if (other.gameObject.name == "Coin2")
        {
            collectedCoins+=1;
            other.gameObject.transform.position = newPos2;
        }
    }
}
