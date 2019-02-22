using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseOver : MonoBehaviour {
    //Get the GameObject’s mesh renderer to access the GameObject’s material and color
    MeshRenderer m_Renderer;

    public delegate void PlayAction();
    public static event PlayAction OnPlay;


    Material white;
    Material grey;
    Material vid;

    void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();
        //Fetch the original color of the GameObject
        //m_OriginalColor = m_Renderer.material.color;
        white = Resources.Load("white", typeof(Material)) as Material;
        grey = Resources.Load("grey", typeof(Material)) as Material;
        vid = Resources.Load("bluedop", typeof(Material)) as Material;
        m_Renderer.material = grey;

    }

    void OnMouseOver()
    {
        // Change the color of the GameObject to red when the mouse is over GameObject
        //m_Renderer.material = white;
        if (OnPlay != null)
        {
            OnPlay();
        }

        //print("emitting farts");

    }

    //void OnMouseExit()
    //{
    //    // Reset the color of the GameObject back to normal
    //    m_Renderer.material = grey;
    //}

}
