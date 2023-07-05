public struct CheckersPiece
{
    public int ID { get; init; }
    public Players Player { get; init; }
    public CheckersPieceType Type { get; set; }

    public int Row { get; init; }
    public int Column { get; init; }

}