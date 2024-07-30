using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public TextMeshProUGUI infoText;
    
   
    public Button startButton;
    public Button quitButton;
   
    public TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(()=> {
            if (!string.IsNullOrEmpty(nameInput.text))
            {
                DataManager.Instance.tempPlayer = nameInput.text;
                SceneManager.LoadScene("main");
            }
          
            

        });


         DataManager.Instance.LoadData();

        if (string.IsNullOrEmpty(DataManager.Instance.namePlayer))
        {
            infoText.gameObject.SetActive(false);
            
        }
        else
        {
            infoText.gameObject.SetActive(true);
            UpdateBestScoreText();
        }
         

    }

    void UpdateBestScoreText()
    {
        infoText.text = $"Best Score: {DataManager.Instance.namePlayer}-{DataManager.Instance.score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
