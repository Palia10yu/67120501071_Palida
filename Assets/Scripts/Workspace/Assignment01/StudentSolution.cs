using System.Collections;
using System.Collections.Generic;
using System.Text;
using AssignmentSystem.Services;
using UnityEngine;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment
{
    public class StudentSolution : MonoBehaviour, IAssignment
    {

        #region Lecture

        public void LCT01_SyntaxArray()
        {
            string[] ironManSuit = new string[2];
            ironManSuit[0] = "Mark I";
            ironManSuit[1] = "Mark II";
            string tonyStarkWear = ironManSuit[0];
            Debug.Log($"TonyStark Wear: {tonyStarkWear}");
            Debug.Log($"Room size: {ironManSuit.Length}");
            Debug.Log(ironManSuit[0]);
            Debug.Log(ironManSuit[1]);
        }

        public void LCT02_ArrayInitialize()
        {
            string[] SpiderManSuits = new string[3];
            SpiderManSuits[0] = "Classic SpiderMan";
            SpiderManSuits[1] = "Black Suit";
            SpiderManSuits[2] = "Iron Spider Suit";
            string[] BatManSuits = new string[2];
            BatManSuits[0] = "Classic BatMan";
            BatManSuits[1] = "White bat";
            int SpiderMan = SpiderManSuits.Length;
            int BatMan = BatManSuits.Length;
            Debug.Log($"Room size: {SpiderMan}");
            for (int i = 0; i < SpiderMan; i++)
            {
                Debug.Log(SpiderManSuits[i]);
            }
            Debug.Log($"Room size: {BatMan}");
            for (int i = 0; i < BatMan; i++)
            {
                Debug.Log(BatManSuits[i]);
            }
        }

        public void LCT03_SyntaxLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Debug.Log("<10 : " + i);
            }
            Debug.Log("===");
            for (int i = 1; i <= 10; i++)
            {
                Debug.Log("<=10 : " + i);
            }
        }

        public void LCT04_LoopAndArray(string[] ironManSuitNames)
        {
            for (int i = 0; i < ironManSuitNames.Length; i++)
            {
                Debug.Log(ironManSuitNames[i]);
            }
            Debug.Log("===");
            for (int i = 0; i < ironManSuitNames.Length; i += 2)
            {
                Debug.Log(ironManSuitNames[i]);
            }
        }

        public void LCT05_Syntax2DArray()
        {
            //[roll,colum]
            int[,] my2DArray = new int[2, 2]
            {
                {1,2},//{[0,0],[0,1]}
                {3,4}//{[1,0],[1,1]}
            };
            Debug.Log("my2DArray[0, 0] = " + my2DArray[0, 0]);
            Debug.Log("my2DArray[0, 1] = " + my2DArray[0, 1]);
            Debug.Log("my2DArray[1, 0] = " + my2DArray[1, 0]);
            Debug.Log("my2DArray[1, 1] = " + my2DArray[1, 1]);

            my2DArray[0, 1] = 6;
            my2DArray[1, 1] = 8;

            Debug.Log("After change value");
            Debug.Log("my2DArray[0, 1] = " + my2DArray[0, 1]);
            Debug.Log("my2DArray[1, 1] = " + my2DArray[1, 1]);
        }

        public void LCT06_SizeOf2DArray(int[,] my2DArray)
        {
            int row = my2DArray.GetLength(0);
            int column = my2DArray.GetLength(1);
            Debug.Log($"rows = {row}");
            Debug.Log($"cols = {column}");
        }

        public void LCT07_SyntaxNestedLoop(int columns, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                string row = "";
                for (int j = 0; j < columns; j++)
                {
                    row += "*";
                }
                Debug.Log(row);
            }
        }
        #endregion

        #region Assignment

        public void AS01_RandomItemDrop(GameObject[] items)
        {
            int random = Random.Range(0, items.Length);
            GameObject selectedItem = items[random];
            Instantiate(selectedItem);
            Debug.Log($"Got item: {selectedItem.name}");
        }

        public void AS02_NestedLoopForCreate2DMap(GameObject[] floorTiles, int columns, int rows)
        {
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int randomTile = Random.Range(0, floorTiles.Length);
                    GameObject Tile = Instantiate(floorTiles[randomTile], new Vector2(x, y), Quaternion.identity);
                    Tile.name = $"[{x}:{y}]";
                    Debug.Log(Tile.name);
                }
            }
        }

        public void AS03_NestedLoopForMakingWallAround(GameObject wall, int columns, int rows)
        {
            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (x == 0 || x == columns - 1 || y == 0 || y == rows - 1)
                    {
                        GameObject tile = Instantiate(wall, new Vector2(x, y), Quaternion.identity);
                        tile.name = $"[{x}:{y}]";
                    }
                }
            }
        }

        public void AS04_AttackEnemy(int[] enemyHP, int damage, int target)
        {
            enemyHP[0] = Mathf.Max(0, enemyHP[0] - damage);
            Debug.Log($"FirstEnemy hp :{enemyHP[0]}");

            enemyHP[enemyHP.Length - 1] = Mathf.Max(0, enemyHP[enemyHP.Length - 1] - damage);
            Debug.Log($"LastEnemy hp :{enemyHP[enemyHP.Length - 1]}");

            enemyHP[target] = Mathf.Max(0, enemyHP[target] - damage);
            Debug.Log($"TargetEnemy {target} hp :{enemyHP[target]}");
        }

        public void AS05_DynamicIterationLoop(int n)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                Debug.Log(i);
            }
        }

        public void AS06_WhileLoopAndArray(string[] ironManSuitNames)
        {
            int i = 0;
            while (i < ironManSuitNames.Length)
            {
                Debug.Log(ironManSuitNames[i]);
                i++;
            }

            Debug.Log("===");

            i = 0;
            while (i < ironManSuitNames.Length)
            {
                Debug.Log(ironManSuitNames[i]);
                i += 2;
            }
        }

        public void AS07_HealTargetAtIndex(int[] heroHPs, int heal, int targetIndex)
        {
            heroHPs[0] = heroHPs[0] + heal;
            Debug.Log($"FirstHero hp :{heroHPs[0]}");

            heroHPs[heroHPs.Length - 1] = heroHPs[heroHPs.Length - 1] + heal;
            Debug.Log($"LastHero hp :{heroHPs[heroHPs.Length - 1]}");

            heroHPs[targetIndex] = heroHPs[targetIndex] + heal;
            Debug.Log($"TargetHero {targetIndex} hp :{heroHPs[targetIndex]}");
        }

        public void AS08_RandomPickingDialogue(string[] dialogues)
        {
            int random = UnityEngine.Random.Range(0, dialogues.Length);
            Debug.Log(dialogues[random]);
        }

        public void AS09_MultiplicationTable(int n)
        {
            for (int i = 1; i <= 12; i++)
            {
                Debug.Log($"{n}x{i}={n * i}");
            }
        }

        public void AS10_FindSummationFromZeroToNUsingWhileLoop(int n)
        {
            int sum = 0;
            int i = 0;
            while (i <= n)
            {
                sum += i;
                i++;
            }
            Debug.Log($"ผลรวมของ n จาก 0 ถึง {n} คือ {sum}");
        }

        public void AS11_SpawnEnemies(int[] enemyHPs, GameObject enemyPrefab)
        {
            for (int i = 1; i <= enemyHPs.Length; i++)
            {
                GameObject enemy = Instantiate(enemyPrefab, new Vector2(i + 1, 0), Quaternion.identity);
                Debug.Log($"new enemy at position x = {i}");
            }
        }

        public IEnumerator AS12_CountTime(float CountTime)
        {
            float timer = 0.0f;
            if (CountTime <= 0)
            {
                Debug.Log("End timer : 0");
                yield break;
            }
            while (timer < CountTime)
            {

                timer += 0.1f;

                if (timer > CountTime) timer = CountTime;

                Debug.Log($"timer : {timer.ToString("F2")}");

                yield return null;
                if (timer >= CountTime) break;
            }
            string endFormat = (CountTime == 1f || CountTime == 0f) ? CountTime.ToString("G") : CountTime.ToString("F2");
            Debug.Log($"End timer : {endFormat}");
        }

        public void AS13_SumOfNumbersInRow(int[,] matrix, int row)
        {
            int sum = 0;
            int col = matrix.GetLength(1);
            for (int i = 0; i < col; i++)
            {
                sum += matrix[row, i];
            }
            Debug.Log(sum);
        }

        public void AS14_SumOfNumbersInColumn(int[,] matrix, int column)
        {
            int sum = 0;
            int row = matrix.GetLength(0);
            for (int i = 0; i < row; i++)
            {
                sum += matrix[i, column];
            }
            Debug.Log(sum);
        }

        public void AS15_MakeTheTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                string row = "";
                for (int j = 1; j <= i; j++)
                {
                    row += "*";
                }
                Debug.Log(row);
            }
        }

        public void AS16_MultiplicationTableOf_2_3_and_4()
        {
            for (int i = 1; i <= 12; i++)
            {
                string row = "";
                for (int j = 2; j <= 4; j++)
                {
                    row += $"{j} x {i} = {j * i}";
                    if (j < 4)
                    {
                        row += "\t";
                    }
                }
                Debug.Log(row);
            }
        }

        #endregion

        #region Extra assignment

        public void EX_01_TicTacToeGame_TurnPlay(string[,] board, string playerTurn, int row, int column)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "_" || string.IsNullOrEmpty(board[i, j]))
                    {
                        board[i, j] = " ";
                    }
                }
            }

            bool isInvalidMove = row < 0 || row > 2 || column < 0 || column > 2 || board[row, column] == "X" || board[row, column] == "O";

            if (isInvalidMove)
            {
                PrintBoard(board);
                Debug.Log(">> Invalid move");
                return;
            }

            board[row, column] = playerTurn;

            PrintBoard(board);

            bool isWin = false;

            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == playerTurn && board[i, 1] == playerTurn && board[i, 2] == playerTurn) isWin = true;
                if (board[0, i] == playerTurn && board[1, i] == playerTurn && board[2, i] == playerTurn) isWin = true;
            }

            if (board[0, 0] == playerTurn && board[1, 1] == playerTurn && board[2, 2] == playerTurn) isWin = true;
            if (board[0, 2] == playerTurn && board[1, 1] == playerTurn && board[2, 0] == playerTurn) isWin = true;

            if (isWin)
            {
                Debug.Log(">> " + playerTurn + " wins!");
                return;
            }

            bool isDraw = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != "X" && board[i, j] != "O")
                    {
                        isDraw = false;
                        break;
                    }
                }
            }

            if (isDraw)
            {
                Debug.Log(">> Draw");
            }
            else
            {
                Debug.Log(">> Continue");
            }
        }

        private void PrintBoard(string[,] board)
        {
            StringBuilder sb = new();
            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine("-------------");
                sb.AppendLine("| " + board[i, 0] + " | " + board[i, 1] + " | " + board[i, 2] + " |");
            }
            sb.AppendLine("-------------");
            Debug.Log(sb.ToString());
        }
        #endregion
    }

}
