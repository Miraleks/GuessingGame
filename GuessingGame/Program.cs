﻿using GuessingGame.BL;

namespace GuessingGame
{
    /*
    Программа рандомно генерирует число, пользователь должен угадать это число. 
    При каждом вводе числа программа пишет больше или меньше отгадываемого. 
    Кол-во попыток отгадывания и диапазон чисел должен задаваться из настроек.
    В отчёте написать, что именно сделано по каждому принципу.    */

    class Program
    {
        static void Main(string[] args)
        {
            Game.StartGame();
        }



    }
}
