public class Board
{
    public static readonly int MaxRowCount = 8;
    public static readonly int MaxColCount = 8;
    public List<CheckersPiece> board { get; init; }
    public Board()
    {
        board = new List<CheckersPiece>(){
            new CheckersPiece() { ID = 0, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 0, Column = 1 },
            new CheckersPiece() { ID = 1, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 0, Column = 3 },
            new CheckersPiece() { ID = 2, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 0, Column = 5 },
            new CheckersPiece() { ID = 3, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 0, Column = 7 },
            new CheckersPiece() { ID = 4, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 1, Column = 0 },
            new CheckersPiece() { ID = 5, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 1, Column = 2 },
            new CheckersPiece() { ID = 6, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 1, Column = 4 },
            new CheckersPiece() { ID = 7, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 1, Column = 6 },
            new CheckersPiece() { ID = 8, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 2, Column = 1 },
            new CheckersPiece() { ID = 9, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 2, Column = 3 },
            new CheckersPiece() { ID = 10, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 2, Column = 5 },
            new CheckersPiece() { ID = 11, Player = Players.Red, Type = CheckersPieceType.Normal, Row = 2, Column = 7 },
            new CheckersPiece() { ID = 12, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 5, Column = 0 },
            new CheckersPiece() { ID = 13, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 5, Column = 2 },
            new CheckersPiece() { ID = 14, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 5, Column = 4 },
            new CheckersPiece() { ID = 15, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 5, Column = 6 },
            new CheckersPiece() { ID = 16, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 6, Column = 1 },
            new CheckersPiece() { ID = 17, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 6, Column = 3 },
            new CheckersPiece() { ID = 18, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 6, Column = 5 },
            new CheckersPiece() { ID = 19, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 6, Column = 7 },
            new CheckersPiece() { ID = 20, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 7, Column = 0 },
            new CheckersPiece() { ID = 21, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 7, Column = 2 },
            new CheckersPiece() { ID = 22, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 7, Column = 4 },
            new CheckersPiece() { ID = 23, Player = Players.Black, Type = CheckersPieceType.Normal, Row = 7, Column = 6 },
        };
    }

public override string ToString()
{
    var output = "\r\n  +-+-+-+-+-+-+-+-+\r\n";
    for (var i = 0; i < MaxRowCount; i++)
    {
        var thisRow = $"{i + 1} |";
        for (var j = 0; j < MaxColCount; j++)
        {
            var piece = GetPiece(i, j);
            if (piece.ID == -1)
            {
                thisRow += " |";
            }
            else
            {
                if (piece.Player == Players.Black)
                {
                    thisRow += "Y|";
                }
                else
                {
                    thisRow += "X|";
                }
            }
        }

        output += thisRow;
        output += "\r\n  +-+-+-+-+-+-+-+-+\r\n";
    }
    output += "   a b c d e f g h\r\n";
    return output;
}

private CheckersPiece GetPiece(int row, int col)
{
    foreach (var piece in board)
    {
        if (piece.Row == row && piece.Column == col)
        {
            return piece;
        }
    }
    return new CheckersPiece() { ID = -1 };
}

}