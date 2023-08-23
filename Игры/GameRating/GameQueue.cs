using System;
using System.Collections.Generic;

namespace GameRating
{
    // Очередь игр.
    public class GameQueue
    {
        private int count;

        private Queue<Game> queue = new Queue<Game>();

        // Возвращает счётчик игр
        public int Count => count;

        // Добавляет игру в очередь и увеличивает счётчик игр.
        public void AddGame(Game game)
        {
            queue.Enqueue(game);
            count++;
        }

        // Возвращает первую игру в очереди и уменьшает счётчик игр.
        public Game Dequeue()
        {
            if (count == 0)
                throw new Exception("Коллекция игр уже пуста.");
            count--;
            return queue.Dequeue();
        }

        // Возвращает первую игру в очереди, не изменяя очереди.
        public Game Peek() => queue.Peek();
    }
}
