using Cards2;

Deck d3deck = new Deck();
d3deck.Shuffle();
Card firstCard = d3deck.TakeTopCard();
Console.WriteLine($"The Top card is a {firstCard.Rank} of {firstCard.Suit} \n");

Console.WriteLine("Shuffled Deck: ");
d3deck.Print();