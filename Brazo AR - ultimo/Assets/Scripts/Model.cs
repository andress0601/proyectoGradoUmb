using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class Model : MonoBehaviour
{
    private Animator animator;

    public float position;

    public Button buttonAR;

    public Button buttonAC;
    public Button buttonS;
    public Button buttonS2;
    public Button buttonCA;
    public Button buttonSM;
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        Button btn = buttonAR.GetComponent<Button>();
		btn.onClick.AddListener(adicionar);

        Button btn1 = buttonAC.GetComponent<Button>();
		btn1.onClick.AddListener(delegate { adicionar2(0); });
        Button btn2 = buttonS.GetComponent<Button>();
		btn2.onClick.AddListener(delegate { adicionar2(1); });
        Button btn3 = buttonS2.GetComponent<Button>();
		btn3.onClick.AddListener(delegate { adicionar2(2); });
        Button btn4 = buttonCA.GetComponent<Button>();
		btn4.onClick.AddListener(delegate { adicionar2(3); });
        Button btn5 = buttonSM.GetComponent<Button>();
		btn5.onClick.AddListener(delegate { adicionar2(4); });
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Position", position);
    }

    /*
    Abre y cierra
    Saludar
    Saludar 2
    Cuello hacia abajo
    Subir mano
    
    void adicionar(){
        if(position >= 1){
            position = 0;
        }else{
            position += 0.25f;
        }
    }
    */

    void adicionar2(int num){

        
        
        switch(num)
        {
            case 0: 
                position = 0;
                break;
            case 1: 
                position = 0.25f;    
                break;
            case 2: 
                position = 0.5f;
                break;
            case 3: 
                position = 0.75f;
                break;
            case 4: 
                position = 1;
                break;
            
            default:
                position = 0;
                break;
        }
    }


    void adicionar(){
    
        if(position >= 1){
            position = 0;
        }else{
            position += 0.25f;
        }

        
        
    }
}
