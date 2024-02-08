using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private string[] dialogueSentences;
    [SerializeField] private TextMeshProUGUI sentencesText;
    [SerializeField] private int indexOfSentences;
    public bool nextLevel=false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine("DisplayDialogue");
            nextLevel = true;
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.V)&&nextLevel)
        {
            StartCoroutine("NextLevel");
        }
    }
    IEnumerator DisplayDialogue()
    {
        foreach (char letter in dialogueSentences[indexOfSentences].ToCharArray())
        {
            sentencesText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }
    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(0f);
        int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
        int nextBuildIndex = currentSceneIndex + 1;
        if (nextBuildIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextBuildIndex = 0;
        }
        
        SceneManager.LoadScene(nextBuildIndex);
    }
}
