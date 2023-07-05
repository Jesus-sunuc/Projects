namespace CheckersTest;

public class BoardTest
{
    [Test]
    public void boardTest()
    {
        var board = new Board();
        var actualOutput = board.ToString();
        var expectedOutput = @"
  +-+-+-+-+-+-+-+-+
1 | |X| |X| |X| |X|
  +-+-+-+-+-+-+-+-+
2 |X| |X| |X| |X| |
  +-+-+-+-+-+-+-+-+
3 | |X| |X| |X| |X|
  +-+-+-+-+-+-+-+-+
4 | | | | | | | | |
  +-+-+-+-+-+-+-+-+
5 | | | | | | | | |
  +-+-+-+-+-+-+-+-+
6 |Y| |Y| |Y| |Y| |
  +-+-+-+-+-+-+-+-+
7 | |Y| |Y| |Y| |Y|
  +-+-+-+-+-+-+-+-+
8 |Y| |Y| |Y| |Y| |
  +-+-+-+-+-+-+-+-+
   a b c d e f g h
";
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}