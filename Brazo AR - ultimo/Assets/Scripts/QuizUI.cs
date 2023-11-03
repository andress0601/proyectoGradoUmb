using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{
    [SerializeField] 
    private Text m_question = null;

    [SerializeField] 
    private List<OptionButton> m_buttonList = null;

    public void Construtc(Question q, Action<OptionButton> callback)
    {
        m_question.text = q.text;

        for(int n = 0; n < m_buttonList.Count ; n++)
        {
            m_buttonList[n].Constructc(q.options[n], callback);
        }
    }
}
