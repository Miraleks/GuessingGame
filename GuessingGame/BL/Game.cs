using GuessingGame.Configurations;
using System;

namespace GuessingGame.BL
{
    class Game
    {
        public static void StartGame()
        {
            var settings = new Settings();
            do
            {
                int choise = Menu();

                if (choise == 1)
                {
                    Console.Clear();

                    int number = Generator.GenerateNewNumber(settings.fromValue, settings.toValue);

                    UserGameDialog(number, settings);

                }
                else if (choise == 2)
                {
                    settings = SettingsEditor.UiSettingsEditor();
                }
                else if (choise == -1)
                {
                    Environment.Exit(0);
                }

            } while (true);
        }

        private static void UserGameDialog(int number, Settings settings)
        {
            string whoWin = "проиграли.";
            int numberGuessing;
            for (int i = 0; i < settings.tryValue; i++)
            {
                do
                {
                    Console.WriteLine($"Введите число в диапазоне от {settings.fromValue} до {settings.toValue}:");
                    Console.WriteLine($"загаданное число: {number}");
                    numberGuessing = Convert.ToInt32(Console.ReadLine());
                    if (numberGuessing < settings.fromValue || numberGuessing > settings.toValue)
                    {
                        Console.WriteLine("Вы ввели некорректное значение. Повторите ввод.");
                    }
                    else
                    {
                        break;
                    }

                } while (true);

                if (numberGuessing != number)
                {
                    Console.WriteLine("Вы ошиблись, попробуйте еще раз");
                }
                else
                {
                    Console.WriteLine("Вы угадали!");
                    whoWin = "выиграли. Вам понадобилось " + (i + 1) + " попыток.";
                    break;
                }

            }

            Console.WriteLine($"Игра окончена. Вы {whoWin}"); ;

        }

        private static int Menu()
        {
            Console.WriteLine("Выберите пункт меню:"); ;
            Console.WriteLine("1. Начать новую игру"); ;
            Console.WriteLine("2. Изменить настройки"); ;
            Console.WriteLine("3. Выход"); ;

            do
            {
                var choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    return 1;
                }
                else if (choice == 2)
                {
                    return 2;
                }
                else if (choice == 3)
                {
                    return -1;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение. Повторите, пожалуйста, свой выбор.");
                }

            } while (true);

        }
    }
}
