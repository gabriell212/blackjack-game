using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace Blackjack_LogicSphere
{
    public partial class Form1 : Form
    {
        // This class can store the attributes of a card from the deck
        // The method GetPath will return the path to the card's image
        class Card
        {
            public string Value { get; set; }
            public int Points { get; set; }
            public string Suit { get; set; }
            private string imagePath;
            public Card(string initValue, int initPoints, string initSuit, string imagePath)
            {
                Value = initValue;
                Points = initPoints;
                Suit = initSuit;
                this.imagePath = imagePath;
            }
            public string GetPath()
            {
                return imagePath;
            }
        }
        // This constant will be used to limit the number of cards that can be generated
        // This way the pictureBoxes will not be generated outside the window
        private const int MAX_CARDS = 7;

        // This is used to store the played bet
        private double bet = 0;

        // Dealer's and player's card scores
        private int playerScore = 0;
        private int dealerScore = 0;

        // Dealer's and player's chips (by default - 5000)
        private double playerChips = 5000;
        private double dealerChips = 5000;

        // These will be used for random card generator
        private Card currentCard = new Card("0", 0, "", "");
        private Random rnd = new Random();

        // These store the pictureBoxes for both the player and dealer where the cards will be displayed
        private List<PictureBox> playerPictureBoxes = new List<PictureBox>();
        private List<PictureBox> dealerPictureBoxes = new List<PictureBox>();

        // These store the whole deck (hand) of both players
        private List<Card> playerDeck = new List<Card>();
        private List<Card> dealerDeck = new List<Card>();

        // This is used for the original deck, made out of the 52 cards
        private List<Card> deck = new List<Card>();

        // This is used for the betting choices
        private List<Button> betButtonsList;

        // Values and symbols of each possible card
        private List<string> deckValues = new List<string>
        {
            "A","2","3","4","5","6","7","8","9","10","J","Q","K"
        };
        private List<string> deckSuits = new List<string>
        {
            "clubs",
            "diamonds",
            "hearts",
            "spades"
        };

        // Path to the folder where the images for the cards are placed
        private static string basePath = "C:\\Users\\User\\source\\repos\\Blackjack_LogicSphere\\Blackjack_LogicSphere\\Resources\\";

        // Path to the image for the backside of a card
        private string defaultCardPath = basePath + "BehindACard.jpg";

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Add both player's and dealer's first two cards pictureBoxes in their lists
            // That way we get to manage the existent and the new created pictureBoxes
            playerPictureBoxes.Add(pboPlayerCard1);
            playerPictureBoxes.Add(pboPlayerCard2);

            dealerPictureBoxes.Add(pboDealerCard1);
            dealerPictureBoxes.Add(pboDealerCard2);

            // Initialize the button list by adding the betting buttons into it, then assign the events
            betButtonsList = new List<Button>() { btnBet1, btnBet2, btnBet3, btnBet4, btnBet5 };
            AddEventToButtons();
        }

        // This function will be executed when the player clicks "New game" button
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Initialize the betting buttons' texts and values
            InitializeBettingButtons();

            // Starts a new game
            StartGame();

            // Configure the rest of the buttons
            btnStartGame.Visible = false;
            btnNewRound.Visible = true;
            btnHit.Visible = true;
            btnStand.Visible = true;
        }

        // This function will be executed when the player clicks "Set chips" button
        private void btnSetChips_Click(object sender, EventArgs e)
        {
            SetChips();
        }

        // This function will be executed when the player clicks "New round" button
        private void btnNewRound_Click(object sender, EventArgs e)
        {
            // Starts a new round
            StartNewRound();
        }

        // This function will be executed when the player clicks "Hit" button.
        private void btnHit_Click(object sender, EventArgs e)
        {
            // Hit (pull) a new card from the deck
            Hit(playerDeck, playerPictureBoxes, "player");

            // Handle the case where the player gets a 21 hand before the dealer
            if (GetDeckPoints(playerDeck) == 21)
            {
                btnHit.Enabled = false;
                btnStand.Enabled = false;

                StartDealerTurn();
            }
        }

        // This function will be executed when the player clicks "Stand" button. This will end player's turn
        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            StartDealerTurn();
        }

        // This function will be executed when the player clicks "New game" button. It just starts a new game.
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = true;
            btnSetChips.Visible = true;
            btnNewGame.Visible = false;

            RemovePictureBoxes(playerPictureBoxes);
            RemovePictureBoxes(dealerPictureBoxes);
            dealerPictureBoxes[1].Image = Image.FromFile(defaultCardPath);
            SetCardsVisibility(false);

            playerChips = 5000;
            dealerChips = 5000;
            bet = 0;

            lblWinner.Text = "";
            lblPlayerPoints.Text = "";
            lblPlayerChips.Text = "0 chips";
            lblDealerChips.Text = "0 chips";
        }

        // This function will be executed when the player clicks "All in" button.
        // This function provides the opportunity to place an all-in bet.
        private void btnAllIn_Click(object sender, EventArgs e)
        {
            // Assign the lowest chips amount to the bet
            // This way we can avoid situations of receiving more than the minimum amount of chips owned by either the player or the dealer.
            bet = playerChips < dealerChips ? playerChips : dealerChips;
            HandleBettingOptions(false);

            btnHit.Enabled = true;
            btnStand.Enabled = true;

            // Cards show off
            SetCardsVisibility(true);
        }

        // This function assigns an event to a button
        private void AddEventToButtons()
        {
            foreach (Button b in betButtonsList)
                b.Click += ButtonClick;
        }

        /*
        This function executes when click a betting button
        Betting options are following:
        Button 1: 10%
        Button 2: 20%
        Button 3: 30%
        Button 4: 40%
        Button 5: 50%
        */
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            bet = double.Parse(button.Text);
            HandleBettingOptions(false);

            btnHit.Enabled = true;
            btnStand.Enabled = true;

            SetCardsVisibility(true);

            // Checks for natural blackjack
            CheckBlackjack();
        }

        // This function will initialize the betting buttons
        private void InitializeBettingButtons()
        {
            for (int i = 0; i < betButtonsList.Count; i++)
                betButtonsList[i].Text = (((double)(i + 1) / 10) * playerChips).ToString();
        }

        // This function starts a new game
        private void StartGame()
        {
            // Disables the option to set the amount of chips
            btnSetChips.Visible = false;

            // Set the chips
            lblDealerChips.Text = dealerChips + " chips";
            lblPlayerChips.Text = playerChips + " chips";

            // Begin the new game by starting a new round
            StartNewRound();
        }

        // This function starts a new round
        private void StartNewRound()
        {
            // Clear the deck
            deck.Clear();

            // Initializing the deck
            for (int i = 0; i < deckValues.Count; i++)
                for (int j = 0; j < deckSuits.Count; j++)
                    deck.Add(new Card(deckValues[i], (i < 9) ? i + 1 : 10, deckSuits[j], basePath + deckValues[i] + "_of_" + deckSuits[j] + ".png"));

            lblWinner.Text = "";
            btnNewRound.Enabled = false;

            // Remove previous hands from the list
            playerDeck.Clear();
            dealerDeck.Clear();

            // Show betting options, and get the bet
            PlaceBet();

            // Remove any pictureBox that was generated in the last round / game
            RemovePictureBoxes(playerPictureBoxes);
            RemovePictureBoxes(dealerPictureBoxes);

            // Generate and set the first two cards for both player and dealer
            GetStarterCards(playerDeck, playerPictureBoxes);
            GetStarterCards(dealerDeck, dealerPictureBoxes);

            // Hide the cards until the player has chosen the bet
            SetCardsVisibility(false);

            // Change the label where the player can see his deck total score
            lblPlayerPoints.Text = GetDeckPoints(playerDeck).ToString();

            // Get both player's and dealer's score
            playerScore = GetDeckPoints(playerDeck);
            dealerScore = GetDeckPoints(dealerDeck);

            // Hide the dealer's second card
            pboDealerCard2.Image = Image.FromFile(defaultCardPath);
        }

        // This function will generate a new card and add it will be added to the respective pack of the one who draws it
        private void Hit(List<Card> targetDeck, List<PictureBox> targetPictureBoxes, string deckOwner)
        {
            // If the maximum amount of cards has been drawn, we stop further requests for hitting a new card
            if (targetDeck.Count == MAX_CARDS)
                return;

            // Generate the pictureBox for the card, add the card to the deck and set the image for the pictureBox
            GeneratePictureBox(targetPictureBoxes, deckOwner);
            AddCardToDeck(targetDeck);
            targetPictureBoxes[targetPictureBoxes.Count - 1].Image = Image.FromFile(targetDeck[targetDeck.Count - 1].GetPath());

            // Get the scores
            playerScore = GetDeckPoints(playerDeck);
            dealerScore = GetDeckPoints(dealerDeck);

            // Change the label with player's total score
            lblPlayerPoints.Text = GetDeckPoints(playerDeck).ToString();

            // Check if the player busts his hand by hitting a new card
            if (CheckBustedHand(targetDeck, deckOwner))
            {
                if (deckOwner == "player")
                    UpdateChipsAmount("dealer", bet);

                // Ends the round
                RoundOver();
            }
        }

        // This function will generate a random card
        private void GenerateCard()
        {
            int randomNumber = rnd.Next(deck.Count);

            // Store the generated card in a temporary object
            currentCard = deck[randomNumber];
        }

        // This function will add the newly generated card to the target's hand and remove it from the deck
        private void AddCardToDeck(List<Card> targetDeck)
        {
            GenerateCard();
            targetDeck.Add(currentCard);
            deck.Remove(currentCard);
        }

        // This function will generate the cards that the dealer and player are starting with (starter cards)
        private void GetStarterCards(List<Card> targetDeck, List<PictureBox> targetPictureBoxes)
        {
            // Firstly clear the previous decks
            targetDeck.Clear();

            for (int i = 0; i <= 1; i++)
            {
                AddCardToDeck(targetDeck);
                targetPictureBoxes[i].Image = Image.FromFile(targetDeck[i].GetPath());
            }
        }

        // This function generates and places a new pictureBoxes on the Form then adds it to the pictureBoxes' list
        private void GeneratePictureBox(List<PictureBox> targetPictureBoxes, string deckOwner)
        {
            PictureBox pictureBox = new PictureBox();
            if (deckOwner == "player")
            {
                pictureBox.Name = "pboPlayerCard" + (targetPictureBoxes.Count + 1).ToString();
                pictureBox.Location = new Point(122 + targetPictureBoxes[targetPictureBoxes.Count - 1].Location.X, 478);
            }
            else
            {
                pictureBox.Name = "pboDealerCard" + (targetPictureBoxes.Count + 1).ToString();
                pictureBox.Location = new Point(122 + targetPictureBoxes[targetPictureBoxes.Count - 1].Location.X, 26);
            }
            pictureBox.Width = 116;
            pictureBox.Height = 167;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = Image.FromFile(defaultCardPath);
            targetPictureBoxes.Add(pictureBox);
            Controls.Add(pictureBox);
        }

        // This functions removes any generated pictureBox from the previous round/game
        private void RemovePictureBoxes(List<PictureBox> targetPictureBoxes)
        {
            /*  Here we need a temporary object due to the fact that it's not possible
             *  to remove the control first, and then remove it from the list and vice-versa 
             */
            PictureBox tempPictureBox = new PictureBox();
            for (int i = targetPictureBoxes.Count - 1; i > 1; i--)
                if (Controls.Contains(targetPictureBoxes[i]))
                {
                    tempPictureBox = targetPictureBoxes[i];
                    Controls.Remove(targetPictureBoxes[i]);
                    targetPictureBoxes[i].Dispose();
                    targetPictureBoxes.Remove(tempPictureBox);
                }
        }

        // This function disables all player's choices, except for the New round button (basically the round is over)
        private void RoundOver()
        {
            ShowDealerHiddenCard();
            UpdateChipsLabel();
            tmrDealerAI.Enabled = false;
            btnNewRound.Enabled = true;
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            // Checks if either the player or the dealer has no chips left and stops the game accordingly
            if (playerChips == 0 || dealerChips == 0)
            {
                lblWinner.Text = playerChips == 0 ? "Game over! Dealer won!" : "Game over! Player won!";
                GameOver();
            }
        }

        // This function ends the game
        private void GameOver()
        {
            btnHit.Visible = false;
            btnStand.Visible = false;
            btnNewRound.Visible = false;
            btnNewGame.Visible = true;
        }

        // This function checks if either the player or the dealer busted its hand by hitting a card
        private bool CheckBustedHand(List<Card> targetDeck, string deckOwner)
        {
            if (GetDeckPoints(targetDeck) > 21)
            {
                lblWinner.Text = deckOwner == "player" ? "Dealer won!" : "Player won!";
                return true;
            }
            return false;
        }

        // This function return the total score of a hand
        private int GetDeckPoints(List<Card> targetDeck)
        {
            int score = 0;
            foreach (Card c in targetDeck)
            {
                score += c.Points;
            }

            // Handle the Ace points variation (an Ace can be either 1 or 11 points)
            if (score < 12)
                for (int i = 0; i < targetDeck.Count; i++)
                    if (targetDeck[i].Value == "A")
                    {
                        score += 10;
                        break;
                    }

            return score;
        }

        // This function checks for natural blackjack
        private void CheckBlackjack()
        {
            if (playerScore == 21 && playerDeck.Count == 2)
            {
                // Handle the situation where both players have a natural blackjack
                if (dealerScore == 21 && dealerDeck.Count == 2)
                    lblWinner.Text = "Push!";
                else
                {
                    lblWinner.Text = "Blackjack! Player won!";
                    UpdateChipsAmount("player", bet * 1.5);
                }
                RoundOver();
                return;
            }
        }

        // This function handles win cases
        private void CheckWin()
        {
            // Handle the other cases that don't involve a blackjack hand
            if (playerScore < dealerScore)
            {
                lblWinner.Text = "Dealer won!";
                UpdateChipsAmount("dealer", bet);
            }
            else if (playerScore > dealerScore)
            {
                lblWinner.Text = "Player won!";
                UpdateChipsAmount("player", bet);
            }
            else
                lblWinner.Text = "Push!";
            RoundOver();
        }

        // This function is executed when player's turn ends, and dealer's starts
        private void StartDealerTurn()
        {
            ShowDealerHiddenCard();
            tmrDealerAI.Enabled = true;
        }

        // This function sets the amount of chips the player and dealer are going to play with
        // If this isn't called, they will play with a default amount (5000 chips)
        private void SetChips()
        {
            string inputChips = "";
            inputChips = Interaction.InputBox("Please introduce the amount of chips: ");
            int convertedChips = 0;
            if (int.TryParse(inputChips, out convertedChips))
            {
                playerChips = convertedChips;
                dealerChips = convertedChips;
            }
            else
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        // This will deactivate the buttons with an higher amount of chips than the player/dealer has
        private void HandleBettingOptions(bool switched)
        {
            lblPlaceBet.Visible = switched;
            foreach (Button b in betButtonsList)
            {
                b.Visible = switched;
                b.Enabled = true;
            }
            btnAllIn.Visible = switched;

            // Here goes the code for the deactivation process
            foreach (Button b in betButtonsList)
                if (double.Parse(b.Text) > playerChips || double.Parse(b.Text) > dealerChips)
                    b.Enabled = false;
        }

        // This function will start the process of betting choice
        private void PlaceBet()
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            HandleBettingOptions(true);
        }

        //This function will hide or reveal everyone's cards except dealer's hidden card
        private void SetCardsVisibility(bool visible)
        {
            for (int i = 0; i <= 1; i++)
                playerPictureBoxes[i].Image = visible ? Image.FromFile(playerDeck[i].GetPath()) : Image.FromFile(defaultCardPath);
            dealerPictureBoxes[0].Image = visible ? Image.FromFile(dealerDeck[0].GetPath()) : Image.FromFile(defaultCardPath);

            // Also hide the points of the player
            lblPlayerPoints.Visible = visible;
        }

        // This function updates the labels containing the chips
        private void UpdateChipsLabel()
        {
            lblDealerChips.Text = dealerChips + " chips";
            lblPlayerChips.Text = playerChips + " chips";
        }

        // This is used to transfer the amount of chips won to the winner of the round
        private void UpdateChipsAmount(string betWinner, double chipsAmount)
        {
            // Here, "f" is a temporary variable which decides who is losing chips and who gets them
            int f = betWinner == "player" ? 1 : -1;
            playerChips += f * chipsAmount;
            dealerChips += (-1) * f * chipsAmount;
        }

        // This function hides the dealer's second card
        private void ShowDealerHiddenCard()
        {
            dealerPictureBoxes[1].Image = Image.FromFile(dealerDeck[1].GetPath());
        }

        // This function will execute everytime the interval from the timer will pass
        // This function will also provide the AI for the dealer, following the blackjack rules
        private void tmrDealerAI_Tick(object sender, EventArgs e)
        {
            // Follow the traditional rule of blackjack where the dealer has to Hit until 17 points
            // Then he has to force-Stand, unless its hand has been busted.
            if (GetDeckPoints(dealerDeck) < 17)
            {
                // Handle the case where the player hit "Stand" with a low amount of points
                // That way, the dealer will avoid situations where he can bust his hand even if he don't have a reason to do that
                if (GetDeckPoints(dealerDeck) > GetDeckPoints(playerDeck))
                {
                    CheckWin();
                    return;
                }

                // Pull the card and check for a busted hand
                Hit(dealerDeck, dealerPictureBoxes, "dealer");
                if (CheckBustedHand(dealerDeck, "dealer"))
                {
                    UpdateChipsAmount("player", bet);
                    RoundOver();
                    return;
                }
            }
            else
            {
                // Here is the "Stand" option
                tmrDealerAI.Enabled = false;
                if (!CheckBustedHand(dealerDeck, "dealer"))
                    CheckWin();
                return;
            }
        }

        // All the function that go below are used to redirect the user to our social media sites through specific pictureBoxes

        private void pboLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://logicspherestudio.wordpress.com/");
        }

        private void pboFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/LogisticSphereStudio");
        }

        private void pboInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/logic_sphere_studio/");
        }

        private void pboYoutube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/@LogicSphereStudio");
        }
    }
}
