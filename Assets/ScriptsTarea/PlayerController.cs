using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Vector3 direction;
    [SerializeField] Transform transformBullet;
    [SerializeField] float bulletModifier;
    [SerializeField] Transform Spanw;
    Vector3 inputMouse;
    Vector2 currentPosition;
    GameObject newObjectBullet;

    void Update(){
        inputMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        direction = inputMouse-transform.position;
        //transform.right=new Vector3(direction.x,direction.y,direction.z-90);
        //transform.right=direction;
        Debug.DrawRay(transform.position,direction*10,Color.red);
        
        if(Input.GetMouseButtonDown(0)){
            newObjectBullet= Instantiate(bullet,Spanw.position,transformBullet.rotation);
            newObjectBullet.GetComponent<Rigidbody>().velocity = direction*bulletModifier;
        }
    }

}
