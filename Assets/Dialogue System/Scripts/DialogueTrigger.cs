using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue[] dialogue;

	DialogueManager dialogueManager;
	int currentLine, maxLines;

	void OnEnable()
	{
		dialogueManager = GameObject.FindObjectOfType<DialogueManager>();
	}

	void OnTriggerEnter()
	{
		currentLine = 0;
		maxLines = dialogue.Length;
		TriggerDialogue();	
		GetComponent<BoxCollider>().enabled = false;	
	}

	public void TriggerDialogue()
	{
		dialogueManager.StartDialogue(dialogue);
	}
}
