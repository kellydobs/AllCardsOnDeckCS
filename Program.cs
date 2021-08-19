﻿using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Card Shuffler!");

var suits = new List<string>() {"Clubs" , "Diamonds" , "Hearts" , "Spades"};
var ranks = new List<string>() {"Ace", "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9" , "10" , "Jack" , "Queen" , "King" };
var deck = new List<string>() {};


foreach  (string rank in ranks) {
  foreach (string suit in suits) {
    deck.Insert(0, rank + " of " + suit);
  }
}

foreach (string card in deck){
  Console.WriteLine(card);
  }

Console.WriteLine("There are " + deck.Count + " cards in the deck!");


var randomNumberGenerator = new Random();
int leftIndex;
string leftCard;
string rightCard;

for (int rightIndex = deck.Count - 1; rightIndex > 0; rightIndex--)
{

leftIndex = randomNumberGenerator.Next(rightIndex + 1);
  //Console.Write(randomNumber + " , ");

//save cards in variables so we don't lost them
leftCard = deck[leftIndex];
rightCard = deck[rightIndex];

//swap

deck[leftIndex] = rightCard;
deck[rightIndex] = leftCard;

// deck[leftIndex] = deck[rightIndex];
// deck[rightIndex] = deck[leftIndex];

}
var stackDeck = new Stack<string>(deck);


 foreach (string card in deck)
 {
   Console.WriteLine(card);
//stackDeck.Push(card);

 }

var playerHand = new List<string>() {};
var opponentHand = new List<string>() {};

//deal 2 cards for each hand

playerHand.Insert(0, stackDeck.Pop());
playerHand.Insert(0, stackDeck.Pop());

opponentHand.Insert(0, stackDeck.Pop());
opponentHand.Insert(0, stackDeck.Pop());

Console.WriteLine("stackDeck has " + stackDeck.Count + " cards left!");



    }
  }
}
