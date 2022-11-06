namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a score about itself.
    /// </para>
    /// </summary>
    public class Artifact : Actor
    {
        private int _score = 10;

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Artifact()
        {
        }

        /// <summary>
        /// Gets the artifact's score.
        /// </summary>
        /// <returns>The score.</returns>
        public int GetScore()
        {
            return _score;
        }

        /// <summary>
        /// Sets the artifact's score to the given value.
        /// </summary>
        /// <param name="score">The given score.</param>
        public void SetScore(int score)
        {
            this._score = score;
        }
    }
}