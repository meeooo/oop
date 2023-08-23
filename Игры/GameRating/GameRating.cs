using System.Collections.Generic;

namespace GameRating
{
    // Рейтинг игр.
    public class GameRating
    {
        private List<GameResult> results = new List<GameResult>();

        // Добавить новый результат игры в список.
        public void AddResult(GameResult result)
        {
            for (int index = 0; index < results.Count; index++)
                if (results[index].CompareTo(result) > 0)
                {
                    results.Insert(index, result);
                    return;
                }
            results.Add(result);
        }

        // Возвращает самый высокий счёт в рейтинге.
        public GameResult GetTopResult()
        {
            return results[results.Count - 1];
        }

        // Возращает игру с самым высоким счётом в рейтинге.
        public Game GetTopGame()
        {
            return GetTopResult().Game;
        }
    }
}
