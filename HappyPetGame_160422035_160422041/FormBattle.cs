using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyPetGame_160422035_160422041
{
    public partial class FormBattle : Form
    {
        FormSelectEnemy formSelectEnemy;
        Enemy enemy;
        BattlePet battlePet;
        Player player; 
        int battlePetHp, enemyHp;

        bool makeChoice = true;  //! Waktu pemilihan
        bool isUserMakeChoice = false;
        bool isEnd = false;
        bool transition = false;
        bool isBTKSession = false;
        bool isBattlePetAttackSession = false;
        bool isEnemyAttackSession = false;
        string userChoice = "";
        string enemyChoice = "";
        string userAttackType = "";
        List<string> listOfChoice = new List<string> { "Batu", "Gunting", "Kertas" };
        bool makeAttack = false;  //! Waktu pemilihan
        bool isUserMakeAttack = false;
        int cnt = 5;
        int charge = 0;
        int enemyCharge = 0;
        public FormBattle()
        {
            InitializeComponent();
        }

        private void FormBattle_Load(object sender, EventArgs e)
        {
            formSelectEnemy = (FormSelectEnemy)this.Owner;
            enemy = formSelectEnemy.enemy;
            battlePet = Auth.player().BattlePet;
            player = Auth.player();
            pictureBoxEnemy.Image = formSelectEnemy.enemy.Picture.Image;
            pictureBoxBattlePet.Image = Auth.player().BattlePet.PetImage;

            battlePetHp = battlePet.Hp;
            enemyHp = enemy.Hp;

            panelAttack.Enabled = false;
            panelAttack.Visible = false;

            buttonUltimate.Enabled = false;

            this.KeyPreview = true;  // !Agar tetap dapat menerima input dari keyboard meskipun terdapat Control yang focus
            this.Text = this.Size.Width + "," + this.Size.Height;
            this.Size = new Size(990, 570);
        }

        private async void game_Tick(object sender, EventArgs e)
        {
            labelBattlePetHp.Text = battlePetHp.ToString();
            labelEnemyHp.Text = enemyHp.ToString();
            labelBattlePetUltimate.Text = "Ultimate: " + charge + "%";
            labelEnemyUltimate.Text = "Ultimate: " + enemyCharge + "%";
            
            //! Hasil battle
            if (battlePetHp == 0)
            {
                player.PetDefenderCoins += (GameUtils.BONUS_BATTLE * battlePet.Level);
                Auth.UpdateCurrentPlayer(player);

                labelKeputusan.Text = "";
                labelBattlePetUltimate.Text = "";
                labelEnemyUltimate.Text = "";
                labelHasilAkhir.Text = "Kamu Kalah";
                labelHasilAkhir.Location = new Point(245, 26);
                panelBTK.Enabled = false;
                panelBTK.Visible = false;
                game.Enabled = false;
                isEnd = true;
                return;
            }
            else if (enemyHp == 0)
            {
                player.PetDefenderCoins += battlePetHp * (GameUtils.BONUS_BATTLE * battlePet.Level);
                player.Points += battlePetHp * (30 * battlePet.Level);
                Auth.UpdateCurrentPlayer(player);

                labelKeputusan.Text = "";
                labelBattlePetUltimate.Text = "";
                labelEnemyUltimate.Text = "";
                labelHasilAkhir.Text = "Kamu Menang";
                labelHasilAkhir.Location = new Point(271, 26);
                panelBTK.Enabled = false;
                panelBTK.Visible = false;
                game.Enabled = false;
                isEnd = true;
                return;
            }

            //! Make choice
            if (makeChoice)
            {
                if (!labelCount.Visible) labelCount.Visible = true;
                if (cnt >= 0)
                {
                    labelCount.Text = "Count: " + cnt;
                    cnt--;
                    return;
                }
                else
                {
                    if (!isUserMakeChoice)
                    {
                        userChoice = listOfChoice[new Random().Next(listOfChoice.Count)];
                        isUserMakeChoice = true;
                    }

                    enemyChoice = listOfChoice[new Random().Next(listOfChoice.Count)];
                    makeChoice = false;
                    isBTKSession = true;
                }
            }

            //! Judge Batu Gunting Kertas
            if (isBTKSession)
            {
                panelBTK.Visible = false;
                labelUserChoice.Text = userChoice;
                labelEnemyChoice.Text = enemyChoice;
                labelKeputusan.Text = IsWin(userChoice, enemyChoice);
                isBTKSession = false;
                return;
            }

            //! Make Attack
            if (makeAttack)
            {
                if (!labelCount.Visible) labelCount.Visible = true;
                

                if (cnt >= 0)
                {
                    labelCount.Text = "Count: " + cnt;
                    cnt--;
                    return;
                }
                else
                {
                    if (!isUserMakeAttack)
                    {
                        userAttackType = "Attack";
                        isUserMakeAttack = true;
                    }

                    makeAttack = false;
                    isBattlePetAttackSession = true;
                }
            }

            //! Battle Pet Attack Session
            if (isBattlePetAttackSession)
            {
                panelAttack.Visible = false;
                panelAttack.Enabled = false;
                
                if (userAttackType == "Attack")
                {
                    int damage = battlePet.Attack(enemy);

                    if (enemyHp - damage < 0)
                    {
                        enemyHp = 0;
                    }
                    else
                    {
                        enemyHp -= damage;
                    }

                    int addCharge = new Random().Next(10, 36);

                    if (charge + addCharge > 100)
                    {
                        charge = 100;
                    }
                    else
                    {
                        charge += addCharge;
                    }
                }
                else
                {
                    int damage = battlePet.UltimateDamage(enemy);

                    if (enemyHp - damage < 0)
                    {
                        enemyHp = 0;
                    }
                    else
                    {
                        enemyHp -= damage;
                    }
                    
                }

                isBattlePetAttackSession = false;

                makeChoice = true;
                cnt = 5;

                isUserMakeChoice = false;
                isUserMakeAttack = false;

                panelBTK.Enabled = true;
                panelBTK.Visible = true;
                labelEnemyChoice.Text = "";
                labelUserChoice.Text = "";
                labelKeputusan.Text = "";


                if (charge == 100 && !buttonUltimate.Enabled)
                {
                    buttonUltimate.Enabled = true;
                }

                return;
            }

            //! Kalo seri
            if (IsWin(userChoice, enemyChoice) == "Seri")
            {
                makeChoice = true;
                isUserMakeChoice = false;
                panelBTK.Enabled = true;
                panelBTK.Visible = true;
                labelEnemyChoice.Text = "";
                labelUserChoice.Text = "";
                labelKeputusan.Text = "";
                cnt = 5;


                if (charge == 100 && !buttonUltimate.Enabled)
                {
                    buttonUltimate.Enabled = true;
                }
                return;
            }

            //! Kalo Menang
            if (IsWin(userChoice, enemyChoice) == "Menang")
            {
                panelAttack.Enabled = true;
                panelAttack.Visible = true;

                labelEnemyChoice.Text = "";
                labelUserChoice.Text = "";
                labelKeputusan.Text = "";

                makeAttack = true;
                cnt = 5;
                return;
            }

            //! Kalo Kalah
            if (IsWin(userChoice, enemyChoice) == "Kalah")
            {
                makeChoice = true;
                cnt = 5;

                isUserMakeChoice = false;
                isUserMakeAttack = false;

                panelBTK.Enabled = true;
                panelBTK.Visible = true;
                labelEnemyChoice.Text = "";
                labelUserChoice.Text = "";
                labelKeputusan.Text = "";

                if (enemyCharge == 100)
                {
                    enemyCharge = 0;
                    int damage = enemy.UltimateDamage(battlePet);

                    if (battlePetHp - damage < 0)
                    {
                        battlePetHp = 0;
                        return;
                    }
                    else
                    {
                        battlePetHp -= damage;
                    }
                }
                else
                {
                    int damage = enemy.Attack(battlePet);

                    if (battlePetHp - damage < 0)
                    {
                        battlePetHp = 0;
                        return;
                    }
                    else
                    {
                        battlePetHp -= damage;
                    }

                    int addCharge = new Random().Next(15, 31);

                    if (enemyCharge + addCharge > 100)
                    {
                        enemyCharge = 100;
                    }
                    else
                    {
                        enemyCharge += addCharge;
                    }
                }


                if (charge == 100 && !buttonUltimate.Enabled)
                {
                    buttonUltimate.Enabled = true;
                }
            }


            /*

            //! Transisi
            if (transition)
            {
                makeAttack = true;
                labelUserChoice.Text = "";
                labelEnemyChoice.Text = "";
                labelKeputusan.Text = "";
                cnt = 5;
                transition = false;
            }

            labelBattlePetHp.Text = battlePetHp.ToString();
            labelEnemyHp.Text = enemyHp.ToString();

            //! Waktu milih batu gunting kertas
            if (!makeChoice)
            {
                if (!labelCount.Visible) labelCount.Visible = true;
                labelCount.Text = "Count: " + cnt;
                if (cnt >= 0)
                {
                    cnt--;
                }
                if (cnt == 0)
                {
                    enemyChoice = listOfChoice[new Random().Next(listOfChoice.Count)];
                    makeChoice = true;
                }

                if (!makeChoice) return;
            }

            // !Kalo waktu milih udh selese, tpi user blm milih. Maka pilihan user akan random
            if (!isUserMakeChoice)
            {
                userChoice = listOfChoice[new Random().Next(listOfChoice.Count)];
                isUserMakeChoice = true;
            }

            //! Waktu milih attack
            if (makeAttack)
            {
                //! Kalo user blm milih attack
                if (!isUserMakeAttack)
                {
                    panelAttack.Visible = true;
                    panelAttack.Enabled = true;
                }
                else
                {
                    panelAttack.Enabled = false;
                }

                if (charge == 100 && buttonUltimate.Enabled == false)
                {
                    buttonUltimate.Enabled = true;
                    charge = 0;
                }

                if (!labelCount.Visible) labelCount.Visible = true;
                labelCount.Text = "Count: " + cnt;

                if (cnt >= 0)
                {
                    cnt--;
                    return;
                }

                if (cnt == 0)
                {
                    isBattlePetAttackSession = true;
                    labelCount.Visible = false;
                    //! Kalo user nggak milih attack
                    if (!isUserMakeAttack)
                    {
                        userAttackType = "Attack";
                        isUserMakeAttack = true;
                    }
                    makeAttack = false;
                }

                if (makeAttack) return;
            }

            if (isBTKSession)
            {
                panelBTK.Visible = false;
                panelBTK.Enabled = false;
                labelUserChoice.Text = userChoice;
                labelEnemyChoice.Text = enemyChoice;
                labelKeputusan.Text = IsWin(userChoice, enemyChoice);
                isBTKSession = false;
            }

            if (isBattlePetAttackSession)
            {
                panelAttack.Enabled = false;
                panelAttack.Visible = false;
                int damage = battlePet.Attack(enemy);
                if (enemy.Hp - damage < 0) enemyHp = 0;
                enemyHp -= damage;
                labelEnemyHp.Text = enemyHp.ToString();

                //if (isBattlePetAttackSession) return;

                isBattlePetAttackSession = false;
                isBTKSession = true;
                cnt = 5;
            }

            //! Kalo Seri
            if (IsWin("Gunting", "Kertas") == "Seri")
            {
                makeChoice = false;
                panelBTK.Visible = true;
                panelBTK.Enabled = true;
                labelUserChoice.Text = "";
                labelEnemyChoice.Text = "";
                labelKeputusan.Text = "";
                cnt = 5;
                isBTKSession = true;
            }
             
            //! Transisi dari milih pilihan ke milih attack kalo user menang
            if (IsWin("Gunting", "Kertas") == "Menang")
            {
                transition = true;
                return;
            }
            */

            
        }

        private void buttonBatu_Click(object sender, EventArgs e)
        {
            if (!isUserMakeChoice)
            {
                isUserMakeChoice = true;
                userChoice = "Batu";
                panelBTK.Enabled = false;
            }
        }

        private void buttonGunting_Click(object sender, EventArgs e)
        {
            if (!isUserMakeChoice)
            {
                isUserMakeChoice = true;
                userChoice = "Gunting";
                panelBTK.Enabled = false;
            }
        }

        private void buttonKertas_Click(object sender, EventArgs e)
        {
            if (!isUserMakeChoice)
            {
                isUserMakeChoice = true;
                userChoice = "Kertas";
                panelBTK.Enabled = false;
            }
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (!isUserMakeAttack)
            {
                userAttackType = "Attack";
                isUserMakeAttack = true;
                panelAttack.Enabled = false;
            }
        }

        private void buttonUltimate_Click(object sender, EventArgs e)
        {
            if (!isUserMakeAttack)
            {
                userAttackType = "Ultimate";
                isUserMakeAttack = true;
                panelAttack.Enabled = false;
                buttonUltimate.Enabled = false;
                charge = 0;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (battlePet.Hp == 0)
            {
                labelKeputusan.Text = "Kamu kalah :(";
                timer1.Enabled = false;
                return;
            }
            else if (enemy.Hp == 0)
            {
                labelKeputusan.Text = "Kamu menang :)";
                timer1.Enabled = false;
                return;
            }

            #region MAKE CHOICE
            if (makeChoice)
            { 
                
            }
            #endregion
        }

        private void FormBattle_KeyDown(object sender, KeyEventArgs e)
        {
            game.Stop();
            if (!isEnd)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    DialogResult res = MessageBox.Show(
                            "Yakin? Kamu nggak bakal dapet point lhoo",
                            ":(",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                    if (res == DialogResult.Yes)
                    {
                        this.Close();
                        return;
                    }
                    game.Start();
                }
            }
            else
            {
                this.Close();
                return;
            }
        }

        private string IsWin(string userChoice, string enemyChoice)
        {
            if (userChoice == enemyChoice) return "Seri";

            if (userChoice == "Batu")
            {
                if (enemyChoice == "Gunting")
                {
                    return "Menang";
                }
                else
                {
                    return "Kalah";
                }
            }
            else if (userChoice == "Gunting")
            {
                if (enemyChoice == "Kertas")
                {
                    return "Menang";
                }
                else
                {
                    return "Kalah";
                }
            }
            else
            {
                if (enemyChoice == "Batu")
                {
                    return "Menang";
                }
                else
                {
                    return "Kalah";
                }
            }
        }
    }
}
