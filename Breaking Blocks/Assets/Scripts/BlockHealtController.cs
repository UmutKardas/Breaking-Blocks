using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealtController : MonoBehaviour
{

    [SerializeField] private float blockHealt;


    private void OnCollisionEnter2D(Collision2D other)
    {
        blockHealt--;


        if (blockHealt <= 0)
        {
            gameObject.SetActive(false);
        }
    }

}
