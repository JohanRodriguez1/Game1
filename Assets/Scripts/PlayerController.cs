using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region public variables

    [SerializeField] private float _velocity = 20.0f;
    [SerializeField] private float _turn = 25.0f;

    #endregion

    #region private variables

    private float _controlPlayerTurn;
    private float _controlPlayerMove;

    #endregion

    #region unity callbacks

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _controlPlayerTurn = Input.GetAxis("Horizontal");
        _controlPlayerMove = Input.GetAxis("Vertical");

        //move van in axes
        transform.Translate(Vector3.forward * Time.deltaTime * _velocity * _controlPlayerMove);
        transform.Translate(Vector3.right * Time.deltaTime * _turn * _controlPlayerTurn);
        transform.Rotate(Vector3.up * Time.deltaTime * _turn * _controlPlayerTurn);
    }

    #endregion

    #region public methods

    #endregion

    #region private methods

    #endregion
}
