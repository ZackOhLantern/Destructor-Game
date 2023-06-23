/*
 * 1. Zachary Cuervo
 * 2. 1903835
 * 3. Assignment 2
 * 4. 03/18/223 submission
 */

// ASCII art found on https://www.asciiart.eu/

using System;



public class A01
{

    static void Main()
    {
        Random rand = new Random();
        string gameLoopInput = "y";

        
        do
        {
            string matchResult = "defeat";

            do // MENU SCREEN
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Welcome to the game of \nThe Evil Destructor, \nDestroyer of Data!\n****************\n     ______\n    | |__| |\n    |  ()  |\n    |______|");

                Console.WriteLine("\n****************\nConsume all inactive objects!");
                Console.WriteLine("\nAre you prepared to DESTRUCT!? (y/n)");

                if (gameLoopInput != "y" && gameLoopInput != "n")
                {
                    Console.WriteLine("Please enter a valid character: y or n ");
                }

                gameLoopInput = Console.ReadLine();

            } while (gameLoopInput != "y" && gameLoopInput != "n");

            if (gameLoopInput == "y") // RUN THE GAME
            {
                // STATS
                int playerMaxHealth = 200;
                int playerMaxMana = 100;
                int playerHealth = 200;
                int playerAttack = 20;
                int playerHeal = 60;
                int playerMagic = 40;
                int playerMana = 100;
                int playerManaRegen = 20;

                int playerHealthLevel = 1;
                int playerAttackLevel = 1;
                int playerHealLevel = 1;
                int playerMagicLevel = 1;
                int playerManaLevel = 1;
                int playerManaRegenLevel = 1;

                int enemyMaxHealth = 1000;
                int enemyHealth = 1000;
                int enemyAttack = 40;
                int enemyHeal = 50;
                int enemyMagic = 100;
                int enemyMana = 100;
                int enemyManaRegen = 20;
                int enemyMaxMana = 100;

                int enemyHealthLevel = 1;
                int enemyAttackLevel = 1;
                int enemyHealLevel = 1;
                int enemyMagicLevel = 1;
                int enemyManaLevel = 1;
                int enemyManaRegenLevel = 1;

                string playerInput = "0";
                int enemyInput = 1; 

                do // MAIN GAME
                {
                    //DRAW THE SCENE
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                    Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                    playerInput = Console.ReadLine();


                    while ((playerInput != "1") && (playerInput != "2") && (playerInput != "3") && (playerInput != "4") && (playerInput != "5") && (playerInput != "6") && (playerInput != "7") && (playerInput != "8") && (playerInput != "9")) { 
                        Console.WriteLine(" ENTER A NUMBER, 1 THROUGH 9 ARGH!!!");
                        playerInput = Console.ReadLine();
                    } 

                    //PLAYER ACTIONS
                    switch (playerInput)
                    {
                        case "1":
                            enemyHealth -= (playerAttack + (10*playerAttackLevel));
                            break;
                        case "2":
                            if(playerMana >= 50)
                            {
                                playerHealth += (playerHeal + (10 * playerHealLevel));
                                playerMana -= 50;
                            } else
                            {
                                Console.WriteLine("\nDestructor: FOOL! I do not have enough Mana!!! ");
                            }
                            break;
                        case "3":
                            if (playerMana >= 50)
                            {
                                playerMana -= 50;
                                enemyHealth -= (playerMagic + (25 * playerMagicLevel));
                            } else
                            {
                                Console.WriteLine("\nDestructor: FOOL! I do not have enough Mana!!! ");
                            }
                            break;
                        case "4":
                            playerMaxHealth += 40;
                            playerHealthLevel++;
                            break;
                        case "5":
                            playerAttackLevel++;
                            break;
                        case "6":
                            playerHealLevel++;
                            break;
                        case "7":
                            playerMagicLevel++;
                            break;
                        case "8":
                            playerManaLevel++;
                            playerMaxMana += 25;
                            break;
                        case "9":
                            playerManaRegen += 10;
                            playerManaRegenLevel++;
                            break;
                    }

                    //ENEMY ACTIONS
                    enemyInput = rand.Next(1,9);
                    switch (enemyInput)
                    {
                        case 1:
                            playerHealth -= (enemyAttack + (10 * enemyAttackLevel));
                            Console.Clear();
                            Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                            Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                            Console.WriteLine("\nThe Hero Attacks!!!");
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                            Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                            Console.WriteLine("\nThe Hero Attacks!!!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Thread.Sleep(100); Console.Clear();
                            Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                            Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                            Console.WriteLine("\nThe Hero Attacks!!!");
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                            Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                            Console.WriteLine("\nThe Hero Attacks!!!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Thread.Sleep(100); Console.Clear();
                            Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                            Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                            Console.WriteLine("\nThe Hero Attacks!!!");
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                            Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                            Console.WriteLine("\nThe Hero Attacks!!!");
                            Console.BackgroundColor = ConsoleColor.Black;


                            break;
                        case 2:
                            if (enemyMana >= 50)
                            {
                                enemyHealth += (enemyHeal + (10 * enemyHealLevel));
                                enemyMana -= 50;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Heals!!!");
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Heals!!!");
                                Console.BackgroundColor = ConsoleColor.Black; Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Heals!!!");
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Heals!!!");
                                Console.BackgroundColor = ConsoleColor.Black; Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Heals!!!");
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Heals!!!");
                                Console.BackgroundColor = ConsoleColor.Black;

                            }
                            else
                            {
                                Console.WriteLine("\nHeap Hero: Good Heavens I am out of mana!");
                            }
                            break;
                        case 3:
                            if (enemyMana >= 50)
                            {
                                playerHealth -= (enemyMagic + (25 * enemyMagicLevel));
                                enemyMana -= 50;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Casts MAGIC!!!");
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Casts MAGIC!!!");
                                Console.BackgroundColor = ConsoleColor.Black; Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Casts MAGIC!!!");
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Casts MAGIC!!!");
                                Console.BackgroundColor = ConsoleColor.Black; Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Casts MAGIC!!!");
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(100); Console.Clear();
                                Console.WriteLine($" /|                 |\\             /__\\__  // \n/ |                 | \\           //_____\\/// \n\\ \\_________________/ /          _| /-_-\\)|/_ \n \\|# : \\       / : #|/          (___\\ _ //___\\ \n  |  :  \\     /  :  |           (  |\\\\_/// * \\\\ \n  |  :  O      O :  |            \\_| \\_((*   *)) \n  |  :___________:  |            ( |__|_\\\\  *// \n  |                 |            (o/  _  \\_*_/ \n  |    | \\/\\/\\/\\/|  |            //\\\\__|__/\\\\ \n  \\____|_/\\/\\/\\/\\|__/           // |  | |  | \n                               //  _\\ | |___) \n                              //  (___| \n   * Evil Destructor *           * Heap Hero * \n     Health: {playerHealth}          Health: {enemyHealth}\n     Mana:   {playerMana}");
                                Console.WriteLine("\nWHAT SHALL DESTRUCTOR DO ??? TYPE THE CORRESPONDING NUMBER TO DIRECT DESTRUCTOR!!\n 1. Attack           2. Heal (100 mana)  3. Magic (100 mana)\n 4. Upgrade Health   5. Upgrade attack   6. Upgrade Heal\n 7. Upgrade Magic    8. Upgrade Mana     9. Upgrade Mana Regen\n");
                                Console.WriteLine("\nThe Hero Casts MAGIC!!!");
                                Console.BackgroundColor = ConsoleColor.Black; 

                            }
                            else
                            {
                                Console.WriteLine("\nHeap Hero: Good Heavens I am out of mana!");
                            }
                            break;
                        case 4:
                            enemyMaxHealth += 40;
                            enemyHealthLevel++;
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe Hero Grows Stronger!");

                            break;
                        case 5:
                            enemyAttackLevel++;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("\nThe Hero Grows Stronger!");

                            break;
                        case 6:
                            enemyHealLevel++;
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nThe Hero Grows Stronger!");

                            break;
                        case 7:
                            enemyMagicLevel++;
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\nThe Hero Grows Stronger!");

                            break;
                        case 8:
                            enemyManaLevel++;
                            enemyMaxMana += 25;
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\nThe Hero Grows Stronger!");

                            break;
                        case 9:
                            enemyManaRegen += 10;
                            enemyManaRegenLevel++;
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nThe Hero Grows Stronger!");

                            break;
                    }

                    // STATS UPDATE;

                    playerMana += playerManaRegen;
                    enemyMana += enemyManaRegen;

                    if (playerMana > playerMaxMana)
                    {
                        playerMana = playerMaxMana;
                    }

                    if (enemyMana > enemyMaxMana)
                    {
                        enemyMana = enemyMaxMana;
                    }

                    if (playerHealth > playerMaxHealth)
                    {
                        playerHealth = playerMaxHealth;
                    }

                    if (enemyHealth > enemyMaxHealth)
                    {
                        enemyHealth = enemyMaxHealth;
                    }

                    Console.WriteLine("\nPRESS ENTER FOR NEXT TURN!!!");
                    Console.ReadLine();

                    Console.BackgroundColor = ConsoleColor.Black;
                } while ((enemyHealth > 0) && (playerHealth > 0));
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;

                

                if (playerHealth <= 0)
                {
                    Console.WriteLine("\n\n ******** \n YOU LOSE!!!!!\n *********** \n\nThe Evil Destructor has been Slain by the Noble Heap Hero!");
                }
                else
                {
                    Console.WriteLine("\n\n ******** \n YOU ARE VICTORIOUS!!!!!\n *********** \n\nThe Evil Destructor has SLAIN THE HERO AND DESTRUCTS MORE OBJECTS");
                }
                Console.ReadLine();
                Console.WriteLine("\nTHE FIGHT IS OVER!! \nPRESS ENTER TO CONTINUE");

                do //PLAY AGAIN SCREEN
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    
                    Console.WriteLine("\nWould you like to DESTRUCT some more???");
                    gameLoopInput = Console.ReadLine();

                    if (gameLoopInput != "y" && gameLoopInput != "n")
                    {
                        Console.WriteLine("Please enter a valid character: yield or n");
                    }
                } while (gameLoopInput != "y" && gameLoopInput != "n");


            }




        } while (gameLoopInput == "y");
    }

}

