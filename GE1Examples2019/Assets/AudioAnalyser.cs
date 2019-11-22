using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAnalyser : MonoBehaviour
{
    public int framesize = 512;
    public static float[] samples;
    public static float[] spectrum;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        samples = new float[framesize];
        spectrum = new float[framesize];

        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audio.GetOutputData(samples, 0);
        audio.GetSpectrumData(spectrum, 0, FFTWindow.Blackman);
    }
}
