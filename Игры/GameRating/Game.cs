
namespace GameRating
{
    // Базовый класс игр.
    public abstract class Game
    {
        private string name;

        // Название игры.
        public string Name => name;

        // Начало игры.
        public abstract void Start();

        // Остановка игры.
        public abstract void Stop();

        // Результат игры (кол-во очков).
        public abstract GameResult GetResult();
    }
}
