using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422035_160422041
{
    [Serializable]
    public class Player
    {
        #region FIELDS
        private string username;  // !Di input waktu sign in / sign up <UNIQUE>
        private DateTime lastPlay;
        private int coins;

        //! For PET DEFENDER MODE
        private List<Player> listOfFriends;
        private List<Player> listOfRequested;
        private int petDefenderCoins;

        private int points;
        private int totalWin;
        private User playerUser;
        private Pet Happypet = null;
        private BattlePet battlePet = null;
        #endregion

        #region CONSTRUCTOR
        public Player(string username)
        {
            this.Username = username;
            this.lastPlay = DateTime.Now;
            this.Coins = 100;
            this.listOfFriends = new List<Player>();
            this.ListOfRequested = new List<Player>();
            this.PetDefenderCoins = 500;
            this.Points = 0;
            this.TotalWin = 0;
            this.PlayerUser = new User();
        }
        #endregion

        #region PROPERTIES
        public string Username 
        { 
            get => username; 
            set
            {
                if (value != "")
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("Player username can't be EMPTY!!");
                }
            } 
        }
        public DateTime LastPlay { get => lastPlay; set => lastPlay = value; }
        public int Coins { get => coins; set => coins = value; }
        public List<Player> ListOfFriends { get => listOfFriends; set => listOfFriends = value; }
        public List<Player> ListOfRequested { get => listOfRequested; set => listOfRequested = value; }
        public int PetDefenderCoins { get => petDefenderCoins; set => petDefenderCoins = value; }

        public int Points { get => points; set => points = value; }
        public int TotalWin { get => totalWin; set => totalWin = value; }

        public User PlayerUser { get => playerUser; set => playerUser = value; }
        public Pet HappyPet { get => Happypet; set => Happypet = value; }
        public BattlePet BattlePet { get => battlePet; set => battlePet = value; }
        #endregion

        #region METHODS
        public string DisplayData()
        {
            string data = "Username: " + this.Username +
                          "\nCoins: " + this.Coins;

            return data;
        }

        public void AcceptFriendRequest(Player player)
        {
            ListOfFriends.Add(player);

            foreach (Player requested in ListOfRequested )
            {
                if (requested.Username == player.Username)
                {
                    ListOfRequested.Remove(player);
                }
            }
        }

        public void RemoveFriend(Player player)
        {
            foreach (Player friend in ListOfFriends)
            {
                if (friend.Username == player.Username)
                {
                    ListOfFriends.Remove(player);
                }
            }
        }
        #endregion
    }
}