using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] Color32 shitColor= new Color32(1,1,1,1);

    SpriteRenderer driverSprite;

    void Start() {
        driverSprite = GetComponent<SpriteRenderer>();
    }

    void Update() {
    float steerAmount = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
    float driveAmount = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
    transform.Rotate(0,0,-steerAmount);    
    transform.Translate(0,driveAmount,0);


    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Shit"){
            driverSprite.color = shitColor;
        }

    }

    

    
}
