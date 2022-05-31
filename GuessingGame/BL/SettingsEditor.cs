using GuessingGame.Configurations;
using System;

namespace GuessingGame.BL
{
    class SettingsEditor
    {
        public static Settings UiSettingsEditor()
        {
            Settings settings = new Settings();

            Console.WriteLine("Введите количество попыток:");
            settings.tryValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значения диапазона чисел.");
            Console.WriteLine("От:");
            settings.fromValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("До:");
            settings.toValue = Convert.ToInt32(Console.ReadLine());

            return settings;

        }

    }
}
