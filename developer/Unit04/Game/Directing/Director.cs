using System.Collections.Generic;
using Unit04.Game.Casting;
using Unit04.Game.Services;


namespace Unit04.Game.Directing
{
    /// <summary>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        public int score = 0;
        private KeyboardService _keyboardService = null;
        private VideoService _videoService = null;

        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>
        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this._keyboardService = keyboardService;
            this._videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            _videoService.OpenWindow();
            while (_videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            _videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot and artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            List<Actor> artifacts = cast.GetActors("gems");
            foreach (Actor actor in artifacts){
                Point artifactvelocity = _keyboardService.MoveArtifact();
                actor.SetVelocity(artifactvelocity);
                int maxX = _videoService.GetWidth();
                int maxY = _videoService.GetHeight();
                actor.MoveNext(maxX, maxY);
            }

            List<Actor> artifacts2 = cast.GetActors("rocks");
            foreach (Actor actor in artifacts2){
                Point artifactvelocity = _keyboardService.MoveArtifact();
                actor.SetVelocity(artifactvelocity);
                int maxX = _videoService.GetWidth();
                int maxY = _videoService.GetHeight();
                actor.MoveNext(maxX, maxY);
            }

            Actor robot = cast.GetFirstActor("robot");
            Point velocity = _keyboardService.GetDirection();
            robot.SetVelocity(velocity);     
        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Actor banner = cast.GetFirstActor("banner");
            Actor robot = cast.GetFirstActor("robot");
            List<Actor> artifacts = cast.GetActors("gems");
            List<Actor> artifacts2 = cast.GetActors("rocks");

            int maxX = _videoService.GetWidth();
            int maxY = _videoService.GetHeight();
            robot.MoveNext(maxX, maxY);

            foreach (Actor actor in artifacts)
            {
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {
                    {
                        Artifact artifact = (Artifact) actor;
                        score += artifact.GetScore();
                    }
                }
            }

            foreach (Actor actor in artifacts2)
            {
                if (robot.GetPosition().Equals(actor.GetPosition()))
                {
                    {
                        Artifact artifact = (Artifact) actor;
                        score -= artifact.GetScore();
                    }
                }
            }

            banner.SetText("Score: " + score);
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            _videoService.ClearBuffer();
            _videoService.DrawActors(actors);
            _videoService.FlushBuffer();
        }

        public int Updatescore(int score){
            int newscore = score + 10;
            return newscore;
        }

    }
}