﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    private TextMesh textMesh;
    [SerializeField] private ParticleSystem sparksParticles;

    private List<string> textToDisplay = new List<string>{};

    [SerializeField] private float rotatingSpeed;
    private float timeToNextText;

    private int currentText;

    // Start is called before the first frame update
    void Start()
    {
        textMesh=GetComponent<TextMesh>();
        timeToNextText = 0.0f;
        currentText = 0;


        rotatingSpeed = 1.0f;

        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");

        textMesh.text = textToDisplay[0];

        sparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timeToNextText += Time.deltaTime;

        if (timeToNextText > rotatingSpeed)
        {
            timeToNextText = 0.0f;

            currentText++;
            if (currentText >= textToDisplay.Count)
            {
                currentText = 0;

            }
            textMesh.text = textToDisplay[currentText];
        }
    }

}