using System;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>Keeps score.</para>
    /// <para>
    /// The responsibility of Score is to add points when the snake eats food.
    /// </para>
    /// </summary>
    public class Score : Actor
    {
        private int points = 0;

        /// <summary>
        /// Constructs a new instance of Score.
        /// </summary>
        public Score()
        {
            AddPoints(0);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this.points += points;
            SetText($"Player One: {this.points}");
        }
    }
}