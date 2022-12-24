using System.Collections.Generic;


namespace GwentClient.Models
{
    public static class CardLibrary
    {
        public static Dictionary<int, Card> Cards { get; } =
            new()
            {
                {1, new Card(1, Role.Melee, 3, "Геральт")},
                {2, new Card(2, Role.Shooter, 2, "Лучник")}
            };
    }
}
