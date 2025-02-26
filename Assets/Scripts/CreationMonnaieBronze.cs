using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaieBronze : MonoBehaviour
{

    [SerializeField] GameObject _prefabOriginal;
    [SerializeField] Vector3  _positionCreation;
    void Start()
    {
        _positionCreation = transform.position;
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_prefabOriginal, _positionCreation, _rotation);
    }

   
}
