using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_movement : MonoBehaviour
{
   public float increment;

    public Vector2 targetPos;

    public float speed;

    private void Awake()
    {
        targetPos = transform.position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        targetPos += new Vector2(increment,0);
		//Debug.Log(message: "buttondx");
		//transform.position=new Vector3(transform.position.x + increment,y:transform.position.y, z:0);
    }

    public void MoveLeft()
    {
        targetPos -= new Vector2(increment,0);
    }
}
