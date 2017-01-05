namespace Solitaire.Models
{
    public class Card
    {
        // A class that describes a playing card with a suit (1-4, C/D/H/S) and a Rank (1=A - 13=K), as well as an image
        public int ID { get; set; }
        public int card { get; set; }
        public int rank { get; set; }
        public int suit { get; set; }
        public string rankName { get; set; }
        public string suitName { get; set; }
        public string cardImage { get; set; }

        // Constructor with no parameters
        public Card()
        {

        }

        // Constructor which accepts a parameter as a card identifier
        public Card(int newCard)
        {
            card = newCard;
            // Assign values to card properties based on the card number (1-52, Ace of Clubs thru King of Spades)
            switch (newCard)
            {
                case 1:
                    rank = 1;
                    suit = 1;
                    rankName = "Ace";
                    suitName = "Clubs";
                    cardImage = "1-1.png";
                    break;
                case 2:
                    rank = 2;
                    suit = 1;
                    rankName = "Two";
                    suitName = "Clubs";
                    cardImage = "1-2.png";
                    break;
                case 3:
                    rank = 3;
                    suit = 1;
                    rankName = "Three";
                    suitName = "Clubs";
                    cardImage = "1-3.png";
                    break;
                case 4:
                    rank = 4;
                    suit = 1;
                    rankName = "Four";
                    suitName = "Clubs";
                    cardImage = "1-4.png";
                    break;
                case 5:
                    rank = 5;
                    suit = 1;
                    rankName = "Five";
                    suitName = "Clubs";
                    cardImage = "1-5.png";
                    break;
                case 6:
                    rank = 6;
                    suit = 1;
                    rankName = "Six";
                    suitName = "Clubs";
                    cardImage = "1-6.png";
                    break;
                case 7:
                    rank = 7;
                    suit = 1;
                    rankName = "Seven";
                    suitName = "Clubs";
                    cardImage = "1-7.png";
                    break;
                case 8:
                    rank = 8;
                    suit = 1;
                    rankName = "Eight";
                    suitName = "Clubs";
                    cardImage = "1-8.png";
                    break;
                case 9:
                    rank = 9;
                    suit = 1;
                    rankName = "Nine";
                    suitName = "Clubs";
                    cardImage = "1-9.png";
                    break;
                case 10:
                    rank = 10;
                    suit = 1;
                    rankName = "Ten";
                    suitName = "Clubs";
                    cardImage = "1-10.png";
                    break;
                case 11:
                    rank = 11;
                    suit = 1;
                    rankName = "Jack";
                    suitName = "Clubs";
                    cardImage = "1-11.png";
                    break;
                case 12:
                    rank = 12;
                    suit = 1;
                    rankName = "Queen";
                    suitName = "Clubs";
                    cardImage = "1-12.png";
                    break;
                case 13:
                    rank = 13;
                    suit = 1;
                    rankName = "King";
                    suitName = "Clubs";
                    cardImage = "1-13.png";
                    break;
                case 14:
                    rank = 1;
                    suit = 2;
                    rankName = "Ace";
                    suitName = "Diamonds";
                    cardImage = "2-1.png";
                    break;
                case 15:
                    rank = 2;
                    suit = 2;
                    rankName = "Two";
                    suitName = "Diamonds";
                    cardImage = "2-2.png";
                    break;
                case 16:
                    rank = 3;
                    suit = 2;
                    rankName = "Three";
                    suitName = "Diamonds";
                    cardImage = "2-3.png";
                    break;
                case 17:
                    rank = 4;
                    suit = 2;
                    rankName = "Four";
                    suitName = "Diamonds";
                    cardImage = "2-4.png";
                    break;
                case 18:
                    rank = 5;
                    suit = 2;
                    rankName = "Five";
                    suitName = "Diamonds";
                    cardImage = "2-5.png";
                    break;
                case 19:
                    rank = 6;
                    suit = 2;
                    rankName = "Six";
                    suitName = "Diamonds";
                    cardImage = "2-6.png";
                    break;
                case 20:
                    rank = 7;
                    suit = 2;
                    rankName = "Seven";
                    suitName = "Diamonds";
                    cardImage = "2-7.png";
                    break;
                case 21:
                    rank = 8;
                    suit = 2;
                    rankName = "Eight";
                    suitName = "Diamonds";
                    cardImage = "2-8.png";
                    break;
                case 22:
                    rank = 9;
                    suit = 2;
                    rankName = "Nine";
                    suitName = "Diamonds";
                    cardImage = "2-9.png";
                    break;
                case 23:
                    rank = 10;
                    suit = 2;
                    rankName = "Ten";
                    suitName = "Diamonds";
                    cardImage = "2-10.png";
                    break;
                case 24:
                    rank = 11;
                    suit = 2;
                    rankName = "Jack";
                    suitName = "Diamonds";
                    cardImage = "2-11.png";
                    break;
                case 25:
                    rank = 12;
                    suit = 2;
                    rankName = "Queen";
                    suitName = "Diamonds";
                    cardImage = "2-12.png";
                    break;
                case 26:
                    rank = 13;
                    suit = 2;
                    rankName = "King";
                    suitName = "Diamonds";
                    cardImage = "2-13.png";
                    break;
                case 27:
                    rank = 1;
                    suit = 3;
                    rankName = "Ace";
                    suitName = "Hearts";
                    cardImage = "3-1.png";
                    break;
                case 28:
                    rank = 2;
                    suit = 1;
                    rankName = "Two";
                    suitName = "Hearts";
                    cardImage = "3-2.png";
                    break;
                case 29:
                    rank = 3;
                    suit = 1;
                    rankName = "Three";
                    suitName = "Hearts";
                    cardImage = "3-3.png";
                    break;
                case 30:
                    rank = 4;
                    suit = 1;
                    rankName = "Four";
                    suitName = "Hearts";
                    cardImage = "3-4.png";
                    break;
                case 31:
                    rank = 5;
                    suit = 1;
                    rankName = "Five";
                    suitName = "Hearts";
                    cardImage = "3-5.png";
                    break;
                case 32:
                    rank = 6;
                    suit = 1;
                    rankName = "Six";
                    suitName = "Hearts";
                    cardImage = "3-6.png";
                    break;
                case 33:
                    rank = 7;
                    suit = 1;
                    rankName = "Seven";
                    suitName = "Hearts";
                    cardImage = "3-7.png";
                    break;
                case 34:
                    rank = 8;
                    suit = 1;
                    rankName = "Eight";
                    suitName = "Hearts";
                    cardImage = "3-8.png";
                    break;
                case 35:
                    rank = 9;
                    suit = 1;
                    rankName = "Nine";
                    suitName = "Hearts";
                    cardImage = "3-9.png";
                    break;
                case 36:
                    rank = 10;
                    suit = 1;
                    rankName = "Ten";
                    suitName = "Hearts";
                    cardImage = "3-10.png";
                    break;
                case 37:
                    rank = 11;
                    suit = 1;
                    rankName = "Jack";
                    suitName = "Hearts";
                    cardImage = "3-11.png";
                    break;
                case 38:
                    rank = 12;
                    suit = 1;
                    rankName = "Queen";
                    suitName = "Hearts";
                    cardImage = "3-12.png";
                    break;
                case 39:
                    rank = 13;
                    suit = 1;
                    rankName = "King";
                    suitName = "Hearts";
                    cardImage = "3-13.png";
                    break;
                case 40:
                    rank = 1;
                    suit = 2;
                    rankName = "Ace";
                    suitName = "Spades";
                    cardImage = "4-1.png";
                    break;
                case 41:
                    rank = 2;
                    suit = 2;
                    rankName = "Two";
                    suitName = "Spades";
                    cardImage = "4-2.png";
                    break;
                case 42:
                    rank = 3;
                    suit = 2;
                    rankName = "Three";
                    suitName = "Spades";
                    cardImage = "4-3.png";
                    break;
                case 43:
                    rank = 4;
                    suit = 2;
                    rankName = "Four";
                    suitName = "Spades";
                    cardImage = "4-4.png";
                    break;
                case 44:
                    rank = 5;
                    suit = 2;
                    rankName = "Five";
                    suitName = "Spades";
                    cardImage = "4-5.png";
                    break;
                case 45:
                    rank = 6;
                    suit = 2;
                    rankName = "Six";
                    suitName = "Spades";
                    cardImage = "4-6.png";
                    break;
                case 46:
                    rank = 7;
                    suit = 2;
                    rankName = "Seven";
                    suitName = "Spades";
                    cardImage = "4-7.png";
                    break;
                case 47:
                    rank = 8;
                    suit = 2;
                    rankName = "Eight";
                    suitName = "Spades";
                    cardImage = "4-8.png";
                    break;
                case 48:
                    rank = 9;
                    suit = 2;
                    rankName = "Nine";
                    suitName = "Spades";
                    cardImage = "4-9.png";
                    break;
                case 49:
                    rank = 10;
                    suit = 2;
                    rankName = "Ten";
                    suitName = "Spades";
                    cardImage = "4-10.png";
                    break;
                case 50:
                    rank = 11;
                    suit = 2;
                    rankName = "Jack";
                    suitName = "Spades";
                    cardImage = "4-11.png";
                    break;
                case 51:
                    rank = 12;
                    suit = 2;
                    rankName = "Queen";
                    suitName = "Spades";
                    cardImage = "4-12.png";
                    break;
                case 52:
                    rank = 13;
                    suit = 2;
                    rankName = "King";
                    suitName = "Spades";
                    cardImage = "4-13.png";
                    break;
            }
        }
    }
}


