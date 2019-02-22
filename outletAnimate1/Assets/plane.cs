using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class plane : MonoBehaviour
{
    Material white;
    Material grey;
    VideoClip animate;
    VideoPlayer videoPlayer;
    GameObject vidPlane;

    void OnEnable()
    {
        onMouseOver.OnPlay += Play;
    }

    void Play()
    {
        videoPlayer.Play();
    }


    void Start()
    {
        white = Resources.Load("white", typeof(Material)) as Material;
        grey = Resources.Load("animate", typeof(Material)) as Material;

        vidPlane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        Renderer planeRend = vidPlane.GetComponent<Renderer>();
        planeRend.material = white;
        videoPlayer = vidPlane.AddComponent<VideoPlayer>();
        videoPlayer.playOnAwake = false;
        videoPlayer.playbackSpeed = 2.5f;
        //videoPlayer = vidPlane.GetComponent<VideoPlayer>();
        animate = Resources.Load("bluedop", typeof(VideoClip)) as VideoClip;
        videoPlayer.clip = animate;


        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, -0.4f, 0);
        Renderer cubeRend = cube.GetComponent<Renderer>();
        cubeRend.material = grey;
        cube.AddComponent<onMouseOver>();


        //GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //sphere.transform.position = new Vector3(0, 1.5f, 0);

        //GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        //capsule.transform.position = new Vector3(2, 1, 0);

        //GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        //cylinder.transform.position = new Vector3(-2, 1, 0);
    }
}