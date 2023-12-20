using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using InstantGamesBridge;

public class Interface : MonoBehaviour
{
    public UnityEvent gameer, pause, gameOver, note, password;
    public static Interface rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    void Start()
    {
        Pause();
    }
    public void Pause()
    {
        CursorEvent(true);
        pause.Invoke();
        Time.timeScale = 0;
    }
    public void Game()
    {
        CursorEvent(false);
        gameer.Invoke();
        Time.timeScale = 1; 
    }

    public void GamOver()
    {
        gameOver.Invoke();
        Time.timeScale = 0;
        CursorEvent(true);
    }
    public void Note()
    {
        note.Invoke();
        Time.timeScale = 0;
        CursorEvent(true);
    }
    public void Password()
    {
        password.Invoke();
        Time.timeScale = 0;
        CursorEvent(true);
    }
    void CursorEvent(bool activ)
    {
        Muwer.rid.muve = Vector3.zero;
        Muwer.rid.rute = Vector2.zero;
        SubTitres.rid.Clear();
        if (activ)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        Cursor.visible = activ;
    }
}
