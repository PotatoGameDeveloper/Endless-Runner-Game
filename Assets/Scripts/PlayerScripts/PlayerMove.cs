using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float horizontalMoveSpeed = 4;
    static public bool canMove = false;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundry.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * horizontalMoveSpeed);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundry.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * horizontalMoveSpeed * -1);
                }
            }
        }
    }
}
