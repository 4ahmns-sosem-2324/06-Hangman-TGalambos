using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Manager : MonoBehaviour
{
    /*
    - Zielwörter als StringArray definieren
    - Array Random abarbeiten 
    - wenn man auf dem korrekten Buchstaben auf der Tastatur klickt wird das jeweilige UI-Element "ge-SetActive-t"
    - wenn man auf ein falschen Buchstaben drückt dann wird ein UI-Elemenet vom Hangman aktiviert 
    - wenn alle korrekten Buchstaben aktiviert sind bekommt man einen Punkt und man kommt zum nächsten Wort
    - wenn alle Hangman Elemente aktiviert sind bekommt man einen Punkt abgezogen
    - wenn die Punktezahl unter null ist hat man Verloren und es wird ein Lose-Screen aktiviert
    - wenn (StringArray.Length) Punktezahl erreicht wurde hat man Gewonnen und es wird ein Win-Screen aktiviert

    ChatGPT:
    // 1. Define necessary variables:
//    - chosenWord: The word chosen randomly from the word bank.
//    - guessedLetters: A list to store the letters guessed by the player.
//    - incorrectGuesses: An integer to track the number of incorrect guesses made by the player.
//    - maxIncorrectGuesses: A constant representing the maximum number of incorrect guesses allowed.
//    - wordBank: An array of strings containing words to choose from.
//    - UI elements: References to UI Text components for displaying the hangman word and feedback messages, and an InputField for player input.

// 2. StartNewGame() method:
//    - Choose a random word from the word bank and assign it to chosenWord.
//    - Initialize guessedLetters list.
//    - Display the hangman word on the UI.
//    - Reset feedback text on the UI.
//    - Clear the input field for player guesses.

// 3. UpdateHangmanWordDisplay() method:
//    - Display the hangman word with correctly guessed letters shown and other letters as blanks or underscores on the UI.

// 4. GuessLetter() method:
//    - Accepts the player's guess entered in the input field as input.
//    - Check if the guess is a valid single character:
//      - If not, display an error message and return.
//    - Convert the guessed letter to lowercase.
//    - Check if the letter has already been guessed:
//      - If yes, display a message indicating that the letter has already been guessed and return.
//    - Add the guessed letter to the guessedLetters list.
//    - Update the display of the hangman word on the UI.
//    - Check if the guessed letter is correct:
//      - If yes, continue the game.
//      - If no, increment the incorrectGuesses count.
//        - Check if the player has reached the maximum number of incorrect guesses allowed:
//          - If yes, end the game and display a message indicating the player has lost.
//    - Check for win condition:
//      - If all letters in the chosen word have been guessed correctly, end the game and display a message indicating the player has won.
//    - Clear the input field for the next guess.

// 5. IsWordGuessed() method:
//    - Check if all letters in the chosen word have been guessed correctly.
//    - If yes, return true indicating the word has been guessed.
//    - If no, return false indicating the word has not been guessed completely.

    */


    public WortListen wortListen;
    public Text chosenWordText;
    public InputField inputField;
    public char[] guessedCharacter = new char[26];
    public GameObject[] hangmanParts; 
    private int current;

    string chosenWord; 

    public static string GetRandomWord(string[] wordArray)
    {
        // Check if the array is not empty
        if (wordArray.Length > 0)
        {
            // Generate a random index within the bounds of the array
            int randomIndex = Random.Range(0, wordArray.Length);
            // Return the word at the randomly selected index
            return wordArray[randomIndex];
        }
        else
        {
            // If the array is empty, return an empty string
            return "";
        }
    }


    void Start()
    {
        chosenWord = GetRandomWord(wortListen.words);

        Debug.Log(chosenWord);
        Debug.Log(GetRandomWord(wortListen.words10));
        Debug.Log(GetRandomWord(wortListen.words100));

        chosenWordText.text = chosenWord;

        for (int i = 0; i < hangmanParts.Length; i++)
        {
            hangmanParts[i].SetActive(false);
        }
    }


    public void GuessLetter()
    {
        
    }

    public void Hangman()
    {
        hangmanParts[current].SetActive(true);
        current++;

        if (current == hangmanParts.Length)
        {
            Debug.Log("L");
        }
    }
}
