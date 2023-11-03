using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class QuizDB : MonoBehaviour
{
    [SerializeField] private List<Question> m_questionList = null;
    [SerializeField] private List<Question> m_backup;

    private Over overScript;

    void Start()
    {
        overScript = FindObjectOfType<Over>();
    }

    private void Awake()
    {
        m_backup = m_questionList.ToList();
    }

    public Question GetRandom(bool remove = true)
    {
        // se pone el restante de la cantidad de preguntas total menos las que se hacen en el cuestionario
        if(m_questionList.Count == 5)
        {
            GameOver();
            RestoreBackup();
        }

         int index = Random.Range(0, m_questionList.Count);

         if(!remove)
            return m_questionList[index];

        Question q = m_questionList[index];
        m_questionList.RemoveAt(index);

        return q;
    }

    private void GameOver(){
        overScript.show();
    }

    private void RestoreBackup()
    {
        m_questionList = m_backup.ToList();
    }
}
