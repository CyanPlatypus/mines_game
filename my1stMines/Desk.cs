using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace my1stMines
{
    class Desk
    {
        int minesNumber;
        int size; 
        int[,] minesMap; // -1 mine, 1-8 numbers, 0 empty
        int[,] openedMap; // 0 not opened, 1 opened, 2 flag

        public Desk(int size, int minesNumber) 
        {
            this.minesNumber = minesNumber;
            this.size = size;

            minesMap = new int[size, size];
            openedMap = new int[size, size];

            DoEverythingWithBothMaps(minesNumber); //fill both maps with zeros and create mines
        }

        void DoEverythingWithBothMaps(int minesNumb) 
        {
            ConstAndFunctions.FillArrWithZeros(ref minesMap);
            ConstAndFunctions.FillArrWithZeros(ref openedMap);

            PlaceMines(minesNumb);
            PlaceNumbers();
        }

        void PlaceMines(int minesNumb)
        {
             Random myNiceRand = new Random();
            for (int i = 0; i < minesNumb; i++) 
            {
                int a, b; 
                do 
                {
                    a = myNiceRand.Next(0, size);
                    b = myNiceRand.Next(0, size);
                } while (minesMap[a,b]==-1);

                minesMap[a, b] = -1;
            }
        }

        void PlaceNumbers()
        {
            //there's another better way for shure
            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j < size; j++) 
                {
                    if (minesMap[i, j] == -1) 
                    {
                        // :(
                        AddIf(i - 1, j - 1);
                        AddIf(i - 1, j);
                        AddIf(i - 1, j + 1);
                        AddIf(i, j - 1);
                        AddIf(i, j + 1);
                        AddIf(i + 1, j - 1);
                        AddIf(i + 1, j);
                        AddIf(i + 1, j + 1);
                    }
                }
            }
        }

        void AddIf(int a, int b) 
        {
            if (Exist(a,b)) 
            { minesMap[a, b]++; }
        }

        bool Exist(int a, int b)
        {
            if ((a >= 0) && (a < size) && (b >= 0) && (b < size) && (minesMap[a, b] != -1))
                return true;
            else return false;
        }

        public void DrawMe(Graphics drawHere, int w, int h, string colorScheme) 
        {
            ConstAndFunctions.DrawDesk(minesMap, openedMap, drawHere, w, h, colorScheme);
        }

        public void InterectWithCell(int x, int y, char buttonPressed) //when lmb or rmb is pressed
        {
            ConstAndFunctions.FindCellWithXY(ref x, ref y);
            if ((x < 0) || (y < 0) || (x >= size) || (y >= size)) return; //if not a cell was clicked
            if (buttonPressed == 'r')  //if rmb was pressed (we should place a flag)
            {
                switch (openedMap[y, x])
                {
                    case 0: { //flag was not there
                        if (FlagsLeft()>0)
                        openedMap[y, x] = 2; 
                        break; }
                    case 2: { openedMap[y, x] = 0; break; } //flag was there
                }
            }
            if (buttonPressed == 'l') { OpenCell(y,x); } //if lmb was pressed
        }

        void OpenCell(int x, int y) 
        {
            if (openedMap[x, y] == 1) return; //if it was already opened 
            else openedMap[x, y] = 1;

            if (minesMap[x, y] == 0) 
            {
                //rewrite it:
                if (Exist(x - 1, y - 1)) OpenCell(x - 1, y - 1);
                if (Exist(x - 1, y)) OpenCell(x - 1, y);
                if (Exist(x - 1, y + 1)) OpenCell(x - 1, y + 1);
                if (Exist(x, y - 1)) OpenCell(x, y - 1);
                if (Exist(x, y + 1)) OpenCell(x, y + 1);
                if (Exist(x + 1, y - 1)) OpenCell(x + 1, y - 1);
                if (Exist(x + 1, y)) OpenCell(x + 1, y);
                if (Exist(x + 1, y + 1)) OpenCell(x + 1, y + 1);
            }
        }

        public int CheckWinLose() 
        {
            int openedCellsWithoutMines = 0;
            int minesNotFound = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((minesMap[i, j] == -1) && (openedMap[i,j] == 1)) return -1;
                    if ((minesMap[i, j] >= 0) && (openedMap[i, j] == 1)) openedCellsWithoutMines++;
                    if ((minesMap[i, j] == -1) && (openedMap[i, j] == 0) || (openedMap[i, j] == 2)) minesNotFound++;
                }
            }
            if ((minesNotFound == minesNumber) && (openedCellsWithoutMines == (size * size - minesNumber))) return 1;
            return 0;
        }

        public int FlagsLeft() 
        {
            int flagsPlaced = 0;
            foreach (int cell in openedMap )
            {
                if (cell == 2) flagsPlaced++;
            }
            return minesNumber - flagsPlaced; 
        }
    }
}
