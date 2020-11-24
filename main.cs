using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
  // variable to set up concatenation to write
  string line = "";
  // get StreamWriter and write to file inside the brackets
  StreamWriter sw = new StreamWriter("test.csv");
  // loop through the list 
  foreach (Song song in playlist.SongList)
  {
    // line variable that has been concatenated
    line = song.id.ToString() + "," + song.path + "," + song.rating.ToString() + "," + song.tags.ToString();
    // write to file whats in the line variable
    sw.WriteLine(line);
  }
  // close StreamWriter
  sw.Close();
  
}

private void buttonDealFirstCard_Click(object sender, EventArgs e)
        {
            // Generate 1st random card for player
            playerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            // add generated 1st random card to List<Card> playerCardList
            playerCardList.Add(playerCard1);

            // Generate 1st random card for dealer
            dealerCard1 = new Card(randomGenerator.Next(NUM_CARDS));
            // add generated 1st random card to List<Card> dealerCardList
            dealerCardList.Add(dealerCard1);

            // Display the first card to player and dealer
            listBoxPlayerCards.Items.Add(playerCardList[0].ToString());
            //textBoxDealerCard1_.Text = dealerCard1.ToString();
            listBoxDealerCards.Items.Add(dealerCardList[0].ToString());

            // Clear the second card and totals
            //textBoxPlayerCard2_.Text = "";
            textBoxPlayerTotal_.Text = "";
            //textBoxDealerCard2_.Text = "";
            textBoxDealerTotal_.Text = "";
        }

        private void buttonDealSecondCard_Click(object sender, EventArgs e)
        {
            // generate random card no2
            playerCard2 = new Card(randomGenerator.Next(NUM_CARDS));
            // add card no2 to the playerCardList
            playerCardList.Add(playerCard2);
            // dealer card no2
            dealerCard2 = new Card(randomGenerator.Next(NUM_CARDS));
            // add card no2 to the dealerCardList
            dealerCardList.Add(dealerCard2);

            if (playerBet == null)
            {
                MessageBox.Show("Please place a bet");
            }
            else if (playerBet == textBoxBet_.SelectionLength)
            {
                // get bet amount from the textBoxBet_ 
                playerBet = int.Parse(textBoxBet_.Text);

                // get the total points for player and dealer
                int playerTotal = playerCard1.Points + playerCard2.Points;
                int dealerTotal = dealerCard1.Points + dealerCard2.Points;

                // player and dealer totals
                textBoxPlayerTotal_.Text = playerTotal.ToString();
                textBoxDealerTotal_.Text = dealerTotal.ToString();
            }
            // display in allocated listBoxes
            listBoxPlayerCards.Items.Add(playerCardList[1].ToString());
            listBoxDealerCards.Items.Add(dealerCardList[1].ToString());
        }
