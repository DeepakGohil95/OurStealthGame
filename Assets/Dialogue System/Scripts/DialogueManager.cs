using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	private Queue<Dialogue> sentences;
	
	public Text name_TextPanel, sentence_TextPanel;
	public GameObject dialogueBox;
	Animator anim;
	bool animating = false;

	void Start () {
		sentences = new Queue<Dialogue>();
		anim = dialogueBox.GetComponent<Animator>();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.X) && !animating)
		{
			DisplayNextSentence();
		}
	}

	public void StartDialogue(Dialogue[] dialogue)
	{
		sentences.Clear();
		anim.SetBool("IsOpen", true);
		
		foreach(Dialogue sentence in dialogue)
		{
			sentences.Enqueue(sentence);
		}
		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}
		Dialogue sentence = sentences.Dequeue();
		StopAllCoroutines();

		name_TextPanel.text = sentence.name;
		StartCoroutine(AnimateText(sentence.sentence));
	}

	public void EndDialogue()
	{
		anim.SetBool("IsOpen", false);
	}

	IEnumerator AnimateText(string sentence)
	{
		animating = true;
		sentence_TextPanel.text = "";
		/*foreach(char letter in sentence.ToCharArray())
		{
			sentence_TextPanel.text += letter;

			if(Input.GetKeyDown(KeyCode.X))
				{
					sentence_TextPanel.text = sentence;
					animating = false;
					StopAllCoroutines();
				}
			yield return null;
		} */
		int i = 0;
		while(i <sentence.Length)
		{
			sentence_TextPanel.text += sentence[i++];
			if(Input.GetKeyDown(KeyCode.X) && i>2)
			{
				sentence_TextPanel.text = sentence;
				i = sentence.Length;
			}
			yield return null;
		}
		animating = false;
	}
}
