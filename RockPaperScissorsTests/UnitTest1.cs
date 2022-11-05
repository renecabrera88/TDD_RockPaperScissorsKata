using NUnit.Framework;
using System;
using RockPaperScissors;


namespace RockPaperScissorsTests
{
    //1. You are mot allowed to write any production code unless it is to make a failing unit testa pass.
    //2. You are not allowed to write any more a unit test that is suffient to pass to fail, and
    //   failures are failures.
    //3. You are not allowed to write any more production code that is sufficient to pass the one failing
    //   unit test.

    //Red -> Green -> Reflect -> Refactor


    //Fake It Green Bar Pattern
    [TestFixture]
    public class GameTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        [TestFixture]
        public class Play
        {
            [TestFixture]
            public class PaperBeatsRock
            {
                [Test]
                public void Play_GivenPlayerPaper_OpponentRock_ShouldReturnPlayerWins()
                {
                    //arrange
                    var sut = CreateGame();
                    //Act
                    var play = sut.Play(PlayerMoves.Paper, PlayerMoves.Rock);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerWins, play);
                }

                [Test]
                public void Play_GivenPlayerRock_OpponentPaper_ShouldReturnPlayerLoses()
                {
                    //arrange
                    var sut = CreateGame();
                    //Act
                    var play = sut.Play(PlayerMoves.Rock, PlayerMoves.Paper);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerLoses, play);
                }

            }

            [TestCase(PlayerMoves.Rock, PlayerMoves.Paper, Outcomes.PlayerLoses)]
            [TestCase(PlayerMoves.Paper, PlayerMoves.Rock, Outcomes.PlayerWins)]
            public void Learning(PlayerMoves playerMoves, PlayerMoves opponentMove, Outcomes expected)
            {
                //arrange
                var sut = CreateGame();
                //Act
                var play = sut.Play(playerMoves, opponentMove);
                //Assert
                Assert.AreEqual(expected, play);
            }

            [TestFixture]
            public class ScissorsBeatsPaper
            {
                [Test]
                public void Play_GivenPlayerPaper_OpponentScissors_ShouldReturnPlayerLoses()
                {
                    //arrange
                    var sut = CreateGame();
                    //Act
                    var play = sut.Play(PlayerMoves.Paper, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerLoses, play);
                }

                [Test]
                public void Play_GivenPlayerScissors_OpponentPaper_ShouldReturnPlayerWins()
                {
                    //arrange
                    var sut = CreateGame();
                    //Act
                    var play = sut.Play(PlayerMoves.Scissors, PlayerMoves.Paper);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerWins, play);
                }
            }

            [TestFixture]
            public class RockBeatsScissor
            {
                [Test]
                public void Play_GivenPlayerRock_OpponentScissor_ShouldReturnPLayerWins()
                {
                    //arrange
                    var sut = CreateGame();
                    //Act
                    var play = sut.Play(PlayerMoves.Rock, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerWins, play);
                }

                [Test]
                public void Play_GivenPlayerScissors_OpponentRock_ShouldReturnPLayerLoses()
                {
                    //arrange
                    var sut = CreateGame();
                    //Act
                    var play = sut.Play(PlayerMoves.Scissors, PlayerMoves.Rock);
                    //Assert
                    Assert.AreEqual(Outcomes.PlayerLoses, play);
                }
            }

            [TestFixture]
            public class AnyNotBeatsAnur
            {
                [Test]
                public void Play_GivenPlayerScissors_OpponentScissors_ShouldReturnTie()
                {
                    //arrange
                    var sut = CreateGame();
                    //Act
                    var play = sut.Play(PlayerMoves.Scissors, PlayerMoves.Scissors);
                    //Assert
                    Assert.AreEqual(Outcomes.Tie, play);
                }
            }
        }

        private static Game CreateGame()
        {
            return new Game();
        }

    }


}