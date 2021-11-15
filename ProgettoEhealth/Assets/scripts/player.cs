using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float increment;

    public Vector2 targetPos;

    public float speed;

    private void Awake()
    // Start is called before the first frame update
    //void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
    public void MoveRight()
    {
        targetPos += new Vector2(increment, 0);
    }

    public void MoveLeft()
    {
        targetPos -= new Vector2(increment,0);
    }
}
