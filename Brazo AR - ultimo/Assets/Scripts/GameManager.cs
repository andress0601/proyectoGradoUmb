using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioClip m_correctSound = null;
    [SerializeField] private AudioClip m_incorrectSound = null;
    [SerializeField] private Color m_correctColor = Color.black;
    [SerializeField] private Color m_incorrectColor = Color.black;
    [SerializeField] private float m_waitTime = 0.0f;

    public static int Points { get; private set; }
    public Text pointsText;

    private QuizDB m_quizDB = null;
    private QuizUI m_quizUI = null;
    private AudioSource m_audioSource = null;

    private void Start()
    {
        m_quizDB = GameObject.FindObjectOfType<QuizDB>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI>();
        m_audioSource = GetComponent<AudioSource>();
        Points = 0;

        NextQuestion();
    }

    private void NextQuestion()
    {
        m_quizUI.Construtc(m_quizDB.GetRandom(), GiveAnswer);
    }

    private void GiveAnswer(OptionButton optionButton)
    {
        StartCoroutine( GiveAnswerRoutine(optionButton) );
    }

    private IEnumerator GiveAnswerRoutine(OptionButton optionButton)
    {
        if(m_audioSource.isPlaying)
            m_audioSource.Stop();

        m_audioSource.clip = optionButton.Option.correct ? m_correctSound : m_incorrectSound;
        m_audioSource.Play();

        optionButton.SetColor(optionButton.Option.correct ? m_correctColor : m_incorrectColor);

        if (optionButton.Option.correct)
            Points += 100;
        else
            Points -= 50;
        pointsText.text = "Puntos: " + Points.ToString();

        yield return new WaitForSeconds(m_waitTime);

        NextQuestion();
    }
}
