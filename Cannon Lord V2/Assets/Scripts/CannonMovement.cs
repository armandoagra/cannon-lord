using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{

    public float speed; // Velocidade que o canhão muda o ângulo
    public float angleLimit; // Limite do ângulo
    float angle; // Ângulo atual

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = Mathf.Sin(Time.time * speed); // O ângulo é determinado pelo tempo do jogo e pela velocidade escolhida. É baseada no seno desse valor.
        transform.eulerAngles = Vector3.forward * angle * angleLimit; // Alteração do ângulo do canhão de acordo com o limite\
    }
}
