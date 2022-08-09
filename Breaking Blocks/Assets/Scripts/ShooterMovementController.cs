using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovementController : MonoBehaviour
{

    [SerializeField] private float limitX;


    void Update()
    {
        SetShooterPositionX();
    }



    private void SetShooterPositionX()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, transform.position.y, transform.position.y));

        mousePosition.x = Mathf.Clamp(mousePosition.x, -limitX, limitX);

        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
    }
}
