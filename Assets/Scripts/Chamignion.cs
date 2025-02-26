using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chamignion : MonoBehaviour
{
    
    [SerializeField] GameObject _drapeauPos;
    [SerializeField] GameObject _boitePos;
    [SerializeField] GameObject _champignionPos;
    [SerializeField] Vector3 _drapeau;
    [SerializeField] Vector3 _boite;

    
    void Start()
    {
        _drapeau = _drapeauPostransform.position;
        _boite = _boitePos.position;

        float positionAleatoire Random.value;
        Quaternion _rotation = Quaternion.Euler(0f, 0f, 0f);

        if (positionAleatoire < 0.5f){
            Instantiate(_champignionPos, _drapeau, _rotation);
        }

        else{
            Instantiate(_champignionPos, _boite, _rotation);
        }
    }
}
