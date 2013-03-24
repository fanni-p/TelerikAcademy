using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startRow; i < WorldRows; i++) // Task 1  - Game Walls
            {
                IndestructibleBlock leftSide = new IndestructibleBlock(new MatrixCoords(i, startRow-2));
                engine.AddObject(leftSide);
            }

            for (int i = startRow; i < WorldRows; i++)
            {
                IndestructibleBlock rightSide = new IndestructibleBlock(new MatrixCoords(i, endCol));
                engine.AddObject(rightSide);
            }

            for (int i = 1; i < WorldCols - 1; i++)
            {
                IndestructibleBlock upSide = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));
                engine.AddObject(upSide);
            }

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock;
                if (i == 7)
                {
                    currBlock = new ExplodingBlock(new MatrixCoords(startRow, i)); // Testing ExplodingBlock
                }
                else if (i == endCol - 3)
                {
                    currBlock = new GiftBlock(new MatrixCoords(startRow, i)); // Testing GiftBlock
                }
                else
                {
                    currBlock = new Block(new MatrixCoords(startRow, i));
                }
                engine.AddObject(currBlock);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theBall);

             //Task7 - Test MeteoriteBall
            //Ball theMeteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theMeteoriteBall);

             //Task9 - Test UnstoppableBall
            //Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theUnstopableBall);
            //for (int i = 2; i < WorldCols/2; i+=4)
            //{
            //    engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            //}


            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);
            engine.AddObject(theRacket);
            

            ShootingRacket sr = new ShootingRacket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);// 13. shooting racket
            engine.AddObject(sr);

        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            

            //Engine gameEngine = new Engine(renderer, keyboard);
            EngineShootRacket gameEngine = new EngineShootRacket(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            //Task13
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };
            

            Initialize(gameEngine);


            gameEngine.Run();
        }
    }
}
