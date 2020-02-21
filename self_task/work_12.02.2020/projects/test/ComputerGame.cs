using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class ComputerGame
    {
        public string TitleOfGame { get; set; }
        public string CompanyDeveloper{ get; set; }
        public int YearPublisher{ get; set; }
        public string Genre { get; set; }



        public ComputerGame(string titleOfGame, string companyDeveloper, int yearPublisher, string genre)
        {
            TitleOfGame = titleOfGame;
            CompanyDeveloper = companyDeveloper;
            YearPublisher = yearPublisher;
            Genre = genre;

        }

        public override string ToString()
        {
            string resultString = $"Компютерная игра: \n" +
                                  $"Название игры: {TitleOfGame}, Компания разработчик: {CompanyDeveloper}, Год издания: {YearPublisher}, Жанр: {Genre} \n";
            return resultString;
        }
    }
}
