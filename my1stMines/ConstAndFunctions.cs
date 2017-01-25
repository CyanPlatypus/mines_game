using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace my1stMines
{
    class ConstAndFunctions
    {
        public static int ten = 10;

        public static double indentPersantage = 0.05;
        public static int lilIndent = 3;
        public static int cellSize;
        public static int topIndent;
        public static int leftIndent;

        public static Color closedCellColor;
        public static Color minesColor;
        public static Color planeCellColor;
        public static Color numberCellColor;
        public static Color numberColor;
        public static Color flagColor;

        static Pen myPen = new Pen(Color.Black, 1);
        static SolidBrush myBrush = new SolidBrush(Color.LightGray);
        static Font myFont; 

        public static void FillArrWithZeros(ref int[,] arr) 
        {
            //find a better way to to caculate the number of rows&cols
            for (int i = 0; i < (int)Math.Sqrt(arr.Length); i++) 
            {
                for (int j = 0; j < (int)Math.Sqrt(arr.Length); j++) 
                {
                    arr[i, j] = 0;
                }
            }
        }

        public static void DrawDesk(int[,] field, int[,] mask, Graphics drawHere, int fieldW, int fieldH, string colorScheme) 
        {
            SetColorScheme(colorScheme);
            //too tired

            //set sizes of the sell, left and top indents
            if (fieldH <= fieldW)
            {
                topIndent = (int)(fieldH * indentPersantage);
                cellSize = (int)((fieldH - 2 * topIndent - lilIndent * (Math.Sqrt(field.Length) - 1)) / Math.Sqrt(field.Length));
                leftIndent = (int)((fieldW - lilIndent * (Math.Sqrt(field.Length) - 1) - (cellSize * Math.Sqrt(field.Length))) / 2);
            }
            else 
            {
                leftIndent = (int)(fieldW * indentPersantage);
                cellSize = (int)((fieldW - 2 * leftIndent - lilIndent * (Math.Sqrt(field.Length) - 1)) / Math.Sqrt(field.Length));
                topIndent = (int)((fieldH - lilIndent * (Math.Sqrt(field.Length) - 1) - (cellSize * Math.Sqrt(field.Length))) / 2);
            }
            //drawing cells
            int rememberLeftIndent = leftIndent;
            int rememberTopIndent = topIndent;
            for (int i=0; i < (int)Math.Sqrt(field.Length); i++)
            {
                for (int j = 0; j < (int)Math.Sqrt(field.Length); j++) 
                {
                    switch (mask[i, j])
                    {
                        case 0: {
                            myBrush.Color = closedCellColor;
                            drawHere.FillRectangle(myBrush, leftIndent, topIndent, cellSize, cellSize);
                            break;
                        }
                        case 1: {
                            //code goes here
                            switch (field[i,j])
                            {
                                case 0: {
                                    myBrush.Color = planeCellColor;
                                    drawHere.FillRectangle(myBrush, leftIndent, topIndent, cellSize, cellSize);
                                    break;
                                }
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                case 7:
                                case 8:{
                                    myBrush.Color = numberCellColor;
                                    drawHere.FillRectangle(myBrush, leftIndent, topIndent, cellSize, cellSize);

                                    string stringData = Convert.ToString(field[i, j]);
                                    myFont = new Font("Courier New", cellSize / 2);
                                    SizeF size = drawHere.MeasureString(stringData, myFont);
                                    myBrush.Color = numberColor;
                                    drawHere.DrawString(stringData, myFont, myBrush, leftIndent + size.Width / 4, topIndent + size.Height / 4);
                                    break; 
                                }
                                case -1: {
                                    myBrush.Color = minesColor;
                                    drawHere.FillRectangle(myBrush, leftIndent, topIndent, cellSize, cellSize);
                                    break;
                                }
                            }
                            break;
                        }
                        case 2: {
                            myBrush.Color=flagColor;
                            drawHere.FillRectangle(myBrush, leftIndent, topIndent, cellSize, cellSize);
                            break;
                        }
                    }

                    leftIndent =leftIndent + cellSize + lilIndent;
                }
                topIndent =topIndent + cellSize + lilIndent;
                leftIndent = rememberLeftIndent;
            }
            topIndent = rememberTopIndent;
        }

        static void SetColorScheme(string colorScheme) 
        {
            switch (colorScheme) 
            {
                case "DarkBlue": { SetColorSchemeParam(Color.Gray, Color.Black, Color.White, Color.MidnightBlue, Color.White, Color.SteelBlue); break; }
                case "Purple": { SetColorSchemeParam(Color.White, Color.Black, Color.Purple, Color.DarkViolet, Color.White, Color.Gold); break; }
                case "GrayAndOrange": { SetColorSchemeParam(Color.DimGray, Color.DarkOrange, Color.White, Color.White, Color.Black, Color.Yellow); break; }
            }
        }

        static void SetColorSchemeParam(Color clCell, Color mine, Color plCell, Color numCell, Color num, Color flag) 
        {
            closedCellColor = clCell;
            minesColor = mine;
            planeCellColor = plCell;
            numberCellColor = numCell;
            numberColor = num;
            flagColor = flag;
        }

        public static void FindCellWithXY(ref int x, ref int y) 
        {
            if ((x - leftIndent < 0) || (y - topIndent < 0)) { x = -1; y = -1; return; }
            x = (int)((x - leftIndent) / (cellSize + lilIndent)); // % ?
            y = (int)((y - topIndent) / (cellSize + lilIndent));
        }
    }
}
