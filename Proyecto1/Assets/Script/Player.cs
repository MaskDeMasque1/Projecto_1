using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 5f;

    public int hp = 3;

    private string namePlayer = "Ky";

    public int attack = 3;

    public Vector3 dir;
    
    void Start()
    {
       Debug.Log(hp);
       Debug.Log("EJECUTANDO EL START");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("EJECUTANDO EL UPDATE");
        transform.position = transform.position + Vector3.forward *Time.deltaTime;
    }

    void Damage(int value)
    {    
        hp = hp - value;

    }

    private void movePlayer(Vector3 direccion)
    {

    }

    void Heal(int value)
    {
        hp = hp + value;
    
    }
}
