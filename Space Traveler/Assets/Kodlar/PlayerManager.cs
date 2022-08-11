using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody my_body;
    public float _tullanmaGucu;
    private int _zDeyeri=2;

    void Start()
    {
        my_body = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -90f, 0);
            PlayerMovementSol();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90f, 0);
            PlayerMovementSag();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            PlayerMovement();
        }

    }
    private void PlayerMovement()
    {
          my_body.velocity = new Vector3(0, 1*_tullanmaGucu*Time.fixedDeltaTime, 1.5f);



         /* transform.DOMoveY(4, .5f).OnComplete(() => {

              _zDeyeri += 2;
              transform.DOMoveZ(_zDeyeri, .5f).OnComplete(() =>
              {

                 // _zDeyeri += 2;

              });
          });      

        */

      //  transform.DOJump(new Vector3(0, 3, _zDeyeri), 3, 1, 1).OnComplete(() => { _zDeyeri += 2; });

    }

    private void PlayerMovementSag()
    {
         my_body.velocity = new Vector3(1.5f, 1 * _tullanmaGucu * Time.fixedDeltaTime, 0);
      /*  transform.DOMoveY( 3, .5f).OnComplete(() => {
            transform.DOMoveX(+2, .5f);
        });
      */
    }
    private void PlayerMovementSol()
    {
         my_body.velocity = new Vector3(-1.5f, 1 * _tullanmaGucu * Time.fixedDeltaTime, 0);

     /*   transform.DOMoveY(3, .5f).OnComplete(() => {
            transform.DOMoveX(-2, .5f);
        });

        */
    }



}
