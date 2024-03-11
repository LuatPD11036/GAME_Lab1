using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource _do, _re, _mi, _fa, _son, _la, _si;
    SpriteRenderer _red, _green, _blue, _yellow, _black, _brown, _orange;
    void Start()
    {
        Debug.Log("Start");
        _do = GameObject.FindWithTag("Do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
        //-------------------------------------------------------------
        _red = GameObject.FindWithTag("Do").GetComponent<SpriteRenderer>();
        _green = GameObject.FindWithTag("Re").GetComponent<SpriteRenderer>();
        _blue = GameObject.FindWithTag("mi").GetComponent<SpriteRenderer>();
        _yellow = GameObject.FindWithTag("fa").GetComponent<SpriteRenderer>();
        _black = GameObject.FindWithTag("son").GetComponent<SpriteRenderer>();
        _brown = GameObject.FindWithTag("la").GetComponent<SpriteRenderer>();
        _orange = GameObject.FindWithTag("si").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Press A");
            _do.Play();
            _red.color = Color.red;
        }
        else
        {
            _red.color = Color.white;
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Press A");
            _red.color = Color.red;
        }
        else
        {
            _red.color = Color.white;
        }
        //------------------------------------
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            Debug.Log("Press S");
            _re.Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Press S");
            _green.color = Color.green;
        }
        else
        {
            _green.color = Color.white;
        }
        //------------------------------------
            if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Press D");
            _mi.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Press D");
            _blue.color = Color.blue;
        }
        else
        {
            _blue.color = Color.white;
        }
        //-------------------------------------
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Press F");
            _fa.Play();
        }
        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Press F");
            _yellow.color = Color.yellow;
        }
        else
        {
            _yellow.color = Color.white;
        }
        //-------------------------------------
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Press G");
            _son.Play();
        }
        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("Press G");
            _black.color = Color.black;
        }
        else
        {
            _black.color = Color.white;
        }
        //----------------------------------------
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Press H");
            _la.Play();
        }
        if (Input.GetKey(KeyCode.H))
        {
            Debug.Log("Press H");
            _brown.color = Color.grey;
        }
        else
        {
            _brown.color = Color.white;
        }
        //------------------------------------------
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Press J");
            _si.Play();
        }
        if (Input.GetKey(KeyCode.J))
        {
            Debug.Log("Press J");
            _orange.color = Color.grey;
        }
        else
        {
            _orange.color = Color.white;
        }
        //--------------------------------------------

    }
}
