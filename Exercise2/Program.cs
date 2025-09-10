﻿using System;
using Cards2;

// loop while there's more input
string? input = Console.ReadLine();
while (input != null)
{

    // Add your code between this comment
    // and the comment below. You can of
    // course add more space between the
    // comments as needed

    // declare a deck variables and create a deck object
    // DON'T SHUFFLE THE DECK

    Deck deck = new Deck();

    // deal 2 cards each to 4 players (deal properly, dealing
    // the first card to each player before dealing the
    // second card to each player)

    List<Card> player1Cards = new List<Card>();
    List<Card> player2Cards = new List<Card>();
    List<Card> player3Cards = new List<Card>();
    List<Card> player4Cards = new List<Card>();

    for (int i = 0; i < 2; i++)
    {
        player1Cards.Add(deck.TakeTopCard());
        player2Cards.Add(deck.TakeTopCard());
        player3Cards.Add(deck.TakeTopCard());
        player4Cards.Add(deck.TakeTopCard());
    }

    // deal 1 more card to players 2 and 3

    player2Cards.Add(deck.TakeTopCard());
    player3Cards.Add(deck.TakeTopCard());


    // flip all the cards over
    foreach (Card c in player1Cards) { c.FlipOver(); }
    foreach (Card c in player2Cards) { c.FlipOver(); }
    foreach (Card c in player3Cards) { c.FlipOver(); }
    foreach (Card c in player4Cards) { c.FlipOver(); }


    // print the cards for player 1
    Console.WriteLine("Player 1: ");
    foreach (Card c in player1Cards) { Console.WriteLine($"{c.Rank} of {c.Suit}"); }

    // print the cards for player 2
    Console.WriteLine("Player 2: ");
    foreach (Card c in player2Cards) { Console.WriteLine($"{c.Rank} of {c.Suit}"); }


    // print the cards for player 3
    Console.WriteLine("Player 3: ");
    foreach (Card c in player3Cards) { Console.WriteLine($"{c.Rank} of {c.Suit}"); }


    // print the cards for player 4
    Console.WriteLine("Player 4: ");
    foreach (Card c in player4Cards) { Console.WriteLine($"{c.Rank} of {c.Suit}"); }

    input = Console.ReadLine();
}