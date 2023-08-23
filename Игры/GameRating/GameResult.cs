using System;

namespace GameRating
{
    // Базовый класс результата игры.
    public abstract class GameResult : IComparable<GameResult>
    {
        private Game game;
        private Player player;

        // Игра, которой принадлежит результат.
        public Game Game => game;
        // Игрок, которому принадлежит результат.
        public Player Player => player;

        // Сравнение результата одной игры с другим для построения рейтинга.
        public abstract int CompareTo(GameResult other);
    }
}
