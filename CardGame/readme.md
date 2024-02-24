# About

This is a program I came across online from someone who was learning C#. It is a single file, all run within the Main() function and has two static functions.

The code has multiple problems:

1. The logic is often wrong and will result in an infinite loop.
2. The logic does not draw cards for the dealer, or update the dealer total.
3. The rules seem like a violation of Blackjack, but we will address those later.
4. The cards are not all dealt from the same deck.
5. Ace is dealt with as a 1, but in Blackjack it can be 1 or 11 - but we will address that later.
6. The code is tightly coupled to the console.
7. The dealer's total is less than the player's total, nothing happens.
8. Poorly named variables

## Assumed Rules

1. Both player and dealer are dealt two cards each from a standard 52 card deck.
2. The player has the first turn. Without knowing the dealers total they must choose to HIT or CALL
3. If they HIT, then they are dealt the next 3 cards in the deck:
    1. If the total of their five cards is greater than 21, they have bust and the game is over and the dealer wins
    2. If the total of their five cards is exactly 21, they have won and no more cards are dealt
    3. If the total of their five cards is less than 21, then they have won and no more cards are dealt
4. If the player chooses to CALL instead, then no more cards are dealt to the player and the turn passes to the dealer:
    1. If the dealer's two card are greater than the player's two cards, then the dealer wins, and no more cards are dealt
    2. If the dealer's cards total less than or the same as the player's, then they must draw 3 more cards:
        1. If the dealer's 5 cards total greater than 21, then they have bust and the player is declared the winner and the game is over
        2. If the dealer's 5 cards total more than the player's cards, then the dealer has won and the game is over
        3. If the dealer's 5 cards total less than the player's cards, then the player has won and the game is over
        4. If the dealer's 5 cards total the same as they player then the game is a push (a draw) and the game is over
5. An Ace is worth only 1. Every other card (2-10) is worth its face value, with picture cards (J, Q, K) being worth 10.

## Task

Rewrite the code using classes and methods. Only the `Main()` function should contain any calls to the console for printing.

