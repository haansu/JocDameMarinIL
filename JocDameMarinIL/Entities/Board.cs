using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocDameMarinIL {
	internal class Board {
		private int boardSize;
		private List<BoardSquare> squares;

		public int getSize() {
			return this.boardSize;
		}

		public List<BoardSquare> getSquares() {
			return this.squares;
		}
	
		public Board(int boardSize) {
			this.boardSize = boardSize;
			int numberOfSquares;

			if (!int.TryParse(Math.Pow(this.boardSize, 2).ToString(), out numberOfSquares)) {
				// Log to error file
				return;
			}

			squares = new List<BoardSquare>(numberOfSquares);
			for (int i = 0; i < boardSize; i++) {
				for (int j = 0; j < boardSize; j++) {
					if ((i + j) % 2 == 0)
						squares.Add(new BoardSquare(true, true, false));

				}
			}
		}
	}
}
