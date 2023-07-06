using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public static class GameUtils
    {
        #region FIELDS
        public static readonly string DB_FILE = "players_db.dat";
        private static Player currentPlayer = null;
        #endregion

        #region PROPERTIES
        #endregion

        #region METHODS
        // TODO: Buat ambil player yang berhasil login
        public static Player player()
        {
            if (currentPlayer == null) throw new ArgumentException("No player is currently logged in.");
            return currentPlayer;
        }

        // TODO: Buat Load Data players
        public static bool LoadData(out List<Player> listPlayers)
        {
            listPlayers = new List<Player>();
            // TODO: Cek dan load file
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                //! Jika ada
                if (File.Exists(DB_FILE))
                {
                    FileStream fileStream1 = new FileStream(
                            DB_FILE, 
                            FileMode.Open, 
                            FileAccess.Read
                        );


                    listPlayers = binaryFormatter.Deserialize(fileStream1) as List<Player>;

                    fileStream1.Close();

                    return true;
                }

                //! Jika tidak ada, maka kita buat baru dan asumsikan bahwa blm ada player yang terdaftar
                FileStream fileStream = new FileStream(
                        DB_FILE,
                        FileMode.Create,
                        FileAccess.Write
                    );

                binaryFormatter.Serialize(fileStream, listPlayers);

                fileStream.Close();

                return false;
               
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        // TODO: Buat Nyimpen Data Player
        public static void SaveData(List<Player> listPlayers)
        {
            try
            {
                FileStream fileStream = new FileStream(
                        DB_FILE,
                        FileMode.Create,
                        FileAccess.Write
                    );

                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fileStream, listPlayers);

                fileStream.Close();

            }
            catch (Exception x)
            {
                throw x;
            }
        }

        // TODO: Update state, dipake di dalam method SaveData
        public static void UpdateCurrentPlayer(Player currPlayer)
        {
            //! Ambil data semua player
            List<Player> players;
            LoadData(out players);

            for (int cnt = 0; cnt < players.Count; cnt++)
            {
                if (players[cnt].Username == currentPlayer.Username)
                {
                    players[cnt] = currentPlayer;
                }
            }

            SaveData(players);
        }

        // TODO: Buat login, kalo berhasil fields currentPlayer diisi dengan player yang berhasil login
        public static bool Login(string username, FormLogin form)
        {
            foreach (Player player in form.listOfPlayers)
            {
                if (player.Username == username)
                {
                    currentPlayer = player;
                    return true;
                }
            }

            throw new ArgumentException("Username not available!");
        }

        // TODO: Buat signup, bikin player baru denga username yang unique (YANG BELUM TERDAFTAR)
        public static bool SignUp(string username, FormSignUp form)
        {
            foreach (Player player in form.listOfPlayers)
            {
                if (player.Username == username)
                {
                    throw new ArgumentException($"Username: {username} is already taken!");
                }
            }

            //! Create new Player and add it to listOfPlayer in form signUp
            Player newPlayer = new Player(username);
            form.listOfPlayers.Add(newPlayer);

            //! Save File
            SaveData(form.listOfPlayers);

            return true;
        }

        //TODO: Buat Sign Out player
        public static bool SignOut()
        {
            if (currentPlayer != null)
            {
                currentPlayer = null;
                return true;
            }

            //! Ketika tidak ada player yang login tetapi maksa buat signout
            return false;
        }
        #endregion
    }
}
