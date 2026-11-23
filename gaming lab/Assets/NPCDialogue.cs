using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NPC dialogue trigger (attached to the NPC with a Collider2D, IsTrigger = true)
public class NPCDialogue : MonoBehaviour
{
    public DialogueManager dialogueManager; //a variable that stores the Dialogue script that is attached to the Dialogue Manager gameObject
    //This can be used as a more elegant alternative to FindObjectOfType<Dialogue>()

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") //if the player is the one that triggers the collider, then
        {
            string[] dialogue = { "Red Riding Hood: ..Um, hello? What exactly are you?",
                                  "Bobby: I'm Bobby! I'm just a guy. Do you know a way outta here?",
                                  "Red Riding Hood: Shoot, I was about to ask the same thing.",
                                  "You came from the surface, right? I've been trying to leave here since forever..",
                                  "Folks down here say that the way out is by finding something called..",
                                  "Uhm..'The Eternal Dahlia', I think - or something like that.",
                                  "Bobby: Oh? Well..my eyesight's absolutely terrible in this darkness.",
                                  "You wanna come along? Two pairs of eyes better than one and all that?",
                                  "Red Riding Hood: Guess so.. OK, um, lead the way.",}; //specify the dialogue between the player and the character

            dialogueManager.SetSentences(dialogue); //set the sentences array in the Dialogue script to above array
            dialogueManager.StartCoroutine(dialogueManager.TypeDialogue()); //start the coroutine of TypeDialogue(), which in turn starts the dialogue

            Destroy(GetComponent<BoxCollider2D>(), 5f); //destroys the NPC's triggered box collider so
                                                        //the player doesn't accidentally re-trigger the conversation
        }
    }
}
