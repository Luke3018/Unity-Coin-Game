using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewScoreScript : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;

    private void Awake()
    {
        entryContainer = transform.Find("Container");
        entryTemplate = entryContainer.Find("Template");

        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 30f;
        for (int i = 0; i < 7; i++)    {

            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);

            int rank = i + 1;
            string rankString;
            switch (rank) {
                default: rankString = rank + "th"; break;
                case 1: rankString = "1st"; break;
                case 2: rankString = "2nd"; break;
                case 3: rankString = "3rd"; break;
            }

            entryTransform.Find("Position").GetComponent<Text>().text = rankString;

            int score = Random.Range(0, 300);
            entryTransform.Find("Score").GetComponent<Text>().text = score.ToString();

            string name = "AAA";
            entryTransform.Find("Name").GetComponent<Text>().text = name;
        }
    }
}





