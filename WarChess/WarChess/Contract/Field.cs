namespace WarChess.Contract
{
	public class Field
	{
		public Field(short x, short y)
		{
			X = x;
			Y = y;
		}

		public short X { get; set; } 
		public short Y { get; set; } 
	}
}