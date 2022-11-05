using System;

namespace RockPaperScissors
{
    public class Game
    {
        public object Play(PlayerMoves playerMove, PlayerMoves opponentMove)
        {
            if (playerMove == PlayerMoves.Paper && opponentMove == PlayerMoves.Rock)
                return Outcomes.PlayerWins;
            if (playerMove == PlayerMoves.Rock && opponentMove == PlayerMoves.Scissors)
                return Outcomes.PlayerWins;
            if (playerMove == PlayerMoves.Scissors && opponentMove == PlayerMoves.Paper)
                return Outcomes.PlayerWins;
            if (playerMove == opponentMove) return Outcomes.Tie;

                return Outcomes.PlayerLoses;
        }
    }

    public enum Outcomes
    {
        PlayerLoses,
        PlayerWins,
        Tie
    }

    public enum PlayerMoves
    {
        Paper,
        Rock,
        Scissors
    }

    //public enum opponentMove
    //{
    //    Paper,
    //    Rock,
    //    Scissors
    //}
}
