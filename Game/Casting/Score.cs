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
        private int points1 = 0;
        private int points2 = 0;

        /// <summary>
        /// Constructs a new instance of Score.
        /// </summary>
        public Score()
        {
            AddPoints1(0);
            AddPoints2(0);
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints1(int points1)
        {
            this.points1 += points1;
            SetText($"{this.points1}");
        }

        public void AddPoints2(int points2)
        {
            this.points2 += points2;
            SetText($"{this.points2}");
        }
    }
}