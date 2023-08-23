using System;

namespace GameRating
{
    // Игрок.
    public class Player
    {
        private string nickname;

        private GameQueue queue;

        private Game currentGame;

        public event Action<GameResult> OnGameCompleted;

        // Псевдоним игрока.
        public string Nickname => nickname;

        // Возвращает первую игру игрока в очереди.
        public Game GetFirstGame() => queue.Dequeue();

        // Запускает первую игру в очереди.
        public void PlayFirstGame()
        {
            var game = GetFirstGame();
            game.Start();
            currentGame = game;
        }

        // Останавливает игру и вызывает событие со счётом, на которое должен подписаться рейтинг игр
        // или иной класс, который добавит результат в этот рейтинг.
        public void StopGame()
        {
            if (currentGame == null)
                return;
            currentGame.Stop();

            GameResult result = currentGame.GetResult();
            OnGameCompleted?.Invoke(result);
        }
    }
}
