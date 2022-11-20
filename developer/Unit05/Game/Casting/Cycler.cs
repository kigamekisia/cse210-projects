using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A long limbless reptile.</para>
    /// <para>The responsibility of Cycler is to move itself.</para>
    /// </summary>
    public class Cycler : Actor
    {
        private List<Actor> segments = new List<Actor>();
        private bool isGameOver = false;
        private int x = Constants.MAX_X / 2;
        private int y = Constants.MAX_Y / 2;
        private Color _color;

        /// <summary>
        /// Constructs a new instance of a Cycler.
        /// </summary>
        public Cycler(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            _color = color;
            PrepareBody();
        }

        /// <summary>
        /// Gets the the status of the game.
        /// </summary>
        /// <returns>The state of isGameOver.</returns>
        public bool GetIsGameOver()
        {
            return isGameOver;
        }

        /// <summary>
        /// Sets the isGameOver variable.
        /// </summary>
        public void SetIsGameOver(bool gameOver)
        {
            isGameOver = gameOver;
        }

        /// <summary>
        /// Gets the cycler's body segments.
        /// </summary>
        /// <returns>The body segments in a List.</returns>
        public List<Actor> GetBody()
        {
            return new List<Actor>(segments.Skip(1).ToArray());
        }

        /// <summary>
        /// Gets the cycler's head segment.
        /// </summary>
        /// <returns>The head segment as an instance of Actor.</returns>
        public Actor GetHead()
        {
            return segments[0];
        }

        /// <summary>
        /// Gets the cycler's segments (including the head).
        /// </summary>
        /// <returns>A list of cycler segments as instances of Actors.</returns>
        public List<Actor> GetSegments()
        {
            return segments;
        }

        /// <summary>
        /// Grows the cycler's tail by the given number of segments.
        /// </summary>
        /// <param name="numberOfSegments">The number of segments to grow.</param>
        public void GrowTail(int numberOfSegments)
        {
            for (int i = 0; i < numberOfSegments; i++)
            {
                Actor tail = segments.Last<Actor>();
                Point velocity = tail.GetVelocity();
                Point offset = velocity.Reverse();
                Point position = tail.GetPosition().Add(offset);

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText("#");
                segment.SetColor(_color);
                segments.Add(segment);

                if (isGameOver)
                {
                    segment.SetColor(Constants.WHITE);
                }
            }
        }

        /// <inheritdoc/>
        public override void MoveNext()
        {
            GrowTail(1);
            foreach (Actor segment in segments)
            {
                segment.MoveNext();
            }

            for (int i = segments.Count - 1; i > 0; i--)
            {
                Actor trailing = segments[i];
                Actor previous = segments[i - 1];
                Point velocity = previous.GetVelocity();
                trailing.SetVelocity(velocity);
            }
        }

        /// <summary>
        /// Turns the head of the cycler in the given direction.
        /// </summary>
        /// <param name="velocity">The given direction.</param>
        public void TurnHead(Point direction)
        {
            segments[0].SetVelocity(direction);
        }

        /// <summary>
        /// Prepares the cycler body for moving.
        /// </summary>
        private void PrepareBody()
        {
            for (int i = 0; i < Constants.SNAKE_LENGTH; i++)
            {
                Point position = new Point(x - i * Constants.CELL_SIZE, y);
                Point velocity = new Point(1 * Constants.CELL_SIZE , 0);
                string text = i == 0 ? "8" : "#";
                Color color = i == 0 ? Constants.YELLOW : _color;

                Actor segment = new Actor();
                segment.SetPosition(position);
                segment.SetVelocity(velocity);
                segment.SetText(text);
                segment.SetColor(color);
                segments.Add(segment);
            }
        }
    }
}