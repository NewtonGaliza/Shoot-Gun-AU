using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJetPackController : MonoBehaviour
{
    [SerializeField] float _speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        
    }

    void MoveCharacter(Vector2 _direction)
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
